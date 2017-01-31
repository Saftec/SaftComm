using System;
using System.Collections.Generic;
using ZkManagement.Datos;
using ZkManagement.Entidades;
using ZkManagement.Util;

namespace ZkManagement.Logica
{
    class LogicFormatos
    {
        private DataFormatos df;
        public List<FormatoExport> GetFormatos()
        {
            List<FormatoExport> formatos;
            df = new DataFormatos();
            try
            {
                formatos = df.GetFormatos();
            }
            catch(AppException appex)
            {
                throw appex;
            }
            catch(Exception ex)
            {
                throw new AppException("Error no controlado durante la obtencion de los formatos", "Fatal", ex);
            }
            return formatos;
        }

        public void UpdateFormato(FormatoExport f)
        {
            df = new DataFormatos();
            try
            {
                df.Update(f);
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error no controlado durante la actualizacion del formato", "Fatal", ex);
            }
        }
    }
}
