using System;
using System.Data;
using ZkManagement.Util;

namespace ZkManagement.Logica
{
    class ControladorOperaciones
    {
       private zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();
       private ControladorArchivos ca = new ControladorArchivos();

        public void Conectar(string ip, int puerto)
        {
            bool estado = false;
            estado = axCZKEM1.Connect_Net(ip, puerto);
            ca.Conexion(1);
            if (estado == false) { throw new AppException("Error al intentar conectar con dispostivo"); }
        }

        //Metodo que se ejecuta cuando el dispositivo tiene clave//
        public void Conectar(string ip, int puerto, int llave)
        {
            bool estado;
            axCZKEM1.SetCommPassword(llave);
            estado = axCZKEM1.Connect_Net(ip, puerto);
            ca.Conexion(1);
            if (estado==false) { throw new AppException("Error al intentar conectar con dispostivo");}
        }

        public void Desconectar()
        {
            ca.Desconectar(1);
            axCZKEM1.Disconnect();
        }

        public int GetCantidadRegistros(int nroReloj)
        {
            int codError = 0; //Controlo errores del dispositivo
            int cant = 0;
            axCZKEM1.EnableDevice(nroReloj, false);
            if (!axCZKEM1.GetDeviceStatus(nroReloj, 6, ref cant)) //La funcion "GetDeviceStatus" con el parámetro 6, devuelve la cantidad de registros.
            {
                axCZKEM1.GetLastError(ref codError);
                throw new AppException("Error al consultar la cantidad de registros en el equipo, coderror: " + codError.ToString());
            }
            axCZKEM1.EnableDevice(nroReloj, true);
            return cant;
        }

        public void BorrarRegistros(int nroReloj)
        {
            int codError = 0;
            axCZKEM1.EnableDevice(nroReloj, false);     //bloqueo dispositivo
            if (axCZKEM1.ClearGLog(nroReloj))
            {
                ca.BorradoRegistros(nroReloj);
                axCZKEM1.RefreshData(nroReloj);     //los datos deben ser actualizados en el reloj
                axCZKEM1.EnableDevice(nroReloj, true);      //desbloqueo
            }
            else
            {
                axCZKEM1.GetLastError(ref codError);
                axCZKEM1.EnableDevice(nroReloj, true);      //desbloqueo
                throw new AppException("Error al borrar los registros, coderror: " + codError.ToString());
            }
        }

        public void SincronizarHora(int nroReloj)
        {
            int codError = 0;
            if (axCZKEM1.SetDeviceTime(nroReloj))
            {
                ca.SincronizarHora(nroReloj);
                axCZKEM1.RefreshData(nroReloj);     //actualizo datos en dispositivo
            }
            else
            {
                axCZKEM1.GetLastError(ref codError);
                throw new AppException("Error al sincronizar hora, coderror: " + codError.ToString()); 
            }
        }

        public string GetModelo(int nroReloj)
        {
            string modelo = string.Empty;
            axCZKEM1.GetProductCode(nroReloj, out modelo);
            return modelo;
        }

        public string GetMac(int nroReloj)
        {
            string mac = string.Empty;
            axCZKEM1.GetDeviceMAC(nroReloj, ref mac);
            return mac;
        }

        //DESCARGA DE REGISTROS!!//
        public int DescargarRegistros(int nroReloj)
        {
            ca.IniciaDescarga();
            string sdwEnrollNumber = string.Empty;
            int idwVerifyMode = 0;
            int tipoMov = 0;
            int año = 0;
            int mes = 0;
            int dia = 0;
            int hora = 0;
            int minutos = 0;
            int segundos = 0;
            int idwWorkcode = 0;
            int codError = 0;
            int idwErrorCode = 0;
            //Declaro estas 2 variables para controlar que se descargue el total de registros
            int cantRegs = 0;
            int count = 0;

            //DECLARO DATATABLE PARA ALMACENAR LAS REGISTRACIONES
            DataTable regis = new DataTable();
            DataColumn legajo = regis.Columns.Add("Legajo", typeof(string));
            regis.Columns.Add("Registro", typeof(DateTime));
            regis.Columns.Add("Tipo", typeof(String));
            regis.Columns.Add("Reloj", typeof(Int32));
            //HASTA ACA

            axCZKEM1.EnableDevice(nroReloj, false);//Bloqueo dispositivo
            cantRegs = GetCantidadRegistros(nroReloj);
            if (axCZKEM1.ReadGeneralLogData(nroReloj)) //Leo todos los registros del dispositivo
            {
                while (axCZKEM1.SSR_GetGeneralLogData(nroReloj, out sdwEnrollNumber, out idwVerifyMode,
                           out tipoMov, out año, out mes, out dia, out hora, out minutos, out segundos, ref idwWorkcode) && codError == 0)//Obtengo los registros
                {
                    DataRow fila = regis.NewRow();
                    fila["Legajo"] = sdwEnrollNumber;
                    fila["Registro"] = new DateTime(año, mes, dia, hora, minutos, 00);
                    fila["Tipo"] = tipoMov;
                    fila["Reloj"] = Convert.ToInt32(nroReloj);
                    regis.Rows.Add(fila);

                    count++;
                    ca.EscribirRegistros(nroReloj, tipoMov, año, mes, dia, hora, minutos, sdwEnrollNumber);
                }
            }
            if (count != cantRegs) { throw new AppException("No se descargo el total de registros");}
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);

                if (idwErrorCode != 0)
                {
                    throw new AppException("Error durante la descarga de registros, codError: "+idwErrorCode);
                }
            }
            ca.DescargaRegistros(count);
            axCZKEM1.EnableDevice(nroReloj, true);
          //  cr.GuardarRegis(regis);
            return count;
        }



    }
}
