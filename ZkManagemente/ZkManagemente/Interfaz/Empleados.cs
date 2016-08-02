using System;
using System.Data;
using System.Windows.Forms;
using ZkManagement.Logica;

namespace ZkManagement.Interfaz
{
    public partial class Empleados : Form
    {
        DataTable empleados = new DataTable();
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

        private void DatosDGV()
        {
            ControladorEmpleados ce = new ControladorEmpleados();
            try
            {
                empleados = ce.GetEmpleados();
                dgvEmpleados.DataSource = empleados;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }
    }
}
