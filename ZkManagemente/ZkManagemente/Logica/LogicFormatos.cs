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
        private DataConfigs dc;
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
                throw new AppException("Error no controlado durante la actualizacion del formato.", "Fatal", ex);
            }
        }

        public void InsertFormato(FormatoExport f)
        {
            df = new DataFormatos();
            try
            {
                df.Insert(f);
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
            df = new DataFormatos();
            try
            {
                df.Delete(f);
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
            dc = new DataConfigs();
            try
            {
                dc.SetConfig(2, f.Id.ToString());
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
            df = new DataFormatos();
            dc = new DataConfigs();
            FormatoExport f;
            int id;
            string valor;

            try
            {
                valor=dc.GetConfig(2);
                if(!int.TryParse(valor, out id))
                {
                    throw new AppException("Error al intentar el id de formato a entero");
                }
                f = df.GetById(id);
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
