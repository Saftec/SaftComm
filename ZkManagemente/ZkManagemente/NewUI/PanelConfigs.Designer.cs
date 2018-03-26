namespace ZkManagement.NewUI
{
    partial class PanelConfigs
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.linkBaseDeDatos = new MetroFramework.Controls.MetroLink();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.linkSaftime = new MetroFramework.Controls.MetroLink();
            this.linkRutinas = new MetroFramework.Controls.MetroLink();
            this.pConfigs = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.linkRutinas);
            this.metroPanel1.Controls.Add(this.linkBaseDeDatos);
            this.metroPanel1.Controls.Add(this.metroLink2);
            this.metroPanel1.Controls.Add(this.linkSaftime);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(135, 580);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // linkBaseDeDatos
            // 
            this.linkBaseDeDatos.Location = new System.Drawing.Point(3, 251);
            this.linkBaseDeDatos.Name = "linkBaseDeDatos";
            this.linkBaseDeDatos.Size = new System.Drawing.Size(84, 23);
            this.linkBaseDeDatos.TabIndex = 5;
            this.linkBaseDeDatos.Text = "Base de datos";
            this.linkBaseDeDatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkBaseDeDatos.UseSelectable = true;
            this.linkBaseDeDatos.UseStyleColors = true;
            this.linkBaseDeDatos.Click += new System.EventHandler(this.linkBaseDeDatos_Click);
            // 
            // metroLink2
            // 
            this.metroLink2.Location = new System.Drawing.Point(3, 193);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(129, 23);
            this.metroLink2.TabIndex = 4;
            this.metroLink2.Text = "Formatos de descarga";
            this.metroLink2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLink2.UseSelectable = true;
            this.metroLink2.UseStyleColors = true;
            this.metroLink2.Click += new System.EventHandler(this.metroLink2_Click);
            // 
            // linkSaftime
            // 
            this.linkSaftime.Location = new System.Drawing.Point(3, 222);
            this.linkSaftime.Name = "linkSaftime";
            this.linkSaftime.Size = new System.Drawing.Size(51, 23);
            this.linkSaftime.TabIndex = 3;
            this.linkSaftime.Text = "Saftime";
            this.linkSaftime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkSaftime.UseSelectable = true;
            this.linkSaftime.UseStyleColors = true;
            this.linkSaftime.Click += new System.EventHandler(this.linkSaftime_Click);
            // 
            // linkRutinas
            // 
            this.linkRutinas.Location = new System.Drawing.Point(3, 164);
            this.linkRutinas.Name = "linkRutinas";
            this.linkRutinas.Size = new System.Drawing.Size(123, 23);
            this.linkRutinas.TabIndex = 2;
            this.linkRutinas.Text = "Rutinas automáticas";
            this.linkRutinas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkRutinas.UseSelectable = true;
            this.linkRutinas.UseStyleColors = true;
            this.linkRutinas.Click += new System.EventHandler(this.linkRutinas_Click);
            // 
            // pConfigs
            // 
            this.pConfigs.HorizontalScrollbarBarColor = true;
            this.pConfigs.HorizontalScrollbarHighlightOnWheel = false;
            this.pConfigs.HorizontalScrollbarSize = 10;
            this.pConfigs.Location = new System.Drawing.Point(144, 3);
            this.pConfigs.Name = "pConfigs";
            this.pConfigs.Size = new System.Drawing.Size(713, 480);
            this.pConfigs.TabIndex = 2;
            this.pConfigs.VerticalScrollbarBarColor = true;
            this.pConfigs.VerticalScrollbarHighlightOnWheel = false;
            this.pConfigs.VerticalScrollbarSize = 10;
            // 
            // PanelConfigs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pConfigs);
            this.Controls.Add(this.metroPanel1);
            this.Name = "PanelConfigs";
            this.Controls.SetChildIndex(this.metroPanel1, 0);
            this.Controls.SetChildIndex(this.pConfigs, 0);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLink metroLink2;
        private MetroFramework.Controls.MetroLink linkSaftime;
        private MetroFramework.Controls.MetroLink linkRutinas;
        private MetroFramework.Controls.MetroPanel pConfigs;
        private MetroFramework.Controls.MetroLink linkBaseDeDatos;
    }
}
