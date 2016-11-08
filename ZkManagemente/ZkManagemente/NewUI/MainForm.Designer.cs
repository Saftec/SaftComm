namespace ZkManagement.NewUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPersonal = new System.Windows.Forms.TabPage();
            this.tabRelojes = new System.Windows.Forms.TabPage();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.tabUsuarios = new System.Windows.Forms.TabPage();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPersonal);
            this.metroTabControl1.Controls.Add(this.tabRelojes);
            this.metroTabControl1.Controls.Add(this.tabConfig);
            this.metroTabControl1.Controls.Add(this.tabUsuarios);
            this.metroTabControl1.Location = new System.Drawing.Point(139, 10);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(761, 629);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPersonal
            // 
            this.tabPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPersonal.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPersonal.Location = new System.Drawing.Point(4, 38);
            this.tabPersonal.Name = "tabPersonal";
            this.tabPersonal.Size = new System.Drawing.Size(753, 587);
            this.tabPersonal.TabIndex = 0;
            this.tabPersonal.Text = "Personal";
            // 
            // tabRelojes
            // 
            this.tabRelojes.Location = new System.Drawing.Point(4, 38);
            this.tabRelojes.Name = "tabRelojes";
            this.tabRelojes.Size = new System.Drawing.Size(753, 587);
            this.tabRelojes.TabIndex = 1;
            this.tabRelojes.Text = "Relojes";
            // 
            // tabConfig
            // 
            this.tabConfig.Location = new System.Drawing.Point(4, 38);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Size = new System.Drawing.Size(753, 587);
            this.tabConfig.TabIndex = 2;
            this.tabConfig.Text = "Configuracion";
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.Location = new System.Drawing.Point(4, 38);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Size = new System.Drawing.Size(753, 587);
            this.tabUsuarios.TabIndex = 3;
            this.tabUsuarios.Text = "Usuarios";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 640);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "MainForm";
            this.Text = "SaftComm";
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPersonal;
        private System.Windows.Forms.TabPage tabRelojes;
        private System.Windows.Forms.TabPage tabConfig;
        private System.Windows.Forms.TabPage tabUsuarios;
    }
}