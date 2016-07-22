using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZkManagement.Logica
{
    class ControladorOperaciones
    {

        public bool Conectar(string ip, int puerto)
        {
            zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();
            bool estado = false;
            estado = axCZKEM1.Connect_Net(ip, Convert.ToInt32(4370));
            return estado;
        }

        //Metodo que se ejecuta cuando el dispositivo tiene clave//
        public bool Conectar(string ip, int puerto, int llave)
        {
            zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();
            bool estado = false;
            axCZKEM1.SetCommPassword(llave);
            estado = axCZKEM1.Connect_Net(ip, Convert.ToInt32(4370));
            return estado;
        }

        public int GetCantidadRegistros(int nroReloj)
        {
            zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();
            int codError = 0; //Controlo errores del dispositivo
            int cant = 0;

            axCZKEM1.EnableDevice(nroReloj, false);
            if (!axCZKEM1.GetDeviceStatus(nroReloj, 6, ref cant)) //La funcion "GetDeviceStatus" con el parámetro 6, devuelve la cantidad de registros.
            {
                axCZKEM1.GetLastError(ref codError);
                return -1;
            }
            axCZKEM1.EnableDevice(nroReloj, true);
            return cant;
        }

        public bool BorrarRegistros(int nroReloj)
        {
            zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();
            int idwErrorCode = 0;
            axCZKEM1.EnableDevice(nroReloj, false);     //bloqueo dispositivo
            if (axCZKEM1.ClearGLog(nroReloj))
            {
                axCZKEM1.RefreshData(nroReloj);     //los datos deben ser actualizados en el reloj
                axCZKEM1.EnableDevice(nroReloj, true);      //desbloqueo
                return true;
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                axCZKEM1.EnableDevice(nroReloj, true);      //desbloqueo
                return false;
            }
        }

        public bool SincronizarHora(int nroReloj)
        {
            zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();
            int idwErrorCode = 0;
            if (axCZKEM1.SetDeviceTime(nroReloj))
            {
                axCZKEM1.RefreshData(nroReloj);     //actualizo datos en dispositivo
                return true;
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                return false;
            }
        }


    }
}
