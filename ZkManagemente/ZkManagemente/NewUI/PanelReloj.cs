using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using ZkManagement.Entidades;
using ZkManagement.Logica;
using ZkManagement.Util;

namespace ZkManagement.NewUI
{
    public partial class PanelReloj : GenericPanel
    {
        #region Singleton
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

        private PanelReloj()
        {
            InitializeComponent();
        }
        #endregion

        private LogicReloj lr;
        private Reloj relojAct = new Reloj();
        private List<Reloj> equipos;


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
                LoguearInforme("Conectando con '" + relojAct.Nombre + "'...");
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
           /* txtLog.SelectionColor = Color.Black;          
            txtLog.AppendText(mensaje);
            txtLog.AppendText("\n");*/
            AppendTextBox(mensaje + "\n");
            Logger.GetLogger().Info(mensaje);
        }
        private void LoguearError(string mensaje)
        {
            /*txtLog.SelectionColor = Color.Red;
            txtLog.AppendText(mensaje);
            txtLog.AppendText("\n");*/
            AppendTextBox(mensaje + "\n");
            Logger.GetLogger().Info(mensaje);
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
            // VALIDO QUE HAYA QUEDADO ALGUN RELOJ CONECTADO DE UNA OPERACION ANTERIOR
            if (equipos!=null && equipos.Count > 0)
            {
                foreach(Reloj r in equipos)
                {
                    if (r.Estado)
                    {
                        r.Desconectar();
                    }
                }
            }
            // HASTA ACA

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

        #region Rutinas
        public void RutinaBajadaRegistros()
        {
            List<string> desconocidos = new List<string>();
            List<Fichada> fichadas;
            int total = 0;
            LogicRegistros lregs = new LogicRegistros();
            lr = new LogicReloj();
            LogicConfigRutinas lcr = new LogicConfigRutinas();
            LoguearInforme("--Inicio de rutina de descarga de registros");
            foreach (Reloj r in equipos)
            {
                if (r.Rutina)
                {
                    try
                    {
                        int cant = 0;
                        LoguearInforme("Conectando con '" + r.Nombre + "'...");
                        r.Conectar();
                        LoguearInforme("El dispositivo: '" + r.Nombre + "' se conectó correctamente");
                        LoguearInforme("Consultando cantidad de registros...");
                        cant=r.GetCantidadRegistros();
                        LoguearInforme(cant.ToString() + " registros por descargar");
                        LoguearInforme("Iniciando descarga de registros...");
                        fichadas = r.DescargarRegistros();
                        desconocidos = lregs.AgregarRegis(fichadas);
                        LoguearInforme("Se descargaron " + fichadas.Count.ToString() + " registros");
                        if (lcr.IsBorradoRegs())
                        {
                            LoguearInforme("Borrando registros...");
                            cant = 0;
                            cant = r.BorrarRegistros();
                            LoguearInforme(cant.ToString() + " registros eliminados correctamente.");
                            LoguearInforme("Actualizando borrado en base de datos...");
                            lr.ActualizarBorrado(r, fichadas.Count);
                            LoguearInforme("Borrado actualizado en la base de datos correctamente");
                        }
                        r.Desconectar();
                        LoguearInforme("El dispositivo: '" + r.Nombre + "' se desconectó correctamente");
                        total += fichadas.Count;
                    }
                    catch (Exception ex)
                    {
                        LoguearError("****Se produjo un error con reloj: " + r.Numero.ToString() + " durante la rutina de bajada de registros*****");
                        LoguearError("ERROR: " + ex.Message);
                    }
                }
            }
            if (desconocidos.Count > 0)
            {
                LoguearError("ATENCION, se encontraron empleados desconocidos durante la descarga");
                foreach (string l in desconocidos)
                {
                    LoguearError("Legajo: " + l);
                }
            }
            LoguearInforme("--Rutina de descarga de registros finalizada.");
        }

        public void RutinaSincronizacionHora()
        {
            LoguearInforme("--Inicio rutina de sincronización de hora");
            foreach (Reloj r in equipos)
            {
                try
                {
                    if (r.Rutina)
                    {
                        LoguearInforme("Conectando con '" + r.Nombre + "'...");
                        r.Conectar();
                        LoguearInforme("El dispositivo: '" + r.Nombre + "' se conectó correctamente");
                        r.SincronizarHora();
                        LoguearInforme("Se sincronizó correctamente la hora con el reloj: '" + r.Nombre + "'");
                        r.Desconectar();
                        LoguearInforme("El dispositivo: '" + r.Nombre + "' se desconectó correctamente");
                    }
                }
                catch (Exception ex)
                {
                    LoguearError("****Se produjo un error con reloj: " + r.Nombre + " durante la rutina de sincronización de hora*****");
                    LoguearError("ERROR: " + ex.Message);
                }

            }
            LoguearInforme("--Rutina de sincronización de hora finalizada");
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

        // ESTE METODO MANEJA LAS ESCRITURAS EN EL LOG PARA NO TENER CONFLICTOS CON LAS LLAMADAS ASINCRONICAS //
        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            txtLog.Text += value;
        }
        private void linkCleanLog_Click(object sender, EventArgs e)
        {
            txtLog.Text = string.Empty;
            txtLog.Refresh();
        }
    }
}
