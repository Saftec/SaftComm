using System;
using System.Windows.Forms;
using ZkManagement.Entidades;
using ZkManagement.Logica;
using ZkManagement.Util;

namespace ZkManagement.Interfaz
{
    public partial class AbmReloj : Form
    {
        private int id;
        private LogicReloj cr; 

        public AbmReloj()
        {
            InitializeComponent();
        }

        public void Editar(Reloj r)
        {
            txtNombre.Text = r.Nombre;
            txtNro.Text = r.Numero.ToString();
            txtIp.Text = r.Ip;
            txtPuerto.Text = r.Puerto.ToString();
            if (r.Clave == "0")
            {
                txtPsw.Text = string.Empty;
            }
            else
            {
                txtPsw.Text = r.Clave;
            }           
            txtDns.Text = r.DNS;
            id = r.Id;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            cr = new LogicReloj();                     
            try
            {
                ValidarDatos();
                Reloj r = new Reloj(Convert.ToInt32(txtPuerto.Text), Convert.ToInt32(txtNro.Text), id, txtPsw.Text, txtDns.Text, txtIp.Text, txtNombre.Text);
                cr.ModifReloj(r);
                MessageBox.Show("Cambios guardados correctamente", "Modificar Reloj");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
            Close();            
        }

        private void ValidarDatos()
        {
            Validate validate = new Validate();
            string[] notNulls = { txtNombre.Text, txtNro.Text };
            string[] numeros = { txtPuerto.Text, txtNro.Text };
            if (!validate.IsEmpty(new string[] { txtIp.Text }) && !validate.IsEmpty(new string[] { txtDns.Text }))
            {
                throw new AppException("Debe ingresar una dirección IP o un host DNS");
            }
            if (validate.IsEmpty(new string[] { txtIp.Text }) && !validate.DireccionIP(new string[] { txtIp.Text }))
            {
                throw new AppException("La dirección IP ingresada es inválida");
            }
            if (validate.IsEmpty(new string[] { txtIp.Text }) && !validate.IsEmpty(new string[] { txtPuerto.Text }))
            {
                throw new AppException("Debe ingresar un número de puerto");
            }
            if (!validate.IsEmpty(notNulls))
            {
                throw new AppException("Estos campos no pueden estar vacíos");
            }
          /*  if (!validate.NumerosEnteros(numeros))
            {
                throw new AppException("Estos campos deben contener sólo números");
            } */
        }
    }
}
