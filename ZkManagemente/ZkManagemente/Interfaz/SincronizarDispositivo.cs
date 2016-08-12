using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ZkManagement.Entidades;
using ZkManagement.Logica;

namespace ZkManagement.Interfaz
{
    public partial class SincronizarDispositivo : Form
    {
        private List<Reloj> relojes = new List<Reloj>();
        private DataTable usuariosEnDisp = new DataTable();
        private Reloj reloj = new Reloj();
        public SincronizarDispositivo()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SincronizarDispositivo_Load(object sender, EventArgs e)
        {
            LlenarComboBox();
            LlenarDgvLocal();
        }

        private void LlenarComboBox()
        {
            ControladorReloj cr = new ControladorReloj();           
            try
            {
                relojes = cr.TodosRelojes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            foreach(Reloj r in relojes)
            {
                comboRelojes.Items.Add(r.Numero + " " + r.Nombre);
            }
            
        }

        private void comboRelojes_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void LlenarDgvLocal()
        {
            dgvLocal.AutoGenerateColumns = false;
            ControladorEmpleados ce = new ControladorEmpleados();
            DataTable empleados = new DataTable();
            try
            {
                empleados = ce.GetEmpleados();
                dgvLocal.DataSource = empleados;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void LlenarDgvDispositivo()
        {
            dgvDispositivo.AutoGenerateColumns = false;
            dgvDispositivo.DataSource = usuariosEnDisp;
            dgvDispositivo.Refresh();
        }

        private void dgvLocal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Como el datagridview tiene la propieda ReadOnly activada, no me permite seleccionar el checkbox.
            // Necesito si o si manejarlo por código en este evento.
            if (e.RowIndex == -1)
                return;

            if (dgvLocal.Columns[e.ColumnIndex].Name == "Seleccionar")
            {
                DataGridViewRow row = dgvLocal.Rows[e.RowIndex];

                DataGridViewCheckBoxCell cellSeleccion = row.Cells["Seleccionar"] as DataGridViewCheckBoxCell;

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

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (comboRelojes.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un dispositivo", "Error");
                return;
            }
            Cursor = Cursors.WaitCursor;
            reloj=relojes[comboRelojes.SelectedIndex];
            reloj.Estado = true;
            try
            {
                reloj.Conectar();
                labelEstado.Text = "Conectado a dispostivo :" + reloj.Nombre;
                usuariosEnDisp=reloj.DescargarInfo();
                LlenarDgvDispositivo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void dgvDispositivo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (dgvDispositivo.Columns[e.ColumnIndex].Name == "Seleccion")
            {
                DataGridViewRow row = dgvDispositivo.Rows[e.RowIndex];

                DataGridViewCheckBoxCell cellSeleccion = row.Cells["Seleccion"] as DataGridViewCheckBoxCell;

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

        private void SincronizarDispositivo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (reloj.Estado)
            {
                reloj.Desconectar();
            }
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            ControladorSincronizacion cs = new ControladorSincronizacion();
            if (!reloj.Estado)
            {
                MessageBox.Show("Por favor conecte con dispositivo", "Error");
                return;
            }
            foreach(DataGridViewRow fila in dgvDispositivo.Rows)
            {
                Empleado emp = new Empleado();
                DataGridViewCheckBoxCell cellSeleccion = fila.Cells["Seleccion"] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(cellSeleccion.Value))
                {
                    try
                    {
                        emp.Legajo = fila.Cells["Leg"].Value.ToString();
                        emp.Nombre = fila.Cells["Nom"].Value.ToString();
                        emp.Pin = fila.Cells["Pin"].Value.ToString();
                        emp.Privilegio = Convert.ToInt32(fila.Cells["Privilegio"].Value);
                        emp.Huella = fila.Cells["Huella"].Value.ToString();
                        cs.DescargarInfo(emp);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
                MessageBox.Show("Descarga exitosa");
            }
        }

        private bool ValidarSeleccion()
        {

        }

        private void InformarUsuario(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void InformarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
