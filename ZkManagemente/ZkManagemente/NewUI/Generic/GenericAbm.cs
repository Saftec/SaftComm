using System.Windows.Forms;

namespace ZkManagement.NewUI.Generic
{
    public partial class GenericAbm : Form
    {
        public GenericAbm()
        {
            InitializeComponent();
        }
        protected void InformarError(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        protected void Informar(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        protected bool Question(string mensaje, string titulo)
        {
            if (MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
