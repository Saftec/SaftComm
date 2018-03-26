using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using Util;

namespace Entidades
{
    public class Reloj : zkemkeeper.CZKEMClass
    {
        #region Propiedades

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Numero { get; set; }
        public string IP { get; set; }
        public int Puerto { get; set; }
        public string DNS { get; set; }
        public string Clave { get; set; }
        public FormatoExport Formato { get; set; }
        public bool Rutina { get; set; }
        public bool Estado { get; set; }
        // public string Tipo { get; set; }  --Esta propiedad la voy a usar para controlar si es TFT ByW o Facial.-- //

        #endregion

        #region Constructores
        public Reloj()
        {
        }

        public Reloj(int puerto, int numero, int id, string clave, string dns, string ip, string nombre, FormatoExport formato)
        {
            Id = id;
            Nombre = nombre;
            Numero = numero;
            IP = ip;
            Puerto = puerto;
            DNS = dns;
            Clave = clave;
            Formato = formato;
        }

        public Reloj(int id)
        {
            this.Id = id;
        }

        #endregion

        #region Metodos

        // Override a Equals para poder buscar instancias dentro de una list<>
        public override bool Equals(object obj)
        {
            if (obj == null) { return false; }
            if (this.GetType() != obj.GetType()) { return false; }

            Reloj r = (Reloj)obj;
            return (Id == r.Id);
        }
        // Override a ToString() para mostrar datos en ComboBox
        public override string ToString()
        {
            return (this.Nombre + " - IP: " + this.IP);
        }
        public void Conectar()
        {
            try
            {
                ActualizarIp(); //Obtengo la IP del DNS si tiene asignado un host.
            }
            catch(Exception ex)
            {
                throw ex;
            }            
            if (Clave != string.Empty)
            {
                int psw = Convert.ToInt32(Security.DesEncriptar(Clave));
                base.SetCommPassword(psw);
            }
            Estado = base.Connect_Net(IP, Puerto);
            if (Estado == false) { throw new AppException("Error al intentar conectar con dispostivo"); }
        }
        public void Desconectar()
        {
            base.Disconnect();
            Estado = false;
        }
        public int GetCantidadRegistros()
        {
            int codError = 0; //Controlo errores del dispositivo
            int cant = 0;
            base.EnableDevice(Numero, false);
            if (!base.GetDeviceStatus(Numero, 6, ref cant)) //La funcion "GetDeviceStatus" con el parámetro 6, devuelve la cantidad de registros.
            {
                base.GetLastError(ref codError);
                throw new AppException("Error al consultar la cantidad de registros en el equipo, coderror: " + codError.ToString());
            }
            base.EnableDevice(Numero, true);
            return cant;
        }
        public int BorrarRegistros()
        {
            int codError = 0;
            int cant = -1;
            base.EnableDevice(Numero, false);     //bloqueo dispositivo
            cant = GetCantidadRegistros();
            if (cant == -1)
            {
                throw new AppException("Error al consultar la cantidad de registros a borrar.");
            }
            if (base.ClearGLog(Numero))
            {
                base.RefreshData(Numero);     //los datos deben ser actualizados en el reloj
                base.EnableDevice(Numero, true);      //desbloqueo
            }
            else
            {
                base.GetLastError(ref codError);
                base.EnableDevice(Numero, true);      //desbloqueo
                throw new AppException("Error al borrar los registros, coderror: " + codError.ToString());
            }
            return cant;
        }
        public void SincronizarHora()
        {
            int codError = 0;
            if (base.SetDeviceTime(Numero))
            {
                base.RefreshData(Numero);     //actualizo datos en dispositivo
            }
            else
            {
                base.GetLastError(ref codError);
                throw new AppException("Error al sincronizar hora, coderror: " + codError.ToString());
            }
        }
        public string GetModelo()
        {
            string modelo = string.Empty;
            base.GetProductCode(Numero, out modelo);
            return modelo;
        }
        public string GetMac()
        {
            string mac = string.Empty;
            base.GetDeviceMAC(Numero, ref mac);
            return mac;
        }
        public void Reiniciar()
        {
            int error = 0;
            base.GetLastError(error);
            if (base.RestartDevice(Numero) != true) { throw new AppException("Error al intentar reiniciar el dispositivo, error: " + error.ToString()); }
        }
        public void Inicializar()
        {
            if (base.ClearKeeperData(Numero) != true)
            {
                int error = 0;
                base.GetLastError(error);
                throw new AppException("Error al intentar inicializar el dispositivo, error: " + error.ToString());
            }
            base.RefreshData(Numero); //Refresh a los datos del equipo.
        }
        public void EliminarAdmins()
        {
            int coderror = 0;
            if (base.ClearAdministrators(Numero))
            {
                base.RefreshData(Numero);
            }
            else
            {
                base.GetLastError(ref coderror);
                throw new AppException("Error al intentar eliminar los administradores del equipo, error: " + coderror.ToString());
            }
        }

        //DESCARGA DE REGISTROS!!//
        public List<Fichada> DescargarRegistros()
        {
            string legajoEnReloj = string.Empty;            
            int tipoMov ,año, mes, dia, hora, minutos, segundos, idwVerifyMode, idwWorkCode = 0;          
            int codError = 0;
            int idwErrorCode = 0;

            //Declaro estas 2 variables para controlar que se descargue el total de registros
            int cantRegs = 0;
            int count = 0;

            //DECLARO LIST PARA ALMACENAR LAS REGISTRACIONES
            List<Fichada> fichadas = new List<Fichada>();

            base.EnableDevice(Numero, false);//Bloqueo dispositivo
            cantRegs = GetCantidadRegistros();
            if (base.ReadGeneralLogData(Numero)) //Trae todos los registros a la memoria de la pc
            {
                while (base.SSR_GetGeneralLogData(Numero, out legajoEnReloj, out idwVerifyMode, out tipoMov, out año, out mes, out dia, out hora, out minutos, out segundos, ref idwWorkCode) && codError == 0)//Obtengo los registros
                {
                    Fichada f = new Fichada();
                    f.Registro = new DateTime(año, mes, dia, hora, minutos, segundos);
                    f.Tipo = tipoMov;
                    f.Empleado.Legajo = legajoEnReloj;
                    f.Reloj.Id = Id;
                    f.Reloj.Numero = Numero;
                    fichadas.Add(f);
                    count++;
                }
            }
            if (count != cantRegs) { throw new AppException("No se descargo el total de registros"); }
            else
            {
                base.GetLastError(ref idwErrorCode);

                if (idwErrorCode != 0)
                {
                    throw new AppException("Error durante la descarga de registros, codError: " + idwErrorCode);
                }
            }
            base.EnableDevice(Numero, true);
            return fichadas;
        }
        public DataTable DescargarInfo()
        {
            //Inicializo todas las variables necesarias//
            string legajoEnReloj = "";
            string nombre = "";
            string contraseña = "";
            int privilegio = 0;          //Este codigo fue copiado de la documentación. 
            bool bEnabled = false;       //Solo modifico el nombre de las variables que utilizo.
            //Hasta aca//
            int codError = 0;

            DataTable usuariosDispositivo = new DataTable();
            usuariosDispositivo.Columns.Add("Legajo", typeof(string));
            usuariosDispositivo.Columns.Add("Nombre", typeof(string));
            usuariosDispositivo.Columns.Add("Pin", typeof(string));
            usuariosDispositivo.Columns.Add("Tarjeta", typeof(string));
            usuariosDispositivo.Columns.Add("Privilegio", typeof(int));

            base.EnableDevice(Numero, false);

            base.ReadAllUserID(Numero);//Trae toda la información de usuario a la memoria.

            while (base.SSR_GetAllUserInfo(Numero, out legajoEnReloj, out nombre, out contraseña, out privilegio, out bEnabled) && codError==0)
            {
                string tarjeta = string.Empty;
                DataRow fila = usuariosDispositivo.NewRow();
                fila["Legajo"] = legajoEnReloj;
                fila["Nombre"] = nombre;
                fila["Pin"] = contraseña;
                fila["Privilegio"] = privilegio;
                if(base.GetStrCardNumber(out tarjeta))
                {
                    fila["tarjeta"] = tarjeta;
                }
                usuariosDispositivo.Rows.Add(fila);
            }
            base.GetLastError(ref codError);
            if (codError != 0)
            {
                throw new AppException("Error durante la descarga de datos de usuario, CodError: " + codError.ToString());
            }
            base.EnableDevice(Numero, true);
            return usuariosDispositivo;
        }
        public void LeerTodasLasHuellas()
        {
            int codError = 0;
            base.EnableDevice(Numero, false);
            if (!base.ReadAllTemplate(Numero))
            {
                base.GetLastError(ref codError);
                throw new AppException("Error durante la lectura de huellas, CodError: " + codError.ToString());
            }
        }
        public List<Huella> ObtenerHuella (Empleado emp)
        {
            /* Tengo que recorrer SI O SI todo los fingerIndex porque si la huella fue cargada desde otro equipo
             * No se que fingerindex trae asignado y no la puedo leer si no recorro todos. */
            int tmpLenght = 0;
            int flag = 0;
            string template = string.Empty;
            List<Huella> huellas = new List<Huella>();

            base.EnableDevice(Numero, false);

            for (int fingerIndex=-1; fingerIndex<10; fingerIndex++)
            {
                if(base.GetUserTmpExStr(Numero, emp.Legajo, fingerIndex, out flag, out template, out tmpLenght))
                {
                    Huella huella = new Huella(template, emp, fingerIndex, tmpLenght, flag);
                    huellas.Add(huella);
                }
            }
           // base.GetLastError(ref codError);
           /* if (codError != 1)
            {
                throw new AppException("Error al descargar la huella del usuario: " + legajo + ". CodError: " + codError.ToString());
            }*/
            base.EnableDevice(Numero, true);
            return huellas;
        }
        public void ActivarDispositivo()
        {
            base.EnableDevice(Numero, true);
        }
        public void AgregarHuellas(Empleado emp)
        {
            int codError = 0;

            foreach(Huella h in emp.Huellas)
            {
                if(!base.SetUserTmpExStr(Numero, emp.Legajo.Trim(), h.FingerIndex, h.Flag, h.Template.Trim()))
                {
                    base.GetLastError(ref codError);
                    throw new AppException("Error durante la carga de huellas, CodErro= " + codError.ToString());
                }
            }
            base.RefreshData(Numero);         
        }

        // ESTE MÉTODO SÓLO ENVÍA LA INFO DE USUARIO, SIN HUELLAS NI ROSTROS //
        public void CargarInfoUsuario(Empleado emp)
        {
            int codErrror = 0;
                if (emp.Tarjeta != null)
                {
                    base.SetStrCardNumber(emp.Tarjeta.PadLeft(10, '0'));
                }
                if (emp.Pin == "0")
                {
                    if(!base.SSR_SetUserInfo(Numero, emp.Legajo, emp.Nombre, null, emp.Privilegio, true))
                    {
                        base.GetLastError(ref codErrror);
                        throw new AppException("Error al intentar cargar infor de usuario, CodError= " + codErrror.ToString());
                    }
                }
                else
                {
                    if(!base.SSR_SetUserInfo(Numero, emp.Legajo, emp.Nombre, emp.Pin, emp.Privilegio, true))
                    {
                        base.GetLastError(ref codErrror);
                        throw new AppException("Error al intentar cargar infor de usuario, CodError= " + codErrror.ToString());
                    }
                }                           
        }
        public void EnviarMensaje(int idSMS, string legajo)  //Se debe indicar el ID al mensaje que DEBE ESTAR guardado en el equipo.
        {
            if(!base.SSR_SetUserSMS(Numero, legajo, idSMS))
            {
                throw new AppException("Error al intentar enviar el mensaje");
            }
        }
        public void EliminarUsuarios(List<string> legajos)
        {
            int codError = 0;
            foreach(string leg in legajos)
            {
                if (!base.SSR_DeleteEnrollData(Numero, leg, 12)) // El parámetro 12 elimina el usuario por completo del equipo. 
                {
                    base.GetLastError(ref codError);
                    throw new AppException("Error durante el borrado de usuarios, CodError= " + codError.ToString());
                }
            }
        }

        //Estos métodos deshabilitan o habilitan el ingreso al menú de un usuario administrador.        
        public void Habilitar(string legajo)
        {
            if(!base.SSR_EnableUser(Numero, legajo, true))
            {
                throw new AppException("Error al intentar habilitar el usuario");
            }
            
        }
        public void Deshabilitar()
        {
            base.EnableDevice(Numero, false);
        }
        public void IniciarBatch()
        {
            int codError = 0;
            base.EnableDevice(Numero, false);
            if(!base.BeginBatchUpdate(Numero, 1))
            {
                base.GetLastError(ref codError);
                throw new AppException("Error al intentar iniciar subida en modo batch, CodError= " + codError.ToString());
            }
        }
        public void EjecutarBatch()
        {
            int codError = 0;
            if (!base.BatchUpdate(Numero))
            {
                base.GetLastError(ref codError);
                throw new AppException("Error al intentar ejecutar la subida en modo batch, CodError= " + codError.ToString());
            }
            base.EnableDevice(Numero, true);
        }
        private void ActualizarIp()
        {
            if (DNS != string.Empty)
            {
                IPHostEntry ipHost;
                try
                {
                    ipHost = Dns.GetHostEntry(DNS);
                    if (ipHost.AddressList.Length > 0)
                    {
                        IP = ipHost.AddressList[0].ToString();
                    }
                    else
                    {
                        throw new AppException("Error al intentar obtener ip del host");
                    }
                }
                catch(Exception ex)
                {
                    Logger.LogFatal(ex.StackTrace);
                    throw new Exception("Error al consultar la ip del host DNS");
                }

            }
        } 
        
        #endregion
        }
    }