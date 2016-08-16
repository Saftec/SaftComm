using System;
using System.Configuration;
using System.Windows.Forms;

namespace ZkManagement.Interfaz
{
    public partial class ConexionBD : Form
    {
        public ConexionBD()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string cnx;
            cnx = @"Data Source=" + txtServidor.Text + ";Initial Catalog=" + txtBase.Text + ";Integrated Security=True;User ID=" + txtUsuario.Text + ";Password=" + txtPassword.Text;
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["cnsSQL"].ConnectionString = cnx;
            ConnectionStringsSection constringsec = config.ConnectionStrings;
            constringsec.SectionInformation.ProtectSection("DataProtectionConfigurationProvider"); //Encripto y guardo la nueva cadena de conexión.
            config.Save();
            Application.Restart(); //Reinicio la app.
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
