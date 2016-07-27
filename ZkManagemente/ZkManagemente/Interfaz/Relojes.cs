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
                dgvRelojes.Rows.Add(reloj.Numero, reloj.Puerto, reloj.Ip, reloj.Nombre, "0", string.Empty, "Desconectado", string.Empty);
            }
        }

        private void Relojes_Load(object sender, EventArgs e)
        {

        }

        #region DataGriedView
        private string GetIp()
        {
            return (dgvRelojes.CurrentRow.Cells[2].Value).ToString();
        }

        private int GetPuerto()
        {
            return Convert.ToInt32((dgvRelojes.CurrentRow.Cells[1].Value).ToString());
        }

        private int GetNumero()
        {
            return Convert.ToInt32((dgvRelojes.CurrentRow.Cells[0].Value).ToString());
        }

        private void SetEstado(String valor)
        {
            dgvRelojes.CurrentRow.Cells[6].Value = valor;
        }

        private string GetEstado()
        {
            return (dgvRelojes.CurrentRow.Cells[6].Value).ToString();
        }

        private void SetCantRegis(string valor)
        {
            dgvRelojes.CurrentRow.Cells[4].Value = valor;
        }
        
        private void SetModelo(string valor)
        {
            dgvRelojes.CurrentRow.Cells[5].Value = valor;
        }

        private void SetMac(string valor)
        {
            dgvRelojes.CurrentRow.Cells[7].Value = valor;
        }
        #endregion

        private void btnConectar_Click(object sender, EventArgs e)
        {
          
            try
            {
                co.Conectar(GetIp(), GetPuerto());
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
    }
}
