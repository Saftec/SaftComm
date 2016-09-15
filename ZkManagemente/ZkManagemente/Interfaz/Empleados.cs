using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ZkManagement.Entidades;
using ZkManagement.Logica;
using ZkManagement.Util;

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
            groupBox1.Visible = false;
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
            if(dgvEmpleados.CurrentRow != null)
            {
                txtNombre.Text = dgvEmpleados.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDNI.Text = dgvEmpleados.CurrentRow.Cells["DNI"].Value.ToString();
                txtLegajo.Text = dgvEmpleados.CurrentRow.Cells["Legajo"].Value.ToString();
                txtTarjeta.Text = dgvEmpleados.CurrentRow.Cells["Tarjeta"].Value.ToString();
                txtPin.Text = dgvEmpleados.CurrentRow.Cells["Pin"].Value.ToString();
                lblNivel.Text = dgvEmpleados.CurrentRow.Cells["Privilegio"].Value.ToString();
                if ((Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["Baja"].Value)==1)) { chckBaja.Checked = true; }
                else { chckBaja.Checked = false; }
            }
        }

        private bool ValidarDatos()
        {
            Validate validate = new Validate();
            string[] notNulls = { txtLegajo.Text, txtNombre.Text };
            if(!validate.IsEmpty(notNulls)) { return false; }
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
        //Botón de sincronización con dispositivo
        private void button1_Click(object sender, EventArgs e)
        {
            SincronizarDispositivo sin = new SincronizarDispositivo();
            sin.Show();
        }
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
            empleado.Baja = 0;
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
            if (txtPin.Text == string.Empty) { empleado.Pin = "NULL"; }
            else { empleado.Pin = txtPin.Text; }            
            empleado.Tarjeta = txtTarjeta.Text;
            empleado.Privilegio = Convert.ToInt32(lblNivel.Text);
            if (chckBaja.Checked==true) { empleado.Baja = 1; }
            else { empleado.Baja = 0; }
            try
            {
                ce = new ControladorEmpleados();
                if (empleado.Id > 0)
                {
                    ActualizarFila(empleado);
                    ce.ActualizarEmpleado(empleado);
                }
                else
                {
                    ce.AgregarEmpleado(empleado);
                    DatosDGV();
                }              
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
        private void LoadInfoEmpleados()
        {

        }
        private void DatosDGV()
        {
            ce = new ControladorEmpleados();
            try
            {
                empleados.Clear();
                empleados = ce.GetEmpleados();
                if (empleados.Rows.Count > 0)
                {
                    dgvEmpleados.DataSource = empleados;
                }
                else { throw new AppException("No hay empleados cargados"); }
            }
            catch (Exception ex)
            {
                base.InformarError(ex.Message);
            }

        }
        private void FiltrarActivos()
        {
            try
            {
                ((DataTable)dgvEmpleados.DataSource).DefaultView.RowFilter = string.Format("Baja = 0");
            }
            catch (Exception ex)
            {
                base.InformarError(ex.Message);
            }
        }
        private void ActualizarFila(Empleado emp)
        {
            dgvEmpleados.CurrentRow.Cells["Legajo"].Value = empleado.Legajo;
            dgvEmpleados.CurrentRow.Cells["Nombre"].Value = empleado.Nombre;
            dgvEmpleados.CurrentRow.Cells["Tarjeta"].Value = empleado.Tarjeta;
            dgvEmpleados.CurrentRow.Cells["DNI"].Value = empleado.Dni;
            if (empleado.Pin == "NULL") { dgvEmpleados.CurrentRow.Cells["Pin"].Value = string.Empty; }
            else { dgvEmpleados.CurrentRow.Cells["Pin"].Value = empleado.Pin; }                       
            dgvEmpleados.CurrentRow.Cells["Privilegio"].Value = empleado.Privilegio.ToString();
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

        //BUSQUEDA//
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //Filtro el datagridview por Nombre, DNI y Legajo//
            try
            {
                ((DataTable)dgvEmpleados.DataSource).DefaultView.RowFilter = string.Format("Nombre like '%{0}%' OR DNI like '%{0}%' OR Legajo like '%{0}%'", txtBuscar.Text.Trim().Replace("'", "''"));
            }
            catch (Exception ex)
            {
                base.InformarError(ex.Message);
            }
        }

        private void rbBajas_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dgvEmpleados.DataSource).DefaultView.RowFilter = string.Format("Baja = 1");
            }
            catch (Exception ex)
            {
                base.InformarError(ex.Message);
            }
        }

        private void rbActivos_CheckedChanged(object sender, EventArgs e)
        {
            FiltrarActivos();
        }

        private void dgvEmpleados_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (dgvEmpleados.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                DataGridViewRow row = dgvEmpleados.Rows[e.RowIndex];

                DataGridViewCheckBoxCell cellSeleccion = row.Cells["Eliminar"] as DataGridViewCheckBoxCell;

                //Verifico si está tildado
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
    }
}
