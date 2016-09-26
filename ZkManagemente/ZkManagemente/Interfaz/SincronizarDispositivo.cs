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
        private int cantHuellas;
        public SincronizarDispositivo()
        {
            InitializeComponent();
        }
        private void SincronizarDispositivo_Load(object sender, EventArgs e)
        {
            backgroundWorkerSincronizacion.WorkerReportsProgress = true;
            backgroundWorkerCargaDatos.WorkerReportsProgress = true;
            LlenarComboBox();
            LlenarDgvLocal();
        }

        private void SincronizarDispositivo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (reloj.Estado) //Lo desconecto sino cuando vuelvo a abrir el form se traba.
            {
                reloj.Desconectar();
            }
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

        private void LimpiarDgv(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.Refresh();
        }
        private void LlenarDgvLocal()
        {
            dgvLocal.DataSource = null;
            dgvLocal.Refresh();
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
            dgvDispositivo.DataSource = null;
            dgvDispositivo.Refresh();
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
                if (legajos.Count == 0) { throw new AppException("Debe seleccionar al menos 1 usuarios a eliminar"); }
                //Pregunto si realmente quiere hacer la acción
                if (MessageBox.Show("Esta seguro que desea eliminar los empleados seleccionados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                { return; }

                reloj.EliminarUsuarios(legajos);
                InformarUsuario(legajos.Count.ToString() + " usuarios eliminados correctamente", "Baja de usuarios");
            }
            catch (Exception ex)
            {
                InformarError(ex.Message);
            }
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (comboRelojes.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un dispositivo", "Error");
                return;
            }
            if (reloj.Estado)
            {
                reloj.Desconectar();
                reloj.Estado = false;
            }
            LimpiarDgv(dgvDispositivo);
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
                if (chckBatch.Checked == true) { reloj.IniciarBatch(); }
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
                if(chckBatch.Checked==true) { reloj.IniciarBatch(); } //Controlar el modo batch
                LoguearInforme("Iniciando descarga de datos de usuarios...");
                backgroundWorkerSincronizacion.RunWorkerAsync();
            }
            catch (Exception ex)
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
            if (reloj.Estado) //Si hay otro equipo conectado, lo desconecto antes de conectar el seleccionado
            {
                reloj.Desconectar();
                reloj.Estado = false;
            }
            LimpiarDgv(dgvDispositivo);
            Cursor = Cursors.WaitCursor;
            reloj = relojes[comboRelojes.SelectedIndex];
            try
            {
                reloj.Conectar();
                reloj.Estado = true;
                labelEstado.Text = "Conectado a dispostivo : " + reloj.Nombre;
            }
            catch (Exception ex)
            {
                InformarError(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
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
        private List<Empleado> ObtenerSeleccionados()
        {
            List<Empleado> emps = new List<Empleado>();
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
                    emp.Baja = 0;
                    emps.Add(emp);
                }
            }
            return emps;
        }
    
        #endregion

        #region bakcgroundWorkers
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
            List<Empleado> emps = new List<Empleado>();
            ControladorDescargaDatos cdd = new ControladorDescargaDatos();

            try
            {
                emps = ObtenerSeleccionados();                        
                if (emps.Count==0) { throw new AppException("Por favor, seleccione al menos un empleado"); }
                int total = 0;
                cantHuellas = 0;
                foreach(Empleado emp in emps)
                {
                    cdd.DescargarInfo(emp);  //Descargo la info del usuario
                    cantHuellas += cdd.AgregarHuella(emp, reloj); //Descargo las huellas
                    total++;                    
                    backgroundWorkerSincronizacion.ReportProgress((total * 100) / emps.Count);
                }
                reloj.ActivarDispositivo();
                backgroundWorkerSincronizacion.ReportProgress(100);
            }
            catch (Exception)
            {
                backgroundWorkerSincronizacion.CancelAsync();
            }
        }

        private void backgroundWorkerSincronizacion_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBarSinc.Value = e.ProgressPercentage;
            lblProgreso.Text = e.ProgressPercentage.ToString() + "%"; 
        }

        private void backgroundWorkerSincronizacion_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
          //  if(chckBatch.Checked==true) { reloj.EjecutarBatch(); }
            if (progressBarSinc.Value < 100)
            {
                InformarError("Se produjo un error durante la descarga");                
            }
            else
            {
                InformarUsuario("Descarga de datos exitosa", "Sincronizacion de datos");
            }
            progressBarSinc.Value = 0;
            lblProgreso.Text = "0%";
            LlenarDgvLocal();
            LoguearInforme("Se descargaron " + cantHuellas.ToString() + " huellas.");
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
                        emp.Legajo = fila.Cells["Legajo"].Value.ToString();
                        emp.Nombre = fila.Cells["Nombre"].Value.ToString();
                        emp.Pin = fila.Cells["Clave"].Value.ToString();
                        emp.Privilegio = Convert.ToInt32(fila.Cells["Privilegios"].Value);
                        emp.Tarjeta = fila.Cells["Tarjeta"].Value.ToString();
                        emp.Id = Convert.ToInt32(fila.Cells["Id"].Value);
                        empleados.Add(emp);
                    }
                }
                if (empleados.Count == 0) { throw new AppException("Por favor, seleccione al menos 1 empleado"); }
                int total = 0;
                reloj.Deshabilitar();
                foreach(Empleado emp in empleados)
                {
                    ccd.CargarDatos(emp, reloj);
                    backgroundWorkerCargaDatos.ReportProgress((total * 100) / empleados.Count);
                    total++;
                }
                reloj.ActivarDispositivo();
                backgroundWorkerCargaDatos.ReportProgress(100);                
            }
            catch(Exception)
            {
                backgroundWorkerCargaDatos.CancelAsync();
            }
        }

        private void backgroundWorkerCargaDatos_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            // if (chckBatch.Checked == true) { reloj.EjecutarBatch(); }
            if (progressBarSinc.Value < 100)
            {
                InformarError("Se produjo un error durante la carga de datos");
            }
            else
            {
                InformarUsuario("Carga de datos finalizada correctamente","Carga de datos");
            }
            progressBarSinc.Value = 0;
            lblProgreso.Text = "0%";
           // LoguearInforme("Se cargaron: " + total.ToString() + " usuarios.");
        }
        private void backgroundWorkerCargaDatos_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBarSinc.Value = e.ProgressPercentage;
            lblProgreso.Text = e.ProgressPercentage.ToString() + "%";
        }
        #endregion


    }
}
