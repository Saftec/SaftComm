using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ZkManagement.Entidades;
using ZkManagement.Logica;

namespace ZkManagement.NewUI.Generic
{
    public partial class PanelPersonal : GenericPanel
    {
        private LogicEmpleado le;
        private DataTable empleados = new DataTable();
        private static PanelPersonal _instancia;

        public static PanelPersonal Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new PanelPersonal();
                }
                return _instancia;
            }
        }
        public PanelPersonal()
        {
            InitializeComponent();
        }

        #region ABM
        private void linkNuevo_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();
            emp.Id = 0;
            EditEmpleado ee = new EditEmpleado();
            ee.MapearAForm(emp);
            ee.Show();
        }

        private void linkEdit_Click(object sender, EventArgs e)
        {
            Empleado emp = MapearDeGrid();
            EditEmpleado ee = new EditEmpleado();
            ee.MapearAForm(emp);
            ee.Show();
        }

        private void linkDelete_Click(object sender, EventArgs e)
        {
            if (!base.Question("Está seguro que desea eliminar el/los empleados seleccionados?", "Eliminar Empleados."))
            {
                return;
            }
            // Recorro todo el grid y elimino todos los seleccionados//
            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            LogicEmpleado le = new LogicEmpleado();
            List<Empleado> eliminados = new List<Empleado>();

            try
            {
                foreach (DataGridViewRow row in gridPersonal.Rows)
                {
                    DataGridViewCheckBoxCell cellSelecion = row.Cells["Eliminar"] as DataGridViewCheckBoxCell;

                    if (Convert.ToBoolean(cellSelecion.Value))
                    {
                        Empleado emp = new Empleado();
                        emp.Id = Convert.ToInt32(row.Cells["Id"].Value);
                        eliminados.Add(emp);
                        filas.Add(row);
                    }
                }
                le = new LogicEmpleado();
                le.BajaEmpleado(eliminados);
                //Borro las filas del DGV
                foreach (DataGridViewRow row in filas)
                {
                    gridPersonal.Rows.Remove(row);
                }
                filas.Clear(); //Limpio el arregle de filas guardado en memoria.
                base.Informar(eliminados.Count.ToString() + " empleados eliminados correctamente.", "Eliminar Empleados");
            }
            catch (Exception ex)
            {
                base.InformarError(ex.Message, "Eliminar Empleados.");
            }

        }
        #endregion

        #region Grid
        private Empleado MapearDeGrid()
        {
            Empleado e = new Empleado();
            int val = 0;
            if (int.TryParse(gridPersonal.CurrentRow.Cells["Id"].Value.ToString(), out val))
            {
                e.Id = val;
            }
            if (int.TryParse(gridPersonal.CurrentRow.Cells["Privilegio"].Value.ToString(), out val))
            {
                e.Privilegio = val;
            }
            e.Nombre = gridPersonal.CurrentRow.Cells["Nombre"].Value.ToString();
            e.Legajo = gridPersonal.CurrentRow.Cells["Legajo"].Value.ToString();
            e.Pin = gridPersonal.CurrentRow.Cells["Pin"].Value.ToString();
            e.Tarjeta = gridPersonal.CurrentRow.Cells["Tarjeta"].Value.ToString();

            return e;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)gridPersonal.DataSource).DefaultView.RowFilter = string.Format("Nombre like '%{0}%' OR DNI like '%{0}%' OR Legajo like '%{0}%'", txtBuscar.Text.Trim().Replace("'", "''"));
            }
            catch (Exception ex)
            {
                base.InformarError(ex.Message, "Buscar Empleados.");
            }
        }
        public void RefreshGrid()
        {
            gridPersonal.DataSource = null;
            gridPersonal.AutoGenerateColumns = false;
            le = new LogicEmpleado();
            try
            {
                empleados = ConvertToDatatable(le.GetEmpleados());
                gridPersonal.DataSource = empleados;
                gridPersonal.Refresh();
            }
            catch (Exception ex)
            {
                base.InformarError(ex.Message, "Consultar Empleados");
            }
        }
        #endregion

        private DataTable ConvertToDatatable(List<Empleado> listEmps)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Legajo");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("IdEmpleado");
            dt.Columns.Add("Tarjeta");
            dt.Columns.Add("DNI");
            dt.Columns.Add("Pin");
            dt.Columns.Add("Privilegio");
            dt.Columns.Add("Baja");
            dt.Columns.Add("Cant");
            foreach (Empleado e in listEmps)
            {
                DataRow row = dt.NewRow();
                row["Nombre"] = e.Nombre;
                row["Legajo"] = e.Legajo;
                row["IdEmpleado"] = e.Id;
                row["Tarjeta"] = e.Tarjeta;
                row["DNI"] = e.Dni;
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