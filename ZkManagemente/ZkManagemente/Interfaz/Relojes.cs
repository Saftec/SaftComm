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
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void Open()
        {
            ControladorReloj cr = new ControladorReloj();           
            try
            {
                relojes = cr.TodosRelojes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            foreach(Reloj reloj in relojes)
            {
                dgvRelojes.Rows.Add(reloj.Numero, reloj.Nombre, reloj.Ip, reloj.Puerto, "Desconectado", "0", string.Empty,  string.Empty, reloj.DNS, reloj.Id);
            }
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
        #endregion

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string llave = ObtenerLlave(GetId());   
            try
            {
                if (llave!=string.Empty) { co.Conectar(GetIp(), GetPuerto(), Convert.ToInt32(llave)); }
                else { co.Conectar(GetIp(), GetPuerto()); }               
                SetEstado("Conectado");
                SetMac(co.GetMac(GetNumero()));
                SetModelo(co.GetMac(GetNumero()));
            }
            catch(AppException appex)
            {
                MessageBox.Show(appex.Message, "Error");
            }             
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
            try
            {
                co.BorrarRegistros(GetNumero());
            }
            catch(AppException appex)
            {
                MessageBox.Show(appex.Message, "Error");
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
            co.Desconectar();
            SetEstado("Desconectado");
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            if(ValidarConexion()) { return; }

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
        }

        private string ObtenerLlave(int id)
        {
            int i;
            Reloj r = new Reloj();
            r.Id = id;
            i=relojes.IndexOf(r);
            r = relojes[i];
            return r.Clave;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AbmReloj abm = new AbmReloj();
            Reloj r = new Reloj();
            r.Clave = ObtenerLlave(GetId());
            r.DNS = GetDns();
            r.Id = GetId();
            r.Ip = GetIp();
            r.Nombre = GetNombre();
            r.Numero = GetNumero();
            r.Puerto = GetPuerto();
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
            if (MessageBox.Show("Desea eliminar el reloj?", "Baja dispositivos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { return; }
            try
            {
                ControladorReloj cr = new ControladorReloj();
                Reloj r = new Reloj(GetPuerto(), GetNumero(), GetId(), ObtenerLlave(GetId()), GetDns(), GetIp(), GetNombre());
                cr.EliminarReloj(r);
                MessageBox.Show("Dispositivo eliminado");
                dgvRelojes.Rows.RemoveAt(dgvRelojes.CurrentRow.Index); //Elimino la fila actual
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnRutinaBajar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea ejecutar la rutina?", "Rutinas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { return; }
            ControladorArchivos ca = new ControladorArchivos();
            try
            {
                ca.Rutina("Inicio", "Descarga de registros");
                int total = 0;
                foreach (Reloj r in relojes)
                {
                    int cant;
                    string llave;
                    llave=ObtenerLlave(r.Id);
                    if (llave == string.Empty) { co.Conectar(r.Ip, r.Puerto); }
                    else { co.Conectar(r.Ip, r.Puerto, Convert.ToInt32(r.Clave)); }
                    co.GetCantidadRegistros(r.Numero);
                    cant = co.DescargarRegistros(r.Numero);
                    co.BorrarRegistros(r.Numero);
                    co.Desconectar();
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
        }

        private void btnRutinaHora_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea ejecutar la rutina?", "Rutinas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) { return; }
            ControladorArchivos ca = new ControladorArchivos();
            try
            {
                ca.Rutina("Inicio", "Rutina de sincronizacion de hora");
                foreach(Reloj r in relojes)
                {
                    string llave;
                    llave = ObtenerLlave(r.Id);
                    if (llave == string.Empty) { co.Conectar(r.Ip, r.Puerto); }
                    else { co.Conectar(r.Ip, r.Puerto, Convert.ToInt32(r.Clave)); }
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
            
        }
    }
}
