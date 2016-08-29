using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using ZkManagement.Entidades;
using ZkManagement.Logica;

namespace ZkManagement.Interfaz
{
    public partial class Empleados : GenericaPadre
    {
        private Empleado empleado = new Empleado();
        private ControladorEmpleados ce;
        private DataTable empleados = new DataTable();
        public Empleados()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            DatosDGV();
        }

        #region Formulario
        private void ActualizarFormulario()
        {
            try
            {
                txtNombre.Text = dgvEmpleados.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDNI.Text = dgvEmpleados.CurrentRow.Cells["DNI"].Value.ToString();
                txtLegajo.Text = dgvEmpleados.CurrentRow.Cells["Legajo"].Value.ToString();
                txtTarjeta.Text = dgvEmpleados.CurrentRow.Cells["Tarjeta"].Value.ToString();
                txtPin.Text = dgvEmpleados.CurrentRow.Cells["Pin"].Value.ToString();
                lblNivel.Text = dgvEmpleados.CurrentRow.Cells["Privilegio"].Value.ToString();
            }
            catch (NullReferenceException)
            {
                LimpiarTextBox();
                NoEditable();
            }
        }

        private bool ValidarDatos()
        {
            if(txtLegajo.Text==string.Empty || txtNombre.Text==string.Empty) { return false; }
            else { return true; }
        }
        private void Editable()
        {
            groupEmpleados.Enabled = true;
        }

        private void NoEditable()
        {
            groupEmpleados.Enabled = false;
        }

        private void LimpiarTextBox()
        {
            txtDNI.Text = "";
            txtLegajo.Text = "";
            txtNombre.Text = "";
            txtPin.Text = "";
            txtTarjeta.Text = "";
        }
        #endregion

        #region Botones
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!(base.ConsultarUsuario("Desea eliminar por completo el/los empleado/s seleccionado/s?", "Eliminar")))
            { return; }

            // Recorro todo el DGV y elimino todos los seleccionados//
            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dgvEmpleados.Rows)
            {
                DataGridViewCheckBoxCell cellSelecion = row.Cells["Eliminar"] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(cellSelecion.Value))
                {
                    try
                    {
                        Empleado emp = new Empleado();
                        emp.Id = Convert.ToInt32(row.Cells["EmpId"].Value);
                        ce = new ControladorEmpleados();
                        ce.BajaEmpleado(emp);
                        filas.Add(row);
                    }
                    catch (Exception ex)
                    {
                        base.InformarError(ex.Message);
                    }
                }
            }
            if (filas.Count==0) { base.InformarError("Por favor, seleccione al menos 1 empleado"); }
            //Borro las filas del DGV
            foreach (DataGridViewRow row in filas)
            {
                dgvEmpleados.Rows.Remove(row);
            }
            filas.Clear(); //Limpio el arregle de filas guardado en memoria.
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            empleado.Id = 0;
            LimpiarTextBox();
            Editable();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            empleado.Id = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["EmpId"].Value);
            Editable();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
            NoEditable();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                base.InformarError("El legajo y el nombre no pueden ser nulos");
                return;
            }
            Cursor = Cursors.WaitCursor;
            empleado.Dni = txtDNI.Text;
            empleado.Legajo = txtLegajo.Text;
            empleado.Nombre = txtNombre.Text;
            if (txtPin.Text != null) { empleado.Pin = txtPin.Text; }
            empleado.Tarjeta = txtTarjeta.Text;
            empleado.Privilegio = Convert.ToInt32(lblNivel.Text);
            try
            {
                ce = new ControladorEmpleados();
                ce.ActualizarEmpleado(empleado);
                DatosDGV();              
                LimpiarTextBox();
                NoEditable();
                base.InformarEvento("Empleado actualizado correctamente", "Modificar usuarios");
            }
            catch (Exception ex)
            {
                base.InformarError(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        #endregion

        #region DataGridView
        private void DatosDGV()
        {
            dgvEmpleados.DataSource = null;
            dgvEmpleados.Refresh();      
            try
            {
                ce = new ControladorEmpleados();
                empleados = ce.GetEmpleados();
                dgvEmpleados.DataSource = empleados;
                dgvEmpleados.Refresh();
            }
            catch (Exception ex)
            {
                base.InformarError(ex.Message);
            }

        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Como el datagridview tiene la propieda ReadOnly activada, no me permite seleccionar el checkbox.
            // Necesito si o si manejarlo por código en el este evento.
            if (e.RowIndex == -1)
                return;

            if (dgvEmpleados.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                DataGridViewRow row = dgvEmpleados.Rows[e.RowIndex];

                DataGridViewCheckBoxCell cellSeleccion = row.Cells["Eliminar"] as DataGridViewCheckBoxCell;

                //Verifico si está tildad
                if (Convert.ToBoolean(cellSeleccion.Value))
                {
                    cellSeleccion.Value = false;
                }
                else
                {
                    cellSeleccion.Value = true;
                }
            }
        }

        //Cada vez que selecciona una fila pongo en no editable el formulario
        //Porque si hace click en editar y selecciona otra fila queda el formulario abierto!
        private void dgvEmpleados_SelectionChanged_1(object sender, EventArgs e)
        {
            NoEditable();
            ActualizarFormulario();
        }
        #endregion

        private void linkCargar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SincronizarDispositivo sin = new SincronizarDispositivo();
            sin.Show();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //Problema con los valores int!
            try
            {
                string fieldName = string.Concat("[", empleados.Columns[1].ColumnName, "]");
                empleados.DefaultView.Sort = fieldName;
                DataView view = empleados.DefaultView;
                view.RowFilter = string.Empty;
                if (txtBuscar.Text != string.Empty)
                    view.RowFilter = fieldName + " LIKE '%" + txtBuscar.Text + "%'";
                dgvEmpleados.DataSource = view;
            }
            catch(Exception ex)
            {
                base.InformarError(ex.Message);
            }
        }

        private void dgvEmpleados_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //CODIGO PARA ORDENAR DGV CUANDO SE HACE CLICK EN LA CABECERA
            DataGridViewColumn newColumn = dgvEmpleados.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = dgvEmpleados.SortedColumn;
            ListSortDirection direction;

            // Si la columno es = null el dgv no se ordena.
            if (oldColumn != null)
            {
                if (oldColumn == newColumn &&
                    dgvEmpleados.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            // Ordeno la columna saleccionada
            dgvEmpleados.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ? SortOrder.Ascending : SortOrder.Descending;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SincronizarDispositivo sin = new SincronizarDispositivo();
            sin.Show();
            //DatosDGV();
        }

        private void chckTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chckTodos.Checked == true)
            {
                foreach (DataGridViewRow fila in dgvEmpleados.Rows)
                {
                    DataGridViewCheckBoxCell cellSeleccion = fila.Cells["Eliminar"] as DataGridViewCheckBoxCell;
                    cellSeleccion.Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow fila in dgvEmpleados.Rows)
                {
                    DataGridViewCheckBoxCell cellSeleccion = fila.Cells["Eliminar"] as DataGridViewCheckBoxCell;
                    cellSeleccion.Value = false;
                }
            }
        }
    }
}
