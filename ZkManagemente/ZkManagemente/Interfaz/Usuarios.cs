using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ZkManagement.Entidades;
using ZkManagement.Logica;

namespace ZkManagement.Interfaz
{
    public partial class Usuarios : GenericaPadre
    {
        Usuario usuario = new Usuario();
        public Usuarios()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            LlenarCombo();
            CargarDGV();            
        }

        //Devuelve el ID de la celda seleccionada
        private int GetId()
        {
            return Convert.ToInt32((dgvUsuarios.CurrentRow.Cells[4].Value));
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {           
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            NoEditable();
            ActualizarFormulario();
        }

        #region formulario
        private void Editable()
        {
            txtUsuario.Enabled = true;
            txtContraseña.Enabled = true;
            comboPermisos.Enabled = true;
        }

        private void LimpiarTextBox()
        {
            txtUsuario.Text = string.Empty;
            txtContraseña.Text = string.Empty;
            comboPermisos.SelectedIndex = -1;
        }

        private void NoEditable()
        {
            LimpiarTextBox();
            txtUsuario.Enabled = false;
            txtContraseña.Enabled = false;
            comboPermisos.Enabled = false;
        }

        private void ActualizarFormulario()
        {
            txtUsuario.Text = dgvUsuarios.CurrentRow.Cells["Usr"].Value.ToString();
            txtContraseña.Text = dgvUsuarios.CurrentRow.Cells["Password"].Value.ToString();
            comboPermisos.SelectedIndex = ((Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["IdPermisos"].Value)) - 1);
        }

        private bool ValidarDatos()
        {
            if (txtContraseña.Text == string.Empty || txtUsuario.Text == string.Empty || comboPermisos.SelectedIndex == -1) { return false; }
            else { return true; }
        }
        #endregion

        #region botones
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                MessageBox.Show("Por favor complete todos los datos.", "Error");
                return;
            }
            ControladorLogin cl = new ControladorLogin();
            usuario.Nivel = comboPermisos.SelectedIndex + 1;
            usuario.Pass = txtContraseña.Text;
            usuario.Usr = txtUsuario.Text;
            try
            {
                cl.ModificarUsuario(usuario);
                LimpiarTextBox();
                NoEditable();
                CargarDGV();
                MessageBox.Show("Modificacion OK");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        //BOTON "Nuevo"
        private void button1_Click(object sender, EventArgs e)
        {
            usuario.Id = 0;
            LimpiarTextBox();
            Editable();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            NoEditable();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            usuario.Id = GetId();
            Editable();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar el usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            ControladorLogin cl = new ControladorLogin();
            try
            {
                Usuario usr = new Usuario();
                usr.Id = GetId();
                cl.EliminarUsuario(usr);
                dgvUsuarios.Rows.RemoveAt(dgvUsuarios.CurrentRow.Index);
                MessageBox.Show("Usuario eliminado correctamente.", "Baja");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        #endregion

        #region incializacion
        private void LlenarCombo()
        {
            comboPermisos.Items.Add("1 - Administrador");
            comboPermisos.Items.Add("2 - Supervisor");
            comboPermisos.Items.Add("3 - Operador");
        }

        private void CargarDGV()
        {
            DataTable usuarios = new DataTable();
            ControladorLogin cl = new ControladorLogin();
            dgvUsuarios.AutoGenerateColumns = false;
            dgvUsuarios.Rows.Clear();
            try
            {
                usuarios = cl.GetUsuarios();
                dgvUsuarios.DataSource = usuarios;
                dgvUsuarios.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        #endregion

    }
}
