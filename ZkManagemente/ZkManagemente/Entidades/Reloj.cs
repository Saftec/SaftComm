using System;
using System.Collections.Generic;
using System.Data;
using ZkManagement.Util;

namespace ZkManagement.Entidades
{
    public class Reloj : zkemkeeper.CZKEMClass
    {
        private Logica.Logger lg = new Logica.Logger();
        private int puerto;
        private int numero;
        private int id;
        private string clave;
        private string dns;
        private string ip;
        private string nombre;
        private bool estado;
     // private string tipo;  --Esta variable la voy a usar para controlar si es TFT ByW o Facial.-- //

        #region Constructores
        public Reloj()
        {
        }

        public Reloj(int puerto, int numero, int id, string clave, string dns, string ip, string nombre)
        {
            this.puerto = puerto;
            this.numero = numero;
            this.id = id;
            this.clave = clave;
            this.dns = dns;
            this.ip = ip;
            this.nombre = nombre;
        }

        public Reloj(int id)
        {
            this.id = id;
        }

        #endregion
        #region Propiedades

        public string DNS
        {
            get { return dns; }
            set { dns = value; }
        }
        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public string Ip
        {
            get { return ip; }
            set { ip = value; }
        }


        public int Puerto
        {
            get { return puerto; }
            set { puerto = value; }
        }

        #endregion

        #region Metodos
        public override bool Equals(object obj)
        {
            if (obj == null) { return false; }
            if (this.GetType() != obj.GetType()) { return false; }

            Reloj r = (Reloj)obj;
            return (this.id == r.id);
        }

        public void Conectar()
        {
            bool estado;
            if (this.clave != string.Empty) { base.SetCommPassword(Convert.ToInt32(clave)); }
            estado = base.Connect_Net(ip, puerto);
            lg.Conexion(this.numero);
            if (estado == false) { throw new AppException("Error al intentar conectar con dispostivo"); }
        }

        public void Desconectar()
        {
            lg.Desconectar(this.numero);
            base.Disconnect();
        }
        public int GetCantidadRegistros()
        {
            int codError = 0; //Controlo errores del dispositivo
            int cant = 0;
            base.EnableDevice(this.numero, false);
            if (!base.GetDeviceStatus(this.numero, 6, ref cant)) //La funcion "GetDeviceStatus" con el parámetro 6, devuelve la cantidad de registros.
            {
                base.GetLastError(ref codError);
                throw new AppException("Error al consultar la cantidad de registros en el equipo, coderror: " + codError.ToString());
            }
            base.EnableDevice(this.numero, true);
            return cant;
        }
        public void BorrarRegistros()
        {
            int codError = 0;
            int cant;
            base.EnableDevice(this.numero, false);     //bloqueo dispositivo
            cant = GetCantidadRegistros();
            if (base.ClearGLog(this.numero))
            {
                lg.BorradoRegistros(cant);
                base.RefreshData(this.numero);     //los datos deben ser actualizados en el reloj
                base.EnableDevice(this.numero, true);      //desbloqueo
            }
            else
            {
                base.GetLastError(ref codError);
                base.EnableDevice(this.numero, true);      //desbloqueo
                throw new AppException("Error al borrar los registros, coderror: " + codError.ToString());
            }
        }
        public void SincronizarHora()
        {
            int codError = 0;
            if (base.SetDeviceTime(this.numero))
            {
                lg.SincronizarHora(this.numero);
                base.RefreshData(this.numero);     //actualizo datos en dispositivo
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
            base.GetProductCode(this.numero, out modelo);
            return modelo;
        }
        public string GetMac()
        {
            string mac = string.Empty;
            base.GetDeviceMAC(this.numero, ref mac);
            return mac;
        }
        public void Reiniciar()
        {
            int error = 0;
            base.GetLastError(error);
            if (base.RestartDevice(this.numero) != true) { throw new AppException("Error al intentar reiniciar el dispositivo, error: " + error.ToString()); }
        }
        public void Inicializar()
        {
            if (base.ClearKeeperData(this.numero) != true)
            {
                int error = 0;
                base.GetLastError(error);
                throw new AppException("Error al intentar inicializar el dispositivo, error: " + error.ToString());
            }
            base.RefreshData(this.numero); //Refresh a los datos del equipo.
        }
        public void EliminarAdmins()
        {
            int coderror = 0;
            if (base.ClearAdministrators(this.numero))
            {
                base.RefreshData(this.numero);
            }
            else
            {
                base.GetLastError(ref coderror);
                throw new AppException("Error al intentar eliminar los administradores del equipo, error: " + coderror.ToString());
            }
        }

        //DESCARGA DE REGISTROS!!//
        public DataTable DescargarRegistros()
        {
            lg.IniciaDescarga();
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

            base.EnableDevice(this.numero, false);//Bloqueo dispositivo
            cantRegs = GetCantidadRegistros();
            if (base.ReadGeneralLogData(this.numero)) //Leo todos los registros del dispositivo
            {
                while (base.SSR_GetGeneralLogData(this.numero, out sdwEnrollNumber, out idwVerifyMode,
                           out tipoMov, out año, out mes, out dia, out hora, out minutos, out segundos, ref idwWorkcode) && codError == 0)//Obtengo los registros
                {
                    DataRow fila = regis.NewRow();
                    fila["Legajo"] = sdwEnrollNumber;
                    fila["Registro"] = new DateTime(año, mes, dia, hora, minutos, 00);
                    fila["Tipo"] = tipoMov;
                    fila["Reloj"] = Convert.ToInt32(this.Id);
                    regis.Rows.Add(fila);

                    count++;
                    lg.EscribirRegistros(this.numero, tipoMov, año, mes, dia, hora, minutos, sdwEnrollNumber);
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
            lg.DescargaRegistros(count);
            base.EnableDevice(this.numero, true);
            return regis;
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

            DataTable usuariosDispositivo = new DataTable();
            usuariosDispositivo.Columns.Add("Legajo", typeof(string));
            usuariosDispositivo.Columns.Add("Nombre", typeof(string));
            usuariosDispositivo.Columns.Add("Pin", typeof(string));
            usuariosDispositivo.Columns.Add("Tarjeta", typeof(string));
            usuariosDispositivo.Columns.Add("Privilegio", typeof(int));

            base.EnableDevice(this.numero, false);

            base.ReadAllUserID(this.numero);//Trae toda la información de usuario a la memoria.

            while (base.SSR_GetAllUserInfo(this.numero, out legajoEnReloj, out nombre, out contraseña, out privilegio, out bEnabled))//get all the users' information from the memory
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
            base.EnableDevice(this.numero, true);
            return usuariosDispositivo;
        }

        public void LeerTodasLasHuellas()
        {
            base.EnableDevice(this.numero, false);
            base.ReadAllTemplate(this.numero);
        }

        public List<Huella> ObtenerHuella (string legajo)
        {
            /* Tengo que recorrer SI O SI todo los fingerIndex porque si la huella fue cargada desde otro equipo
             * No se que fingerindex trae asignado y no la puedo leer si no recorro todos. */

            int tmpLenght = 0;
            int flag = 0;
            string template = string.Empty;
            List<Huella> huellas = new List<Huella>();

            //Controlar errores!!//
            for (int fingerIndex=0; fingerIndex<10; fingerIndex++)
            {
                if(base.GetUserTmpExStr(this.numero, legajo, fingerIndex, out flag, out template, out tmpLenght))
                {
                    Huella huella = new Huella(template, legajo, fingerIndex, tmpLenght, flag);
                    huellas.Add(huella);
                }
            }
            return huellas;
        }
        public void ActivarDispositivo()
        {
            base.EnableDevice(this.numero, true);
        }

        public void AgregarHuellas(List<Huella> huellas)
        {

            base.EnableDevice(this.numero, false);
            foreach(Huella h in huellas)
            {
                base.SetUserTmpExStr(this.numero, h.Legajo.Trim(), h.FingerIndex, h.Flag ,h.Template.Trim());
            }
            base.RefreshData(this.numero);
            
        }
        public void CargarInfoUsuario(List<Empleado> empleados)
        {
            int codErrror = 0;
            base.EnableDevice(this.numero, false);
            foreach(Empleado emp in empleados)
            {
                if (emp.Tarjeta != null)
                {
                    base.SetStrCardNumber(emp.Tarjeta.PadLeft(10, '0'));
                }
                if (emp.Pin == "0")
                {
                    if(!base.SSR_SetUserInfo(this.numero, emp.Legajo, emp.Nombre, null, emp.Privilegio, true))
                    {
                        base.GetLastError(ref codErrror);
                        throw new AppException("Error al intentar cargar infor de usuario, CodError= " + codErrror.ToString());
                    }
                }
                else
                {
                    if(!base.SSR_SetUserInfo(this.numero, emp.Legajo, emp.Nombre, emp.Pin, emp.Privilegio, true))
                    {
                        base.GetLastError(ref codErrror);
                        throw new AppException("Error al intentar cargar infor de usuario, CodError= " + codErrror.ToString());
                    }
                }
               
            }
        }

        public void EnviarMensaje(int idSMS, string legajo)  //Se debe indicar el ID al mensaje que DEBE ESTAR guardado en el equipo.
        {
            if(!base.SSR_SetUserSMS(this.numero, legajo, idSMS))
            {
                throw new AppException("Error al intentar enviar el mensaje");
            }
        }

        public void EliminarUsuarios(List<string> legajos)
        {
            int codError = 0;
            foreach(string leg in legajos)
            {
                if (!base.SSR_DeleteEnrollData(this.numero, leg, 12)) // El parámetro 12 elimina el usuario por completo del equipo. 
                {
                    base.GetLastError(ref codError);
                    throw new AppException("Error durante el borrado de usuarios, CodError= " + codError.ToString());
                }
            }
        }

        //Estos métodos deshabilitan o habilitan el ingreso al menú de un usuario administrador.
        
        public void Habilitar(string legajo)
        {
            if(!base.SSR_EnableUser(this.numero, legajo, true))
            {
                throw new AppException("Error al intentar habilitar el usuario");
            }
            
        }
        public void Deshabilitar(string legajo)
        {
            if(!base.SSR_EnableUser(this.numero, legajo, false))
            {
                throw new AppException("Error al inhabilitar usuario");
            }
        } 
            #endregion

        }
    }
