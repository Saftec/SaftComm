using System;
using System.Collections.Generic;
using Database;
using Entidades;
using Util;

namespace Logic
{
    public class LogicFormatos
    {
        private DataConfigs dataConfigs;
        private DataFormatos dataFormatos;
        public List<FormatoExport> GetFormatos()
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
        public void SetFormatoActivo(FormatoExport f)
        {
            dataConfigs = new DataConfigs();
            try
            {
                dataConfigs.SetConfig(2, f.Id.ToString());
            }
            catch(AppException appex)
            {
                throw appex;
            }
            catch(Exception ex)
            {
                throw new AppException("Error no controlado al intentar establecer el formato activo", "Fatal", ex);
            }
                        
        }

        public FormatoExport GetFormatoActivo()
        {
            dataConfigs = new DataConfigs();
            dataFormatos = new DataFormatos();
            FormatoExport f;
            int id;
            string valor;

            try
            {
                valor=dataConfigs.GetConfig(2);
                if(!int.TryParse(valor, out id))
                {
                    throw new AppException("Error al intentar el id de formato a entero");
                }
                f = dataFormatos.GetById(id);
            }
            catch(AppException appex)
            {
                throw appex;
            }
            catch(Exception ex)
            {
                throw new AppException("Error no controlado al intentar obtener el formato activo", "Fatal", ex);
            }
            return f;
        }
    }
}
