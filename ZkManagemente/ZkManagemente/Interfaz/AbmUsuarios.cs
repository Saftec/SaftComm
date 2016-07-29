using System;
using System.Windows.Forms;
using ZkManagement.Entidades;
using ZkManagement.Logica;

namespace ZkManagement.Interfaz
{
    public partial class AbmUsuarios : Form
    {
        public AbmUsuarios()
        {
            InitializeComponent();
            LlenarCombo();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Editar(Usuario usuario)
        {
            txtUsuario.Text = usuario.Usr;
            txtContraseña.Text = usuario.Pass;
            comboPermisos.SelectedIndex = usuario.Nivel - 1;
        }

        private void LlenarCombo()
        {
            comboPermisos.Items.Add("1 - Administrador");
            comboPermisos.Items.Add("2 - Supervisor");
            comboPermisos.Items.Add("3 - Operador");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos()) { return; }

            Usuario usuario = new Usuario(txtUsuario.Text, txtContraseña.Text, comboPermisos.SelectedIndex + 1, 0);
            ControladorLogin cl = new ControladorLogin();
            try
            {
                cl.AgregarUsuario(usuario);
                MessageBox.Show("Usuario cargado correctamente","Usuarios");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private bool ValidarDatos()
        {
            if (comboPermisos.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un nivel de permisos", "Error");
                return false;
            }

            if (txtContraseña.Text == string.Empty || txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("Por favor complete todos los campos", "Error");
                return false;
            }
            return true;
        }
    }
}
