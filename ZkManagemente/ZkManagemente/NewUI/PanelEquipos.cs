using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ZkManagement.Entidades;
using ZkManagement.Logica;
using ZkManagement.Util;

namespace ZkManagement.NewUI.Generic
{
    public partial class PanelEquipos : GenericPanel
    {
        //         PATRON SINGLETON            //
        private static PanelEquipos _instancia;

        public static PanelEquipos GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new PanelEquipos();
            }
            return _instancia;
        }

        private LogicReloj lr;
        private Reloj relojAct;

        public PanelEquipos()
        {
            InitializeComponent();
            relojAct = new Reloj();
        }

        // SETEAR MODELO - MAC - CANT.REGIS AL CONECTAR //
        #region Operaciones
        // CONECTAR //
        private void linkConnect_Click(object sender, System.EventArgs e)
        {
            try
            {
                relojAct = MapearDeGrid();
            }
            catch (Exception ex)
            {
                InformarError(ex.Message, "Conectar Reloj.");
                return;
            }
            if (relojAct.Estado)
            {
                InformarError("El dispositivo: " + relojAct.Numero.ToString() + " ya se encuentra conectado.", "Conectar Reloj.");
                return;
            }
            try
            {
                relojAct.Conectar();
                relojAct.Estado = true;
                MapearAGrid(relojAct);
                Informar("El dispositivo: " + relojAct.Numero.ToString() + " se conectó correctamente", "Conectar Reloj.");
            }
            catch (Exception ex)
            {
                InformarError(ex.Message, "Conectar Reloj.");
            }
        }
        // DESCONECTAR //
        private void linkDesconnect_Click(object sender, EventArgs e)
        {
            try
            {
                relojAct = MapearDeGrid();
            }
            catch (Exception ex)
            {
                InformarError(ex.Message, "Desconectar Reloj.");
            }
            if (!relojAct.Estado)
            {
                InformarError("El dispositivo: " + relojAct.Numero.ToString() + " ya se encuentra desconectado.", "Desconectar Reloj.");
                return;
            }
            try
            {
                relojAct.Desconectar();
                relojAct.Estado = false;
                MapearAGrid(relojAct);
                Informar("El dispositivo: " + relojAct.Numero.ToString() + " se desconectó correctamente", "Desconectar Reloj.");
            }
            catch (Exception ex)
            {
                InformarError(ex.Message, "Desconectar Reloj.");
            }
        }
        // SINCRONIZAR HORA //
        private void linkSincHora_Click(object sender, EventArgs e)
        {
            try
            {
                relojAct = MapearDeGrid();
            }
            catch(Exception ex)
            {
                InformarError(ex.Message, "Sincronizar Hora.");
            }
            if (!relojAct.Estado)
            {
                InformarError("El equipo " + relojAct.Numero.ToString() + " no está conectado.", "Sincronizar Hora.");
                return;
            }
            try
            {
                relojAct.SincronizarHora();
                Informar("Se sincronizó correctamente la hora con el reloj: " + relojAct.Numero.ToString(), "Sincronizar Hora.");
            }
            catch(Exception ex)
            {
                InformarError(ex.Message, "Sincronizar Hora.");
            }
        }
        // DESCARGAR REGIS //
        private void linkDescRegs_Click(object sender, EventArgs e)
        {

        }
        // BORRAR REGIS //
        private void linkBorrarRegs_Click(object sender, EventArgs e)
        {
            try
            {
                relojAct = MapearDeGrid();
            }
            catch (Exception ex)
            {
                InformarError(ex.Message, "Borrar Registros.");
            }
            if (!relojAct.Estado)
            {
                InformarError("El equipo " + relojAct.Numero.ToString() + " no está conectado.", "Borrar Registros.");
                return;
            }
            try
            {
                if (base.Question("¿Está seguro que desea eliminar todos los registros del dispositivo?", "Borrar Registros."))
                {
                    int cant = 0;
                    cant=relojAct.BorrarRegistros();
                    lr = new LogicReloj();
                    lr.ActualizarBorrado(relojAct, cant); //Guarda la info. del borrado en la BD
                    Informar("Se borraron " + cant.ToString() + " registros del reloj: " + relojAct.Numero.ToString(), "Borrar Registros.");
                }
                else
                {
                    return;
                }
            }
            catch(Exception ex)
            {
                InformarError(ex.Message, "Borrar Registros.");
            }
        }
        #endregion

        #region Grid
        public void RefreshGrid()
        {
            lr = new LogicReloj();
            gridEquipos.DataSource = null;
            DataTable relojes;
            try
            {
                relojes = ConvertToDataTable(lr.TodosRelojes());
                gridEquipos.DataSource = relojes;
            }
            catch (Exception ex)
            {
                base.InformarError(ex.Message, "Consultar Relojes.");
            }
        }
        private Reloj MapearDeGrid()
        {
            Reloj r = new Reloj();
            int valor = 0; // Lo uso para los TryParse a int.

            if (int.TryParse(gridEquipos.CurrentRow.Cells["Id"].ToString(), out valor))
            {
                r.Id = valor;
            }
            else
            {
                throw new AppException("Error al intentar convertir Id a INT.");
            }
            if (int.TryParse(gridEquipos.CurrentRow.Cells["Numero"].ToString(), out valor))
            {
                r.Numero = valor;
            }
            else
            {
                throw new AppException("Error al intentar convertir Numero de equipo a INT.");
            }
            if (int.TryParse(gridEquipos.CurrentRow.Cells["Puerto"].ToString(), out valor))
            {
                r.Puerto = valor;
            }
            else
            {
                throw new AppException("Error al intentar convertir el puerto a INT.");
            }
            if (gridEquipos.CurrentRow.Cells["Estado"].ToString() == "Conectado")
            {
                r.Estado = true;
            }
            else
            {
                r.Estado = false;
            }

            r.Nombre = gridEquipos.CurrentRow.Cells["Nombre"].ToString();
            r.Clave = gridEquipos.CurrentRow.Cells["Clave"].ToString();
            r.DNS = gridEquipos.CurrentRow.Cells["DNS"].ToString();
            r.Ip = gridEquipos.CurrentRow.Cells["IP"].ToString();

            return r;
        }
        private void MapearAGrid(Reloj r)
        {
            if (r.Estado)
            {
                gridEquipos.CurrentRow.Cells["Estado"].Value = "Conectado";
            }
            else
            {
                gridEquipos.CurrentRow.Cells["Estado"].Value = "Desconectado";
            }
        }
        #endregion
        private DataTable ConvertToDataTable(List<Reloj> relojes)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("IP");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("IdReloj");
            dt.Columns.Add("Puerto");
            dt.Columns.Add("DNS");
            dt.Columns.Add("Numero");
            dt.Columns.Add("Clave");
            dt.Columns.Add("Estado");

            foreach (Reloj r in relojes)
            {
                DataRow row = dt.NewRow();
                row["IP"] = r.Ip;
                row["Nombre"] = r.Nombre;
                row["IdReloj"] = r.Id.ToString();
                row["Puerto"] = r.Puerto.ToString();
                row["Numero"] = r.Numero.ToString();
                row["Clave"] = r.Clave;
                row["DNS"] = r.DNS;

                if (r.Estado)
                {
                    row["Estado"] = "Conectado";
                }else
                {
                    row["Estado"] = "Desconectado";
                }

                dt.Rows.Add(row);
            }
            return dt;
        }

        protected new void InformarError(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtLog.SelectionColor = Color.Red;
            txtLog.AppendText(mensaje);
        }
        protected new void Informar(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtLog.SelectionColor = Color.Black;
            txtLog.AppendText(mensaje);
        }
    }
}
