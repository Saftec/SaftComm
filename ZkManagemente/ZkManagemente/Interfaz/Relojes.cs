using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ZkManagement.Entidades;
using ZkManagement.Logica;

namespace ZkManagement.Interfaz
{
    public partial class Relojes : Form
    {
        public Relojes()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void Open()
        {
            ControladorReloj cr = new ControladorReloj();
            List<Reloj> relojes = new List<Reloj>();
            try
            {
                relojes = cr.TodosRelojes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            // RECORRER LISTVIEW Y LLENAR EL DGV!!///

            foreach(Reloj reloj in relojes)
            {
                dgvRelojes.Rows.Add(reloj.Numero, reloj.Ip, reloj.Nombre, "0", string.Empty, "Desconectado", string.Empty);
            }
            
            Show();
        }

        private void Relojes_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {

        }
    }
}
