using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
                InformarError(ex.Message);
            }
            foreach(Reloj r in relojes)
            {
                comboRelojes.Items.Add(r.Numero + " " + r.Nombre);
            }
            
        }
        #region DataGridView
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
            //IDEM ANTERIOR//
        private void dgvDispositivo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (dgvDispositivo.Columns[e.ColumnIndex].Name == "Seleccion")
            {
                DataGridViewRow row = dgvDispositivo.Rows[e.RowIndex];

                DataGridViewCheckBoxCell cellSeleccion = row.Cells["Seleccion"] as DataGridViewCheckBoxCell;

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
        private void LlenarDgvDispositivo()
        {
            dgvDispositivo.AutoGenerateColumns = false;
            dgvDispositivo.DataSource = usuariosEnDisp;
            dgvDispositivo.Refresh();
        }
                //Métodos para tildar todas las celdas con el checkbox//
        private void checkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTodos.Checked == true)
            {
                foreach (DataGridViewRow fila in dgvDispositivo.Rows)
                {
                    DataGridViewCheckBoxCell cellSeleccion = fila.Cells["Seleccion"] as DataGridViewCheckBoxCell;
                    cellSeleccion.Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow fila in dgvDispositivo.Rows)
                {
                    DataGridViewCheckBoxCell cellSeleccion = fila.Cells["Seleccion"] as DataGridViewCheckBoxCell;
                    cellSeleccion.Value = false;
                }
            }
        }

        private void checkTodosLocal_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTodosLocal.Checked == true)
            {
                foreach (DataGridViewRow fila in dgvLocal.Rows)
                {
                    DataGridViewCheckBoxCell cellSeleccion = fila.Cells["Seleccion"] as DataGridViewCheckBoxCell;
                    cellSeleccion.Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow fila in dgvLocal.Rows)
                {
                    DataGridViewCheckBoxCell cellSeleccion = fila.Cells["Seleccion"] as DataGridViewCheckBoxCell;
                    cellSeleccion.Value = false;
                }
            }
        }


        #endregion
        #region Botones
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (comboRelojes.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un dispositivo", "Error");
                return;
            }
            Cursor = Cursors.WaitCursor;
            reloj = relojes[comboRelojes.SelectedIndex];
            reloj.Estado = true;
            try
            {
                reloj.Conectar();
                labelEstado.Text = "Conectado a dispostivo :" + reloj.Nombre;
                usuariosEnDisp = reloj.DescargarInfo();
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
        private void btnCargar_Click(object sender, EventArgs e)
        {

        }
        private void btnDescargar_Click(object sender, EventArgs e)
        {
            if (!reloj.Estado)
            {
                MessageBox.Show("Por favor conecte con dispositivo", "Error");
                return;
            }
            try
            {
                rtbxLog.AppendText(DateTime.Now.ToString("dd/MM/yyyy hh:mm") + "--" + "Iniciando descarga \n");
                backgroundWorkerSincronizacion.RunWorkerAsync();
                rtbxLog.AppendText(DateTime.Now.ToString("dd/MM/yyyy hh:mm") + "--" + "Finalizacion de descarga exitosa \n");
                InformarUsuario("Descarga de datos exitosa", "Sincronizacion de datos");
            }
            catch (Exception ex)
            {
                rtbxLog.AppendText(DateTime.Now.ToString("dd/MM/yyyy hh:mm") + "--" + "Se produjo un error durante la descarga \n");
                InformarError(ex.Message);
            }

        }
        #endregion
        #region Interfaz
        private void InformarUsuario(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void InformarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /* private bool ValidarSeleccion()
 {

 }*/
        #endregion
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
                InformarError(ex.Message);
            }
        }
        private void SincronizarDispositivo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (reloj.Estado) //Lo desconecto sino cuando vuelvo a abrir el form se traba.
            {
                reloj.Desconectar();
            }
        }
        private void backgroundWorkerSincronizacion_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            /**************************************************** 
             Tengo que descargar la info de usuario (sin huellas) y comparar a través del legajo.
             Si existe-->Actualizo los datos.
             Si es nuevo-->Agrego el empleado.
             Bajar las huellas:
             Descargar huellas de los legajos seleccionados.
             Validar que no supere las 10 huellas (no me importa el fingerindex).
             Guardar las huellas en la BD.
            *****************************************************/
            ControladorSincronizacion cs = new ControladorSincronizacion();
            List<string> legajos = new List<string>();
            DataTable legajosYHuellas = new DataTable();

            foreach (DataGridViewRow fila in dgvDispositivo.Rows)
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
                        cs.DescargarInfo(emp);
                        legajos.Add(emp.Legajo);
                    }
                    catch(SqlException sqlex)
                    {
                        throw sqlex;
                    }
                    catch (Exception)
                    {
                        throw new Exception("Error desconocido durante la descarga de datos");
                    }
                }
            }
        //Acá termino de descargar y guardar la info de usuario guardada en el reloj
        //Y comienzo la descarga de huellas!
            try
            {
                legajosYHuellas = reloj.DescargarHuella(legajos);
                foreach (DataRow row in legajosYHuellas.Rows)
                {
                    cs.Agregarhuella(row["Legajo"].ToString(), row["Huella"].ToString());
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void backgroundWorkerSincronizacion_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            InformarUsuario("Porcentaje:" + e.ProgressPercentage.ToString(), "Prueba");
           // progressBar1.Value = e.ProgressPercentage;    //Desde acá puedo manejar el progreso de una ProgressBar!!
            DateTime time = Convert.ToDateTime(e.UserState);
            rtbxLog.AppendText(time.ToLongTimeString());
            rtbxLog.AppendText(Environment.NewLine);

        }
    }
}
