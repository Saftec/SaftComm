using System;
using System.Windows.Forms;
using ZkManagement.Entidades;
using ZkManagement.Logica;

namespace ZkManagement.Interfaz
{
    public partial class AbmReloj : Form
    {
        private int id;
        public AbmReloj()
        {
            InitializeComponent();
        }

        public void Editar(Reloj r)
        {
            txtNombre.Text = r.Nombre;
            txtNro.Text = r.Numero.ToString();
            txtIp.Text = r.Ip;
            txtPuerto.Text = r.Puerto.ToString();
            txtPsw.Text = r.Clave;
            txtDns.Text = r.DNS;
            id = r.Id;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ControladorReloj cr = new ControladorReloj();
            Reloj r = new Reloj(Convert.ToInt32(txtPuerto.Text), Convert.ToInt32(txtNro.Text), id, txtPsw.Text, txtDns.Text, txtIp.Text, txtNombre.Text);            
            try
            {
                cr.ModifReloj(r);
                MessageBox.Show("Cambios guardados");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            Cursor = Cursors.Default;
        }
    }
}
