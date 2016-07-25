using ZkManagement.Util;

namespace ZkManagement.Logica
{
    class ControladorOperaciones
    {
        zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();

        public void Conectar(string ip, int puerto)
        {
            bool estado = false;
            estado = axCZKEM1.Connect_Net(ip, puerto);
            if (estado == false) { throw new AppException("Error al intentar conectar con dispostivo"); }
        }

        //Metodo que se ejecuta cuando el dispositivo tiene clave//
        public void Conectar(string ip, int puerto, int llave)
        {
            bool estado;
            axCZKEM1.SetCommPassword(llave);
            estado = axCZKEM1.Connect_Net(ip, puerto);
            if (estado==false) { throw new AppException("Error al intentar conectar con dispostivo");}
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
                axCZKEM1.RefreshData(nroReloj);     //actualizo datos en dispositivo
            }
            else
            {
                axCZKEM1.GetLastError(ref codError);
                throw new AppException("Error al sincronizar hora, coderror: " + codError.ToString()); 
            }
        }


    }
}
