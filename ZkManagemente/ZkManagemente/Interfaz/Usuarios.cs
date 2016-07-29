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
                    dgvUsuarios.Rows.Add(usuario.Usr, usuario.Pass, usuario.Nivel, usuario.Permisos,usuario.Id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }

        #region DataGridView
        private string GetUsr()
        {
            return (dgvUsuarios.CurrentRow.Cells[0].Value).ToString();
        }

        private string GetPsw()
        {
            return (dgvUsuarios.CurrentRow.Cells[1].Value).ToString();
        }

        private int GetNivel()
        {
            return Convert.ToInt32((dgvUsuarios.CurrentRow.Cells[2].Value));
        }
        private int GetId()
        {
            return Convert.ToInt32((dgvUsuarios.CurrentRow.Cells[3].Value));
        }

        #endregion

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AbmUsuarios abm = new AbmUsuarios();
            abm.ShowDialog(this);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(GetUsr(),GetPsw(),GetNivel(),GetId());
            AbmUsuarios abm = new AbmUsuarios();
            abm.Editar(usuario); //Siempre cargar los datos antes de llamar al ShowDialog();
            abm.ShowDialog(this);
        }
    }
}
