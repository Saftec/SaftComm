using System;
using System.Collections.Generic;
using System.Data;
using Logic;
using Util;
using Entidades;
using System.Windows.Forms;
namespace ZkManagement.NewUI
{
    public partial class PanelSincronizacion : GenericPanel
    {
        #region Singleton
        private static PanelSincronizacion _instancia;

        public static PanelSincronizacion Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new PanelSincronizacion();
                }
                return _instancia;
            }
        }
        private PanelSincronizacion() { InitializeComponent(); }
        #endregion

        private LogicEmpleado le;
        private LogicReloj lr;
        private Reloj relojAct;
        private int cantHuellas;


        #region Botones
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            if (cbRelojes.SelectedIndex < 0)
            {
                base.InformarError("Por favor seleccione un dispositivo", "Sincronizar Datos.");
            }
            // SI SE UTILIZO OTRO RELOJ LO DESCONECTO //
            if (relojAct != null && !relojAct.Estado)
            {
                relojAct.Desconectar();
            }

            try
            {
                gridPersonalReloj.AutoGenerateColumns = false;  // Para que respete las columnas ya diseñadas
                relojAct = (Reloj)cbRelojes.SelectedItem;
                relojAct.Conectar();
                gridPersonalReloj.DataSource = null;
                gridPersonalReloj.Refresh();
                gridPersonalReloj.DataSource = relojAct.DescargarInfo();
                relojAct.Desconectar();
                gridPersonalReloj.Refresh();
                lblDispositivo.Text = "Usuarios en dispositivo: " + relojAct.Nombre;
            }
            catch (AppException appex)
            {
                base.InformarError(appex.Message, "Sincronizar Datos.");
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            List<string> legajos = new List<string>();
            try
            {
                foreach (DataGridViewRow fila in gridPersonalReloj.Rows)
                {
                    DataGridViewCheckBoxCell cellSeleccion = fila.Cells["SeleccionDisp"] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(cellSeleccion.Value))
                    {
                        legajos.Add(fila.Cells["LegajoDisp"].Value.ToString());
                    }
                }
                //Valido que haya seleccionado al menos 1
                if (legajos.Count == 0)
                {
                    base.InformarError("Debe seleccionar al menos un empleado.", "Eliminar Usuarios.");
                    return;
                }
                //Pregunto si realmente quiere hacer la acción
                if (MessageBox.Show("Esta seguro que desea eliminar los empleados seleccionados?", "Eliminar Usuarios.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                { return; }

                if (relojAct != null && !relojAct.Estado)
                {
                    relojAct.Desconectar();
                }

                relojAct = (Reloj)cbRelojes.SelectedItem;
                relojAct.Conectar();
                relojAct.EliminarUsuarios(legajos);
                relojAct.Desconectar();
                base.Informar(legajos.Count.ToString() + " usuarios eliminados correctamente", "Eliminar Usuarios.");
            }
            catch (AppException appex)
            {
                InformarError(appex.Message, "Eliminar Usuarios.");
            }
            catch (Exception ex)
            {
                InformarError(ex.Message, "Eliminar Usuarios.");
            }
        }
        private void btnDownloadInfo_Click(object sender, EventArgs e)
        {
            if (relojAct != null && !relojAct.Estado)
            {
                relojAct.Desconectar();
            }
            try
            {
                relojAct = (Reloj)cbRelojes.SelectedItem;
                backgroundDownloadInfo.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                base.InformarError(ex.Message, "Descargar Usuarios.");
            }
        }
        private void btnUploadInfo_Click(object sender, EventArgs e)
        {
            if (relojAct != null && !relojAct.Estado)
            {
                relojAct.Desconectar();
            }
            try
            {
                relojAct = (Reloj)cbRelojes.SelectedItem;
                backgroundUploadInfo.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                base.InformarError(ex.Message, "Cargar Usuarios.");
            }

        }
        #endregion

        #region BackGround's
        //////////////////// DESCARGA ////////////////////////////////////
        private void backgroundDownloadInfo_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {           
            List<Empleado> empleados = new List<Empleado>();
            LogicDescargaDatos ldd = new LogicDescargaDatos();
            try
            {
                backgroundDownloadInfo.ReportProgress(0);
                foreach (DataGridViewRow fila in gridPersonalReloj.Rows)
                {
                    DataGridViewCheckBoxCell cellSeleccion = fila.Cells["SeleccionDisp"] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(cellSeleccion.Value))
                    {
                        Empleado emp = new Empleado();
                        emp.Legajo = fila.Cells["LegajoDisp"].Value.ToString();
                        emp.Nombre = fila.Cells["NombreDisp"].Value.ToString();
                        emp.Pin = fila.Cells["PinDisp"].Value.ToString();
                        emp.Tarjeta = fila.Cells["TarjetaDisp"].Value.ToString();
                        empleados.Add(emp);
                    }
                }
                if (empleados.Count <= 0)
                {
                    base.InformarError("No seleccionó ningún empleado", "Descargar Usuarios.");
                    return;
                }
                int total = 0;
                cantHuellas = 0;
                relojAct.Conectar();
                relojAct.Deshabilitar();
                foreach (Empleado emp in empleados)
                {
                    if (relojAct.Estado)
                    {
                        ldd.ActualizarInfo(emp);  //Descargo la info del usuario
                        cantHuellas += ldd.AgregarHuella(emp, relojAct); //Descargo las huellas
                        total++;
                        backgroundDownloadInfo.ReportProgress((total * 100) / empleados.Count);
                    }
                }
                backgroundDownloadInfo.ReportProgress(100);
            }
            catch (Exception ex)
            {
                base.InformarError(ex.Message, "Descargar Usuarios.");
            }
            finally
            {
                relojAct.ActivarDispositivo();
                relojAct.Desconectar();
            }
        }
        private void backgroundDownloadInfo_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }
        private void backgroundDownloadInfo_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            base.Informar("Descarga de datos finalizada, se descargaron: " + cantHuellas.ToString() + " huellas.", "Descarga de Usuarios");
            progressBar.Value = 100;
        }
        //////////////////////////////////////////////////////////////


        private void backgroundUploadInfo_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            List<Empleado> empleados = new List<Empleado>();
            LogicCargaDatos lcd = new LogicCargaDatos();
            backgroundUploadInfo.ReportProgress(0);
            try
            {
                foreach (DataGridViewRow fila in gridPersonalLocal.Rows)
                {
                    DataGridViewCheckBoxCell cellSeleccion = fila.Cells["Seleccion"] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(cellSeleccion.Value))
                    {
                        Empleado emp = new Empleado();
                        emp.Legajo = fila.Cells["Legajo"].Value.ToString();
                        emp.Nombre = fila.Cells["Nombre"].Value.ToString();
                        emp.Pin = fila.Cells["Pin"].Value.ToString();
                        emp.Tarjeta = fila.Cells["Tarjeta"].Value.ToString();
                        emp.Privilegio = Convert.ToInt32(fila.Cells["Privilegio"].Value);
                        emp.Id = Convert.ToInt32(fila.Cells["Id"].Value);
                        empleados.Add(emp);
                    }
                    if (empleados.Count == 0)
                    {
                        base.InformarError("Por favor, seleccione al menos 1 empleado", "Cargar Información");
                        return;
                    }
                    int total = 0;
                    relojAct.Conectar();
                    foreach(Empleado emp in empleados)
                    {
                        lcd.CargarDatos(emp, relojAct);
                        backgroundUploadInfo.ReportProgress((total * 100) / empleados.Count);
                        total++;
                    }
                    backgroundUploadInfo.ReportProgress(100);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                relojAct.ActivarDispositivo();
                relojAct.Desconectar();
            }
        }
        private void backgroundUploadInfo_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }
        #endregion

        public void RefreshData()
        {
            DataTable empleados = new DataTable();
            gridPersonalLocal.DataSource = null;
            gridPersonalLocal.AutoGenerateColumns = false;
            le = new LogicEmpleado();
            lr = new LogicReloj();
            try
            {
                empleados = ConvertToDatatable(le.GetEmpleados());
                gridPersonalLocal.DataSource = empleados;
                gridPersonalLocal.Refresh();
                cbRelojes.DataSource = lr.GetAll();
                gridPersonalReloj.DataSource = null;
                gridPersonalReloj.Refresh();
                lblDispositivo.Text = "Usuarios en dispositivo: ";
            }
            catch (Exception ex)
            {
                base.InformarError(ex.Message, "Consultar Empleados");
            }
        }

        private DataTable ConvertToDatatable(List<Empleado> listEmps)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Legajo");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("IdEmpleado");
            dt.Columns.Add("Tarjeta");
            dt.Columns.Add("Pin");
            dt.Columns.Add("Privilegio");
            dt.Columns.Add("Baja");
            dt.Columns.Add("Cant");
            foreach (Empleado e in listEmps)
            {
                DataRow row = dt.NewRow();
                row["Nombre"] = e.Nombre;
                row["Legajo"] = e.Legajo.Trim();
                row["IdEmpleado"] = e.Id;
                row["Tarjeta"] = e.Tarjeta.Trim();
                row["Pin"] = e.Pin;
                row["Privilegio"] = e.Privilegio;
                row["Baja"] = e.Baja;
                row["Cant"] = e.CantHuellas;
                dt.Rows.Add(row);
            }
            return dt;
        }
    }
}
