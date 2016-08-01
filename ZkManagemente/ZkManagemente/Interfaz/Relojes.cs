using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ZkManagement.Entidades;
using ZkManagement.Logica;
using ZkManagement.Util;

namespace ZkManagement.Interfaz
{
    public partial class Relojes : Form
    {
        private ControladorOperaciones co = new ControladorOperaciones();
        private List<Reloj> relojes = new List<Reloj>();
        public Relojes()
        {
            InitializeComponent();
            CargarDataGridView();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void CargarDataGridView()
        {            
            ControladorReloj cr = new ControladorReloj();
            relojes.Clear();
            dgvRelojes.Rows.Clear();         
            try
            {
                relojes = cr.TodosRelojes();               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            foreach (Reloj reloj in relojes)
            {
                dgvRelojes.Rows.Add(reloj.Numero, reloj.Nombre, reloj.Ip, reloj.Puerto, "Desconectado", "0", string.Empty, string.Empty, reloj.DNS, reloj.Id, reloj.Clave);
            }
            dgvRelojes.Refresh();
            dgvRelojes.Update();

        }

        private void Relojes_Load(object sender, EventArgs e)
        {
        }

        #region DataGriedView

        private string GetNombre()
        {
            return (dgvRelojes.CurrentRow.Cells[0].Value).ToString();
        }
        private string GetIp()
        {
            return (dgvRelojes.CurrentRow.Cells[2].Value).ToString();
        }

        private int GetPuerto()
        {
            return Convert.ToInt32((dgvRelojes.CurrentRow.Cells[3].Value).ToString());
        }

        private int GetNumero()
        {
            return Convert.ToInt32((dgvRelojes.CurrentRow.Cells[0].Value).ToString());
        }

        private void SetEstado(string valor)
        {
            dgvRelojes.CurrentRow.Cells[4].Value = valor;
        }

        private string GetEstado()
        {
            return (dgvRelojes.CurrentRow.Cells[4].Value).ToString();
        }

        private void SetCantRegis(string valor)
        {
            dgvRelojes.CurrentRow.Cells[5].Value = valor;
        }
        
        private void SetModelo(string valor)
        {
            dgvRelojes.CurrentRow.Cells[6].Value = valor;
        }

        private void SetMac(string valor)
        {
            dgvRelojes.CurrentRow.Cells[7].Value = valor;
        }

        private string GetDns()
        {
            return (dgvRelojes.CurrentRow.Cells[8].Value).ToString();
        }

        private int GetId()
        {
            return Convert.ToInt32((dgvRelojes.CurrentRow.Cells[9].Value).ToString());
        }

        private string GetClave()
        {
            return (dgvRelojes.CurrentRow.Cells[10].Value).ToString();
        }
        #endregion

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if(GetEstado()=="Conectado")
            {
                MessageBox.Show("El dispositivo ya se encuentra conectado", "Error");
                return;
            }
            Cursor = Cursors.WaitCursor;
            string llave = GetClave();   
            try
            {
                co.Conectar(GetIp(), GetPuerto(), llave, GetNumero());                             
                SetEstado("Conectado");
                SetMac(co.GetMac(GetNumero()));
                SetModelo(co.GetModelo(GetNumero()));
            }
            catch(AppException appex)
            {
                MessageBox.Show(appex.Message, "Error");
            }
            Cursor = Cursors.Default;
        }

        private void dgvRelojes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHora_Click(object sender, EventArgs e)
        {
            if (ValidarConexion()) { return; }
            try
            {
                co.SincronizarHora(GetNumero());
                MessageBox.Show("Hora sincronizada");
            }
            catch(AppException appex)
            {
                MessageBox.Show(appex.Message, "Error");
            }
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (ValidarConexion()) { return; }
            Cursor = Cursors.WaitCursor;
            try
            {
                int cantidad;
                cantidad = co.GetCantidadRegistros(GetNumero());
                co.BorrarRegistros(GetNumero());
                Borrado(GetId(), cantidad);
                MessageBox.Show(cantidad.ToString() + " registros eliminados.");
            }
            catch(AppException appex)
            {
                MessageBox.Show(appex.Message, "Error");
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private bool ValidarConexion()
        {
            if ("Desconectado" == GetEstado())
            {
                MessageBox.Show("Por favor, conecte con dispositivo", "Error");
                return true;
            }
            return false;
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            if (GetEstado()=="Desconectado")
            {
                MessageBox.Show("El dispositivo está desconectado", "Error");
                return;
            }
            co.Desconectar(GetNumero());
            SetEstado("Desconectado");
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            if(ValidarConexion()) { return; }
            Cursor = Cursors.WaitCursor;
            int total = 0;
            try
            {
                total=co.DescargarRegistros(GetNumero());
                MessageBox.Show("Se descargaron: " + total.ToString() + " registros");
            }
            catch(AppException appex)
            {
                MessageBox.Show(appex.Message, "Error");
            }
            Cursor = Cursors.Default;
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            AbmReloj abm = new AbmReloj();
            Reloj r = new Reloj(GetPuerto(), GetNumero(), GetId(), GetClave(), GetDns(), GetIp(), GetNombre());
            abm.Editar(r);
            abm.ShowDialog(this);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AbmReloj abm = new AbmReloj();
            abm.Show(this);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Preguntar()) { return; }
            try
            {
                ControladorReloj cr = new ControladorReloj();
                Reloj r = new Reloj(GetPuerto(), GetNumero(), GetId(), GetClave(), GetDns(), GetIp(), GetNombre());
                cr.EliminarReloj(r);
                MessageBox.Show("Equipo eliminado","Baja");
                dgvRelojes.Rows.RemoveAt(dgvRelojes.CurrentRow.Index); //Elimino la fila actual
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnRutinaBajar_Click(object sender, EventArgs e)
        {
            if (Preguntar()) { return; }
            Cursor = Cursors.WaitCursor; //Cursor de espera
            ControladorArchivos ca = new ControladorArchivos();
            try
            {
                ca.Rutina("Inicio", "Descarga de registros");
                int total = 0;
                foreach (Reloj r in relojes)
                {
                    int cant;
                    co.Conectar(r.Ip, r.Puerto, r.Clave, r.Numero);                    
                    cant = co.DescargarRegistros(r.Numero);
                    co.BorrarRegistros(r.Numero);
                    Borrado(r.Id, cant);
                    co.Desconectar(r.Numero);
                    total += cant;
                }
                ca.Rutina("Fin", "Descarga de registros");
                MessageBox.Show("Rutina finalizada, " + total.ToString() + " registros descargados");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
                ca.Rutina("Fin", "Se produjo un error durante la rutina");
            }
            Cursor = Cursors.Default; //Cursor normal 
        }

        private bool Preguntar()
        {
            if (MessageBox.Show("Esta seguro que desea realizar la accion?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            { return true; }
            else { return false; }
        }
        private void btnRutinaHora_Click(object sender, EventArgs e)
        {
            if (Preguntar()) { return; }
            Cursor = Cursors.WaitCursor;
            ControladorArchivos ca = new ControladorArchivos();
            try
            {
                ca.Rutina("Inicio", "Rutina de sincronizacion de hora");
                foreach(Reloj r in relojes)
                {
                    string llave;
                    llave = GetClave();                 
                    co.Conectar(r.Ip, r.Puerto, r.Clave, GetNumero() ); 
                    co.SincronizarHora(r.Numero);
                }
                MessageBox.Show("Rutina de sincronizacion de hora finalizada");
                ca.Rutina("Fin", "Rutina de sincronizacion de hora");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                ca.Rutina("Fin", "Se produjo un error durante la rutina");
            }
            Cursor = Cursors.Default;
        }

        private void Borrado(int idReloj, int cant)
        {
            ControladorReloj cr = new ControladorReloj();
            try
            {
                cr.ActualizarBorrado(idReloj, cant);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }            
        }
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            if (ValidarConexion()) { return; }
            if (Preguntar()) { return; }
            try
            {
                co.Reiniciar(GetNumero());
                MessageBox.Show("Reinicio OK.", "Reiniciar dispositivos");
            }
            catch (AppException appex)
            {
                MessageBox.Show(appex.Message, "Error");
            }
            catch(Exception)
            {
                MessageBox.Show("Error totalmente desconocido al intentar reiniciar el dispositivo.","Error");
            }
        }

        private void btnInicializar_Click(object sender, EventArgs e)
        {
            if (ValidarConexion()) { return; }
            if (Preguntar()) { return; }
            try
            {
                co.Inicializar(GetNumero());
                MessageBox.Show("Inicializacion OK.", "Incializar dispositivo");
            }
            catch (AppException appex)
            {
                MessageBox.Show(appex.Message, "Error");
            }
            catch (Exception)
            {
                MessageBox.Show("Error totalmente desconocido al intentar inicializar el dispositivo", "Error");
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
        }
    }
}
