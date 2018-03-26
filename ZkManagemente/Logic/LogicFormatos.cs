using System;
using System.Collections.Generic;
using Database;
using Entidades;
using Util;

namespace Logic
{
    public class LogicFormatos
    {
        private DataFormatos dataFormatos;
        public List<FormatoExport> GetAll()
        {
            List<FormatoExport> formatos;
            dataFormatos = new DataFormatos();
            try
            {
                formatos = dataFormatos.GetFormatos();
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
            dataFormatos = new DataFormatos();
            try
            {
                dataFormatos.Update(f);
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error no controlado durante la actualizacion del formato.", "Fatal", ex);
            }
        }

        public void InsertFormato(FormatoExport f)
        {
            dataFormatos = new DataFormatos();
            try
            {
                dataFormatos.Insert(f);
            }
            catch(AppException appex)
            {
                throw appex;
            }
            catch(Exception ex)
            {
                throw new AppException("Error no controlado durante la creación del nuevo formato.", "Fatal", ex);
            }
        }

        public void DeleteFormato(FormatoExport f)
        {
            dataFormatos = new DataFormatos();
            try
            {
                dataFormatos.Delete(f);
            }
            catch (AppException appex)
            {
                throw appex;
            }
            catch (Exception ex)
            {
                throw new AppException("Error no controlado durante la baja del formato.", "Fatal", ex);
            }
        }
    }
}
