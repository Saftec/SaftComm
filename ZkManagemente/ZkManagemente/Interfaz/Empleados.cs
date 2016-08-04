using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ZkManagement.Entidades;
using ZkManagement.Logica;

namespace ZkManagement.Interfaz
{
    public partial class Empleados : Form
    {
        private Empleado empleado = new Empleado();
        private ControladorEmpleados ce = new ControladorEmpleados();
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
            txtNombre.Text = dgvEmpleados.CurrentRow.Cells["Nombre"].Value.ToString();
            txtDNI.Text = dgvEmpleados.CurrentRow.Cells["DNI"].Value.ToString();
            txtLegajo.Text = dgvEmpleados.CurrentRow.Cells["Legajo"].Value.ToString();
            txtTarjeta.Text = dgvEmpleados.CurrentRow.Cells["Tarjeta"].Value.ToString();
            txtPin.Text = dgvEmpleados.CurrentRow.Cells["Pin"].Value.ToString();
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
            Empleado emp = new Empleado();
            if (MessageBox.Show("Desea eliminar por completo el/los empleado/s seleccionado/s?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            { return; }

            // Recorro todo el DGV y elimino todos los seleccionados//
            foreach (DataGridViewRow row in dgvEmpleados.Rows)
            {
                DataGridViewCheckBoxCell cellSelecion = row.Cells["Eliminar"] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(cellSelecion.Value))
                {
                    try
                    {
                        emp.Id = Convert.ToInt32(row.Cells["EmpId"].Value);
                        ce.BajaEmpleado(emp);
                        dgvEmpleados.Rows.RemoveAt(row.Index);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
            }
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
                MessageBox.Show("El legajo y el nombre no pueden ser nulos", "Error");
                return;
            }
            empleado.Dni = txtDNI.Text;
            empleado.Legajo = txtLegajo.Text;
            empleado.Nombre = txtNombre.Text;
            if (txtPin.Text != string.Empty) { empleado.Pin = Convert.ToInt32(txtPin.Text); }
            empleado.Tarjeta = txtTarjeta.Text;

            try
            {
                ce.ActualizarEmpleado(empleado);
                MessageBox.Show("Empleado actualizado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        #endregion

        #region DataGridView
        private void DatosDGV()
        {          
            try
            {
                empleados = ce.GetEmpleados();
                dgvEmpleados.DataSource = empleados;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
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
                MessageBox.Show(ex.Message);
            }
        }
    }
}
