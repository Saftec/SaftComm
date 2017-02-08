using System;
using System.Collections.Generic;
using ZkManagement.Datos;
using ZkManagement.Entidades;
using ZkManagement.Util;

namespace ZkManagement.Logica
{
    class LogicFormatos
    {
        public List<FormatoExport> GetFormatos()
        {
            List<FormatoExport> formatos;
            try
            {
                formatos = DataFormatos.Instancia.GetFormatos();
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
            try
            {
                DataFormatos.Instancia.Update(f);
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
            try
            {
                DataFormatos.Instancia.Insert(f);
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
            try
            {
                DataFormatos.Instancia.Delete(f);
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
            try
            {
                DataConfigs.Instancia.SetConfig(2, f.Id.ToString());
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
            FormatoExport f;
            int id;
            string valor;

            try
            {
                valor=DataConfigs.Instancia.GetConfig(2);
                if(!int.TryParse(valor, out id))
                {
                    throw new AppException("Error al intentar el id de formato a entero");
                }
                f = DataFormatos.Instancia.GetById(id);
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
