using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ZkManagement.Entidades;
using ZkManagement.Logica;
using ZkManagement.Util;

namespace ZkManagement.Interfaz
{
    public partial class SincronizarDispositivo : Form
    {
        private List<Reloj> relojes = new List<Reloj>();
        private DataTable usuariosEnDisp = new DataTable();
        private Reloj reloj = new Reloj();      
        private int total;
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
                    DataGridViewCheckBoxCell cellSeleccion = fila.Cells["Seleccionar"] as DataGridViewCheckBoxCell;
                    cellSeleccion.Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow fila in dgvLocal.Rows)
                {
                    DataGridViewCheckBoxCell cellSeleccion = fila.Cells["Seleccionar"] as DataGridViewCheckBoxCell;
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
            try
            {
                reloj.Conectar();
                labelEstado.Text = "Conectado a dispostivo :" + reloj.Nombre;
                reloj.Estado = true;
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
            /*INFORMACIÓN A ENVIAR AL EQUIPO:
            * Pin
            * Tarjeta
            * Privilegio
            * Nombre
            * Legajo
            * ----------------
            * Template
            * FingerIndex
            * */
            if (!reloj.Estado)
            {
                InformarError("Por favor, conecte con dispositivo");
                return;
            }

            try
            {
                LoguearInforme("Iniciando carga de datos");
                backgroundWorkerCargaDatos.RunWorkerAsync();                
            }
            catch (Exception ex)
            {
                InformarError(ex.Message);                
            }
        }
 
        private void btnDescargar_Click(object sender, EventArgs e)
        {
            if (!reloj.Estado)
            {
                InformarError("Por favor conecte con dispositivo");
                return;
            }
            try
            {
                LoguearInforme("Iniciando descarga de datos de usuarios...");
                backgroundWorkerSincronizacion.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                InformarError(ex.Message);
            }

        }
        #endregion
        #region Interfaz
        private void InformarUsuario(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoguearInforme(mensaje);
        }
        private void InformarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            LoguearError(mensaje);
        }
        private void LoguearInforme(string mensaje)
        {
            rtbxLog.SelectionColor = Color.Black;
            rtbxLog.AppendText(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss") + " " + mensaje +"\n");
        }
        private void LoguearError(string mensaje)
        {
            rtbxLog.SelectionColor = Color.Red;
            rtbxLog.AppendText(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss") + " " + mensaje + "\n");
        }

        #endregion
        private void comboRelojes_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void LlenarDgvLocal()
        {
            dgvLocal.Rows.Clear();
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

        //BACKGROUND WORKER PARA DESCARGA DE DATOS///
        private void backgroundWorkerSincronizacion_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            /**************************************************** 
             Tengo que descargar la info de usuario (sin huellas) y comparar a través del legajo.
             Si existe-->Actualizo los datos.
             Si es nuevo-->Agrego el empleado.
             Bajar las huellas:
             Descargar huellas de los legajos seleccionados.
             Para comparar las huellas necesito traer el fingerIndex cuando descargo.
                El FI no puede ser mayuor a 10.
                Si para un empid ya tengo una huella con el mismo FI-->Reemplazo.
                Sino-->Agrego.
            *****************************************************/
            
            List<string> legajos = new List<string>();
            ControladorDescargaDatos cdd = new ControladorDescargaDatos();
            //DESCARGA DE LA INFO (Sin huellas)
            try
            {                           
                foreach (DataGridViewRow fila in dgvDispositivo.Rows)
                {                  
                    DataGridViewCheckBoxCell cellSeleccion = fila.Cells["Seleccion"] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(cellSeleccion.Value))
                    {
                        Empleado emp = new Empleado();
                        emp.Legajo = fila.Cells["Leg"].Value.ToString();
                        emp.Nombre = fila.Cells["Nom"].Value.ToString();
                        emp.Pin = fila.Cells["Pin"].Value.ToString();
                        emp.Privilegio = Convert.ToInt32(fila.Cells["Privilegio"].Value);
                        emp.Tarjeta = fila.Cells["RFID"].Value.ToString();
                        cdd.DescargarInfo(emp);
                        legajos.Add(emp.Legajo);
                    }
                }
            }
            catch (Exception ex)
            {
                InformarError(ex.Message);
            }
            //HASTA ACA//

            //Comienzo la descarga de huellas!
            try
            {
                total = 0;
                total=cdd.AgregarHuella(legajos, reloj); //LA VARIABLE TOTAL ME INFORMA LA CANTIDAD DE FP DESCARGADAS.
            }
            catch(Exception ex)
            {
                InformarError(ex.Message);   
            }
        }

        //ESTE EVENTO NO SE EJECUTA
        private void backgroundWorkerSincronizacion_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            InformarUsuario("Porcentaje:" + e.ProgressPercentage.ToString(), "Prueba");
            DateTime time = Convert.ToDateTime(e.UserState);
            rtbxLog.AppendText(time.ToLongTimeString());
            rtbxLog.AppendText(Environment.NewLine);
        }

        private void backgroundWorkerSincronizacion_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            InformarUsuario("Descarga de datos exitosa", "Sincronizacion de datos");
            LoguearInforme("Se descargaron " + total.ToString() + " huellas.");
        }

        private void backgroundWorkerCargaDatos_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            List<Empleado> empleados = new List<Empleado>();
            ControladorCargaDatos ccd = new ControladorCargaDatos();
            try
            {
                foreach (DataGridViewRow fila in dgvLocal.Rows)
                {
                    DataGridViewCheckBoxCell cellSeleccion = fila.Cells["Seleccionar"] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(cellSeleccion.Value))
                    {
                        Empleado emp = new Empleado();
                        emp.Id = Convert.ToInt32(fila.Cells["Id"].Value);
                        emp.Legajo = fila.Cells["Legajo"].Value.ToString();
                        emp.Nombre = fila.Cells["Nombre"].Value.ToString();
                        emp.Pin = fila.Cells["Clave"].Value.ToString();
                        emp.Tarjeta = fila.Cells["Tarjeta"].Value.ToString();
                        emp.Privilegio = Convert.ToInt32(fila.Cells["Privilegios"].Value);
                        empleados.Add(emp);
                    }
                }
                ccd.CargarDatos(empleados, reloj);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void backgroundWorkerCargaDatos_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            InformarUsuario("Carga de datos finalizada correctamente", "Carga de datos");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        { 
            List<string> legajos = new List<string>();
            try
            {
                foreach (DataGridViewRow fila in dgvDispositivo.Rows)
                {
                    DataGridViewCheckBoxCell cellSeleccion = fila.Cells["Seleccion"] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(cellSeleccion.Value))
                    {
                        legajos.Add(fila.Cells["Leg"].Value.ToString());
                    }
                }
                //Valido que haya seleccionado al menos 1
                if (legajos.Count==0) { throw new AppException("Debe seleccionar al menos 1 usuarios a eliminar");}
                //Pregunto si realmente quiere hacer la acción
                if (MessageBox.Show("Esta seguro que desea eliminar los empleados seleccionados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                { return; }

                reloj.EliminarUsuarios(legajos);
                InformarUsuario(legajos.Count.ToString() + " usuarios eliminados correctamente", "Baja de usuarios");
            } 
            catch(Exception ex)
            {
                InformarError(ex.Message);
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (comboRelojes.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un dispositivo", "Error");
                return;
            }
            Cursor = Cursors.WaitCursor;
            reloj = relojes[comboRelojes.SelectedIndex];
            try
            {
                reloj.Conectar();
                reloj.Estado = true;
                labelEstado.Text = "Conectado a dispostivo :" + reloj.Nombre;
            }
            catch(Exception ex)
            {
                InformarError(ex.Message);
            }
        }
    }
}
