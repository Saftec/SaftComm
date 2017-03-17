using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Util;
using System.Threading.Tasks;

namespace Logic
{
    public class LogicOperaciones
    {
        public bool Connect(Reloj device)
        {
            bool state = false;
            try
            {
                device.Conectar();
                state = true;
            }
            catch(AppException appex)
            {
                throw appex;                
            }
            catch(Exception ex)
            {
                throw new AppException("Error no controlado al intentar conectar con dispositivo.", "Fatal", ex);
            }
            return state;
        }

        public void Disconnect(Reloj device)
        {
            try
            {
                device.Desconectar();
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error no controlado al intentar desconectar el dispositivo.", "Fatal", ex);
            }
        }
        public void SincHora(Reloj device)
        {
            try
            {
                device.SincronizarHora();
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error no controlado al intentar sincronizar hora con el dispositivo.", "Fatal", ex);
            }
        }

        public List<Fichada> DownloadRegis(Reloj device)
        {
            List<Fichada> fichadas;
            try
            {
                fichadas=device.DescargarRegistros();
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error no controlado al intentar descargar los registros del dispositivo.", "Fatal", ex);
            }
            return fichadas;
        }

        public int DeleteRegis(Reloj device)
        {
            int cant = 0;
            try
            {
                cant = device.BorrarRegistros();
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error no controlado al intentar eliminar los registros del dispositivo.", "Fatal", ex);
            }
            return cant;
        }
        public void DeleteAdmin(Reloj device)
        {
            try
            {
                device.EliminarAdmins();
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error no controlado al intentar eliminar los administradores del dispositivo.", "Fatal", ex);
            }
        }
        public void Reboot(Reloj device)
        {
            try
            {
                device.Reiniciar();
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error no controlado al intentar reiniciar el dispositivo.", "Fatal", ex);
            }
        }
        public void InitializeDevice(Reloj device)
        {
            try
            {
                device.Inicializar();
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error no controlado al intentar inicializar el dispositivo.", "Fatal", ex);
            }
        }
    }
}
