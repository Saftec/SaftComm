using System;
using System.Data;
using System.Windows.Forms;
using ZkManagement.Entidades;
using ZkManagement.Logica;
using ZkManagement.Util;

namespace ZkManagement.Interfaz
{
    public partial class Usuarios : GenericaPadre
    {
        Usuario usuario = new Usuario();
        ControladorABMUsuarios abm;
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
            if (dgvUsuarios.CurrentRow != null)
            {
                txtUsuario.Text = dgvUsuarios.CurrentRow.Cells["Usr"].Value.ToString();
                txtContraseña.Text = Encrypt.DesEncriptar((dgvUsuarios.CurrentRow.Cells["Password"].Value.ToString()));
                comboPermisos.SelectedIndex = ((Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["IdPermisos"].Value)) - 1);
            }
        }

        private bool ValidarDatos()
        {
            Validate validate = new Validate();
            string[] notNull = { txtContraseña.Text, txtUsuario.Text };
            if (!validate.IsEmpty(notNull) || comboPermisos.SelectedIndex==-1)
            {
                return false;
            }
            else
            {
                return true;
            }            
        }
        #endregion

        #region botones
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                base.InformarError("Por favor complete todos los datos.");
                return;
            }
            abm = new ControladorABMUsuarios();
            usuario.Nivel = comboPermisos.SelectedIndex + 1;
            usuario.Pass = Encrypt.Encriptar(txtContraseña.Text);
            usuario.Usr = txtUsuario.Text;
            try
            {
                if (usuario.Id > 0)
                {
                    try
                    {
                        abm.ModificarUsuario(usuario);
                    }
                    catch(Exception ex)
                    {
                        base.InformarError(ex.Message);
                    }
                }   else
                {
                    try
                    {
                        abm.AgregarUsuario(usuario);
                    }
                    catch(Exception ex)
                    {
                        base.InformarError(ex.Message);
                    }
                }
                LimpiarTextBox();
                NoEditable();
                CargarDGV();
                base.InformarEvento("Modificacion OK", "Modificar usuarios");
            }
            catch(Exception ex)
            {
                base.InformarError(ex.Message);
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
            if (!base.ConsultarUsuario("Esta seguro que desea eliminar el usuario seleccionado?", "Modificar usuarios"))
            {
                return;
            }
            abm = new ControladorABMUsuarios();
            try
            {
                Usuario usr = new Usuario();
                usr.Id = GetId();
                abm.EliminarUsuario(usr);
                dgvUsuarios.Rows.RemoveAt(dgvUsuarios.CurrentRow.Index);
                base.InformarEvento("Usuario eliminado correctamente.", "Baja");
            }
            catch (Exception ex)
            {
                InformarError(ex.Message);
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
            abm = new ControladorABMUsuarios();
            dgvUsuarios.AutoGenerateColumns = false;
            usuarios.Clear();
            dgvUsuarios.DataSource = usuarios;
            try
            {
               // usuarios = abm.GetUsuarios();
                dgvUsuarios.DataSource = usuarios;
                dgvUsuarios.Refresh();
            }
            catch (Exception ex)
            {
                InformarError(ex.Message);
            }
        }
        #endregion

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NoEditable();
            ActualizarFormulario();            
        }
    }
}
