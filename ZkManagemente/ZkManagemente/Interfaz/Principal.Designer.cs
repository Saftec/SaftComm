namespace ZkManagement.Interfaz
{
    partial class Principal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnRelojes = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 78);
            this.panel1.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnConfig);
            this.panelMenu.Controls.Add(this.btnRelojes);
            this.panelMenu.Location = new System.Drawing.Point(217, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(587, 77);
            this.panelMenu.TabIndex = 0;
            // 
            // btnRelojes
            // 
            this.btnRelojes.Location = new System.Drawing.Point(37, 12);
            this.btnRelojes.Name = "btnRelojes";
            this.btnRelojes.Size = new System.Drawing.Size(84, 47);
            this.btnRelojes.TabIndex = 0;
            this.btnRelojes.Text = "Relojes";
            this.btnRelojes.UseVisualStyleBackColor = true;
            this.btnRelojes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(168, 12);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(84, 47);
            this.btnConfig.TabIndex = 1;
            this.btnConfig.Text = "Configuracion";
            this.btnConfig.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 668);
            this.Controls.Add(this.panel1);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel1.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnRelojes;
        private System.Windows.Forms.Button btnConfig;
    }
}