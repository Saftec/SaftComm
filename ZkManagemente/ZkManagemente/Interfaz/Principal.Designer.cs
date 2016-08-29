namespace ZkManagement.Interfaz
{
    partial class btnEmpleados
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnEmpleados));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnRelojes = new System.Windows.Forms.Button();
            this.iconoBandeja = new System.Windows.Forms.NotifyIcon(this.components);
            this.timerRutinaRegs = new System.Windows.Forms.Timer(this.components);
            this.timerRutinaHora = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStriplabelHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblVersion);
            this.panel1.Controls.Add(this.panelMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 78);
            this.panel1.TabIndex = 0;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblUsuario.Location = new System.Drawing.Point(916, 37);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(56, 15);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(951, 9);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(42, 13);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Version";
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.btnUsuarios);
            this.panelMenu.Controls.Add(this.btnConfig);
            this.panelMenu.Controls.Add(this.btnRelojes);
            this.panelMenu.Location = new System.Drawing.Point(153, 3);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(587, 72);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // button2
            // 
            this.button2.Image = global::ZkManagement.Properties.Resources.group;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(335, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "Empleados";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Enabled = false;
            this.btnUsuarios.Image = global::ZkManagement.Properties.Resources.padlock;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsuarios.Location = new System.Drawing.Point(473, 16);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(84, 47);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnConfig
            // 
            this.btnConfig.Enabled = false;
            this.btnConfig.Image = global::ZkManagement.Properties.Resources.settings;
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfig.Location = new System.Drawing.Point(58, 16);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(84, 47);
            this.btnConfig.TabIndex = 1;
            this.btnConfig.Text = "Configuracion";
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnRelojes
            // 
            this.btnRelojes.Image = global::ZkManagement.Properties.Resources.clock;
            this.btnRelojes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRelojes.Location = new System.Drawing.Point(196, 16);
            this.btnRelojes.Name = "btnRelojes";
            this.btnRelojes.Size = new System.Drawing.Size(84, 47);
            this.btnRelojes.TabIndex = 0;
            this.btnRelojes.Text = "Relojes";
            this.btnRelojes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRelojes.UseVisualStyleBackColor = true;
            this.btnRelojes.Click += new System.EventHandler(this.button1_Click);
            // 
            // iconoBandeja
            // 
            this.iconoBandeja.Icon = ((System.Drawing.Icon)(resources.GetObject("iconoBandeja.Icon")));
            this.iconoBandeja.Text = "notifyIcon1";
            this.iconoBandeja.Visible = true;
            // 
            // timerRutinaRegs
            // 
            this.timerRutinaRegs.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerRutinaHora
            // 
            this.timerRutinaHora.Tick += new System.EventHandler(this.timerRutinaHora_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ZkManagement.Properties.Resources.LogoPpal;
            this.pictureBox1.Location = new System.Drawing.Point(12, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(630, 128);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStriplabelHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 692);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1048, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStriplabelHora
            // 
            this.toolStriplabelHora.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStriplabelHora.Name = "toolStriplabelHora";
            this.toolStriplabelHora.Size = new System.Drawing.Size(123, 17);
            this.toolStriplabelHora.Text = "toolStripStatusLabel1";
            // 
            // timerHora
            // 
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // btnEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 714);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "btnEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.btnEmpleados_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnRelojes;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NotifyIcon iconoBandeja;
        private System.Windows.Forms.Timer timerRutinaRegs;
        private System.Windows.Forms.Timer timerRutinaHora;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStriplabelHora;
        private System.Windows.Forms.Timer timerHora;
    }
}