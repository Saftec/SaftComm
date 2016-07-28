using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ZkManagement.Entidades;
using ZkManagement.Logica;

namespace ZkManagement.Interfaz
{
    public partial class Usuarios : Form
    {
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
            CargarDGV();
        }
        public void CargarDGV()
        {
            List<Usuario> usuarios = new List<Usuario>();
            ControladorLogin cl = new ControladorLogin();

            dgvUsuarios.DataSource = null;
            dgvUsuarios.Rows.Clear();
            try
            {
                usuarios = cl.GetUsuarios();
                foreach (Usuario usuario in usuarios)
                {
                    dgvUsuarios.Rows.Add(usuario.Usr, usuario.Pass, usuario.Nivel, usuario.Permisos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }
    }
}
