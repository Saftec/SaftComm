﻿using System;
using System.Windows.Forms;
using ZkManagement.Logica;

namespace ZkManagement.Interfaz
{
    public partial class Configuracion : GenericaPadre
    {
        private ControladorConfiguraciones cc = new ControladorConfiguraciones();
        public Configuracion()
        {
            InitializeComponent();
        }
            private void CargarConfigs()
        {
            string valor;
            txtPathRegs.Text = cc.GetConfig(2);
            txtMinRegs.Text = cc.GetConfig(5);
            txtMinHs.Text = cc.GetConfig(7);
            txtHSDesde.Text = cc.GetConfig(14);
            txtHSHasta.Text = cc.GetConfig(15);
            valor = cc.GetConfig(4);
            if (valor=="S") { chckActivaReg.Checked = true; }
            valor = cc.GetConfig(6);
            if (valor=="S") { chckActivaHora.Checked = true; }
            valor = cc.GetConfig(16);
            if(valor=="S") { chckActivarHorarios.Checked = true; }
            valor = cc.GetConfig(8);          
            if (valor == "S")
            {
                groupFtp.Enabled = true;
                chckActivarFtp.Checked = true;
                txtServidor.Text = cc.GetConfig(9);
                txtUsuario.Text = cc.GetConfig(10);
                txtContraseña.Text = cc.GetConfig(11);
                txtPathFtp.Text = cc.GetConfig(12);
                txtPuerto.Text = cc.GetConfig(13);
            }
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                cc.SetConfig(2, txtPathRegs.Text);
                cc.SetConfig(5, txtMinRegs.Text);
                cc.SetConfig(7, txtMinHs.Text);
                if (chckActivaHora.Checked == true)
                {
                    cc.SetConfig(8, "S");
                }
                else
                {
                    cc.SetConfig(8,"N");
                }
                if (chckActivaReg.Checked == true)
                {
                    cc.SetConfig(6, "S");
                }
                else
                {
                    cc.SetConfig(6, "N");
                }
                if (chckActivarFtp.Checked == true)
                {
                    cc.SetConfig(8, "S");
                }               
                else { cc.SetConfig(8, "N"); }
                if (chckActivarHorarios.Checked == true)
                {
                    cc.SetConfig(16, "S");
                    cc.SetConfig(14, txtHSDesde.Text);
                    cc.SetConfig(15, txtHSHasta.Text);
                }
                else { cc.SetConfig(16, "N"); }

                MessageBox.Show("Configuraciones guardadas");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            Cursor = Cursors.Default;
        }

        private void chckActivaReg_CheckedChanged(object sender, EventArgs e)
        {
            if (chckActivaReg.Checked == true)
            {
                txtMinRegs.Enabled = true;
            }
            else
            {
                txtMinRegs.Enabled = false;
            }
        }

        private void chckActivarFtp_CheckedChanged(object sender, EventArgs e)
        {
            if (chckActivarFtp.Checked == false)
            {
                groupFtp.Enabled = false;
                txtPathFtp.Text = string.Empty;
                txtPuerto.Text = string.Empty;
                txtServidor.Text = string.Empty;
                txtUsuario.Text = string.Empty;
                txtContraseña.Text = string.Empty;
            }
            else
            {
                groupFtp.Enabled = true;
            }
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            CargarConfigs();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chckActivarHorarios_CheckedChanged(object sender, EventArgs e)
        {
            if (chckActivarHorarios.Checked == true)
            {
                txtHSDesde.Enabled = true;
                txtHSHasta.Enabled = true;
            }
            else
            {
                txtHSDesde.Enabled = false;
                txtHSHasta.Enabled = false;
            }
        }

        private void chckActivaHora_CheckedChanged(object sender, EventArgs e)
        {
            if (chckActivaHora.Checked == true)
            {
                txtMinHs.Enabled = true;
            }
            else
            {
                txtMinHs.Enabled = false;
            }
        }
    }
}
