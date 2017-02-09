using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ZkManagement.Entidades;
using ZkManagement.Logica;
using ZkManagement.Util;

namespace ZkManagement.NewUI
{
    public partial class PanelReloj : GenericPanel
    {
        private static PanelReloj _instancia;

        public static PanelReloj Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new PanelReloj();
                }
                return _instancia;
            }
        }
        private LogicReloj lr;
        private Reloj relojAct = new Reloj();
        private List<Reloj> equipos;
        public PanelReloj()
        {
            InitializeComponent();
        }

        private void NewReloj_Load(object sender, EventArgs e)
        {

        }

        #region Operaciones
        private void linkConnect_Click(object sender, EventArgs e)
        {
            try
            {
                relojAct = MapearDeGrid();                
                if (relojAct.Estado)
                {
                    InformarError("El dispositivo: '" + relojAct.Nombre + "' ya se encuentra conectado.", "Conectar Reloj.");
                    return;
                }
                relojAct.Conectar();
                MapearAGrid(relojAct);
                LoguearInforme("El dispositivo: '" + relojAct.Nombre + "' se conectó correctamente");
            }
            catch(AppException appex)
            {
                LoguearError(appex.Message);
            }
            catch (Exception ex)
            {
                InformarError(ex.Message, "Conectar.");
            }
        }

        private void linkDesconnect_Click(object sender, EventArgs e)
        {
            try
            {
                relojAct = MapearDeGrid();
                if (!relojAct.Estado)
                {
                    InformarError("El dispositivo: '" + relojAct.Nombre + "' ya se encuentra desconectado.", "Desconectar Reloj.");
                    return;
                }
                relojAct.Desconectar();
                MapearAGrid(relojAct);
                LoguearInforme("El dispositivo: '" + relojAct.Nombre + "' se desconectó correctamente");
            }
            catch (AppException appex)
            {
                LoguearError(appex.Message);
            }
            catch (Exception ex)
            {
                InformarError(ex.Message, "Desconectar.");
            }
        }

        private void linkSincHora_Click(object sender, EventArgs e)
        {
            try
            {
                relojAct = MapearDeGrid();                
                if (!relojAct.Estado)
                {
                    InformarError("El equipo '" + relojAct.Nombre + "' no está conectado.", "Sincronizar Hora.");
                    return;
                }
                relojAct.SincronizarHora();
                LoguearInforme("Se sincronizó correctamente la hora con el reloj: '" + relojAct.Nombre + "'");
            }
            catch(AppException appex)
            {
                LoguearError(appex.Message);
            }
            catch (Exception ex)
            {
                InformarError(ex.Message, "Sincronizar Hora.");
            }
        }

        private void linkDescRegs_Click(object sender, EventArgs e)
        {
            try
            {
                relojAct = MapearDeGrid();
                if (!relojAct.Estado)
                {
                    InformarError("El equipo '" + relojAct.Nombre + "' no está conectado.", "Descargar Registros.");
                    return;
                }
                List<Fichada> fichadas;
                List<string> desconocidos;
                LogicRegistros lr = new LogicRegistros();
                fichadas = relojAct.DescargarRegistros();
                desconocidos = lr.AgregarRegis(fichadas);
                if (desconocidos.Count > 0)
                {
                    LoguearError("Los siguientes legajos son desconocidos: ");
                    foreach (string l in desconocidos)
                    {
                        LoguearError("Legajo: " + l);
                    }
                }
                LoguearInforme("Se descargaron: " + fichadas.Count.ToString() + " registros.");
            }
            catch (AppException appex)
            {
                LoguearError(appex.Message);
            }
            catch (Exception ex)
            {
                InformarError(ex.Message, "Descargar Registros.");
            }
        }

        private void linkBorrarRegs_Click(object sender, EventArgs e)
        {
            try
            {
                relojAct = MapearDeGrid();
                if (!relojAct.Estado)
                {
                    InformarError("El equipo '" + relojAct.Nombre + "' no está conectado.", "Borrar Registros.");
                    return;
                }
                if (base.Question("¿Está seguro que desea eliminar todos los registros del dispositivo?", "Borrar Registros."))
                {
                    int cant = 0;
                    cant = relojAct.BorrarRegistros();
                    lr = new LogicReloj();
                    lr.ActualizarBorrado(relojAct, cant); //Guarda la info. del borrado en la BD
                    LoguearInforme("Se borraron " + cant.ToString() + " registros del reloj: '" + relojAct.Nombre + "'");
                }
                else
                {
                    return;
                }
            }
            catch (AppException appex)
            {
                LoguearError(appex.Message);
            }
            catch (Exception ex)
            {
                InformarError(ex.Message, "Borrar Registros.");
            }
        }
        #endregion

        // FALTA HACER EL DELETE //
        #region ABM
        private void linkNuevo_Click(object sender, EventArgs e)
        {
            EditReloj er = new EditReloj();
            Reloj r = new Reloj();
            try
            {
                r.Id = 0;
                er.MapearAFormulario(r);
                er.Show();
            }
            catch (Exception ex)
            {
                base.InformarError(ex.Message, "Agregar Equipos.");
            }
        }

        private void linkEdit_Click(object sender, EventArgs e)
        {
            try
            {
                relojAct = MapearDeGrid();
                EditReloj er = new EditReloj();
                er.MapearAFormulario(relojAct);
                er.Show();
            }
            catch (Exception ex)
            {
                base.InformarError(ex.Message, "Modificar Equipos.");
            }
        }

        private void linkDelete_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Informes
        private void LoguearInforme(string mensaje)
        {
            txtLog.SelectionColor = Color.Black;
            txtLog.AppendText(mensaje);
            txtLog.AppendText("\n");
        }
        private void LoguearError(string mensaje)
        {
            txtLog.SelectionColor = Color.Red;
            txtLog.AppendText(mensaje);
            txtLog.AppendText("\n");
        }
        #endregion

        #region Grid
        private Reloj MapearDeGrid()
        {
            Reloj r = new Reloj();
            int valor = 0; // Lo uso para los TryParse a int.

            if (int.TryParse(gridEquipos.CurrentRow.Cells["Id"].Value.ToString(), out valor))
            {
                r.Id = valor;
            }
            else
            {
                throw new AppException("Error al intentar convertir Id a INT.");
            }
            return (equipos[equipos.IndexOf(r)]);
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

        public void RefreshGrid()
        {
            lr = new LogicReloj();
            gridEquipos.DataSource = null;
            DataTable relojes;
            try
            {
                gridEquipos.AutoGenerateColumns = false;
                equipos = lr.TodosRelojes();
                relojes = ConvertToDataTable(equipos);
                gridEquipos.DataSource = relojes;
            }
            catch (Exception ex)
            {
                base.InformarError(ex.Message, "Consultar Relojes.");
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
                row["Clave"] = Encrypt.DesEncriptar(r.Clave);
                row["DNS"] = r.DNS;

                if (r.Estado)
                {
                    row["Estado"] = "Conectado";
                }
                else
                {
                    row["Estado"] = "Desconectado";
                }

                dt.Rows.Add(row);
            }
            return dt;
        }
    }
}
