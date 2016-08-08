using System;
using System.Collections.Generic;
using System.Data;
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

        private void Relojes_Load(object sender, EventArgs e)
        {
            SetPermisos();
        }

        #region Botones
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if(ValidarConexion()) { return; }
            try
            {
                co.EliminarAdmins(GetNumero());
                Informar("Todos los adminsitradores fueron borrados.", "Borrado de administradores");
            }
            catch (AppException appex)
            {
                InformarError(appex.Message);
            }
            catch(Exception ex)
            {
                InformarError(ex.Message);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (GetEstado()=="Conectado")
            {
                InformarError("El dispositivo ya se encuentra conectado");
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
                SetCantRegis(co.GetCantidadRegistros(GetNumero()).ToString());
            }
            catch (AppException appex)
            {
                InformarError(appex.Message);
            }
            Cursor = Cursors.Default;
        }

        private void btnHora_Click(object sender, EventArgs e)
        {
            if (ValidarConexion()) { return; }
            try
            {
                co.SincronizarHora(GetNumero());
                Informar("Hora sincronizada correctamente.", "Sincronizacion hora");
            }
            catch (AppException appex)
            {
                InformarError(appex.Message);
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (ValidarConexion()) { return; }
            if(Preguntar()) { return; }
            Cursor = Cursors.WaitCursor;
            try
            {
                int cantidad;
                cantidad = co.GetCantidadRegistros(GetNumero());
                co.BorrarRegistros(GetNumero());
                Borrado(GetId(), cantidad);
                Informar(cantidad.ToString() + " registros eliminados.", "Eliminar registros");
            }
            catch (AppException appex)
            {
                InformarError(appex.Message);
            }
                Cursor = Cursors.Default;
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            if (GetEstado() == "Desconectado")
            {
                InformarError("El dispositivo está desconectado");
                return;
            }
            co.Desconectar(GetNumero());
            SetEstado("Desconectado");
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            ControladorRegistros cr = new ControladorRegistros();
            DataTable regis = new DataTable();
            List<string> desconocidos = new List<string>();
            if (ValidarConexion()) { return; }
            Cursor = Cursors.WaitCursor;
            try
            {
                regis = co.DescargarRegistros(GetNumero());
                desconocidos=cr.AgregarRegis(regis);
                if (desconocidos.Count > 0) { InformarError("Los legajos: " + string.Join("--", desconocidos.ToArray()) + " son desconocidos"); }
                Informar("Se descargaron: " + (regis.Rows.Count-desconocidos.Count).ToString() + " registros", "Descarga de registros");
            }
            catch (AppException appex)
            {
                InformarError(appex.Message);
            }
            catch (Exception ex)
            {
                InformarError(ex.Message);
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
                Informar("Equipo eliminado correctamente.", "Eliminar reloj");
                dgvRelojes.Rows.RemoveAt(dgvRelojes.CurrentRow.Index); //Elimino la fila actual
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnRutinaBajar_Click(object sender, EventArgs e)
        {
            if (Preguntar()) { return; }
            RutinaBajarRegistros();
        }
                                             
        private void btnRutinaHora_Click(object sender, EventArgs e)
        {
            if (Preguntar()) { return; }
            RutinaSincronizarHora();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            if (ValidarConexion()) { return; }
            if (Preguntar()) { return; }
            try
            {
                co.Reiniciar(GetNumero());
                Informar("Reinicio OK.", "Reiniciar dispositivos");
            }
            catch (AppException appex)
            {
                InformarError(appex.Message);
            }
            catch (Exception)
            {
                InformarError("Error totalmente desconocido al intentar reiniciar el dispositivo.");
            }
        }
        private void btnInicializar_Click(object sender, EventArgs e)
        {
            if (ValidarConexion()) { return; }
            if (Preguntar()) { return; }
            try
            {
                co.Inicializar(GetNumero());
                Informar("Dispositivo inicializado correctamente.", "Incializar dispositivo");
            }
            catch (AppException appex)
            {
                InformarError(appex.Message);
            }
            catch (Exception)
            {
                InformarError("Error totalmente desconocido al intentar inicializar el dispositivo");
            }
        }

        #endregion
        #region DataGriedView
        private void dgvRelojes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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
        private bool ValidarConexion()
        {
            if ("Desconectado" == GetEstado())
            {
                InformarError("Por favor, conecte con dispositivo");
                return true;
            }
            return false;
        }

        private bool Preguntar()
        {
            if (MessageBox.Show("Esta seguro que desea realizar la accion?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            { return true; }
            else { return false; }
        }

        private void Informar(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void InformarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                InformarError(ex.Message);
            }            
        }

        private void SetPermisos()
        {
            ControladorLogin cl = new ControladorLogin();
            
            if(cl.GetNivelUsr()<3)
            {
                btnBorrar.Enabled = true;
                groupABM.Enabled = true;
            }
            if (cl.GetNivelUsr() == 1)
            {
                groupAvanzadas.Enabled = true;
            }         
        }

        public void RutinaBajarRegistros()
        {
            Cursor = Cursors.WaitCursor; //Cursor de espera
            int total = 0;
            ControladorArchivos ca = new ControladorArchivos();
            ControladorRegistros cr = new ControladorRegistros();
            ca.Rutina("Inicio", "Descarga de registros");
            foreach (Reloj r in relojes)
            {
                try
                {
                    DataTable regis = new DataTable();
                    co.Conectar(r.Ip, r.Puerto, r.Clave, r.Numero);
                    regis = co.DescargarRegistros(r.Numero);
                    cr.AgregarRegis(regis);
                    co.BorrarRegistros(r.Numero);
                    Borrado(r.Id, regis.Rows.Count);
                    co.Desconectar(r.Numero);
                    total += regis.Rows.Count;
                }
                catch (Exception)
                {
                    ca.Rutina("Fin", "Se produjo un error con reloj: " + r.Numero.ToString());
                }
            }
            ca.Rutina("Fin", "Descarga de registros");
            MessageBox.Show("Rutina finalizada, " + total.ToString() + " registros descargados");
            Cursor = Cursors.Default; //Cursor normal
        }

        public void RutinaSincronizarHora()
        {
            Cursor = Cursors.WaitCursor;
            ControladorArchivos ca = new ControladorArchivos();
            try
            {
                ca.Rutina("Inicio", "Rutina de sincronizacion de hora");
                foreach (Reloj r in relojes)
                {
                    string llave;
                    llave = GetClave();
                    co.Conectar(r.Ip, r.Puerto, r.Clave, GetNumero());
                    co.SincronizarHora(r.Numero);
                }
                MessageBox.Show("Rutina de sincronizacion de hora finalizada");
                ca.Rutina("Fin", "Rutina de sincronizacion de hora");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                ca.Rutina("Fin", "Se produjo un error durante la rutina");
            }
            Cursor = Cursors.Default;
        }
    }
}
