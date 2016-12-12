using System.Windows.Forms;

namespace ZkManagement.NewUI.Generic
{
    public partial class GenericAbm : Form
    {
        public GenericAbm()
        {
            InitializeComponent();
        }
        protected virtual void InformarError(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        protected virtual void Informar(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        protected virtual bool Question(string mensaje, string titulo)
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
        public virtual void MapearAForm(object T) { }
        
        protected virtual void MapearDeForm() { }

        protected virtual void btnGuardar_Click(object sender, System.EventArgs e) { }

        protected virtual void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }
        protected virtual bool Validar()
        {
            return false;
        } 
    }
}
