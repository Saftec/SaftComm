using System;
using System.Collections.Generic;
using System.Data;
using ZkManagement.Logica;
using ZkManagement.Util;
using ZkManagement.Entidades;
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
                cbRelojes.DataSource = lr.TodosRelojes();
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

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            if (cbRelojes.SelectedIndex < 0)
            {
                base.InformarError("Por favor seleccione un dispositivo", "Sincronizar Datos.");
            }
            // SI SE UTILIZO OTRO RELOJ LO DESCONECTO //
            if (relojAct!=null && !relojAct.Estado)
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
            }
            catch(AppException appex)
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
                    DataGridViewCheckBoxCell cellSeleccion = fila.Cells["Eliminar"] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(cellSeleccion.Value))
                    {
                        legajos.Add(fila.Cells["Leg"].Value.ToString());
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

                if(relojAct!=null && !relojAct.Estado)
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
    }
}
