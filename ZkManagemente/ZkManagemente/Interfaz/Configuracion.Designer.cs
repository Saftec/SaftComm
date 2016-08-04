namespace ZkManagement.Interfaz
{
    partial class Configuracion
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
            this.groupArchivos = new System.Windows.Forms.GroupBox();
            this.txtPathLog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPathRegs = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtMinRegs = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chckActivaHora = new System.Windows.Forms.CheckBox();
            this.chckActivaReg = new System.Windows.Forms.CheckBox();
            this.txtMinHs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupFtp = new System.Windows.Forms.GroupBox();
            this.chckActivarFtp = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPathFtp = new System.Windows.Forms.TextBox();
            this.groupArchivos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupFtp.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupArchivos
            // 
            this.groupArchivos.Controls.Add(this.txtPathLog);
            this.groupArchivos.Controls.Add(this.label2);
            this.groupArchivos.Controls.Add(this.label1);
            this.groupArchivos.Controls.Add(this.txtPathRegs);
            this.groupArchivos.Location = new System.Drawing.Point(12, 24);
            this.groupArchivos.Name = "groupArchivos";
            this.groupArchivos.Size = new System.Drawing.Size(417, 80);
            this.groupArchivos.TabIndex = 0;
            this.groupArchivos.TabStop = false;
            this.groupArchivos.Text = "Archivos";
            // 
            // txtPathLog
            // 
            this.txtPathLog.Location = new System.Drawing.Point(104, 50);
            this.txtPathLog.Name = "txtPathLog";
            this.txtPathLog.Size = new System.Drawing.Size(299, 20);
            this.txtPathLog.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Archivos log: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Archivo registros: ";
            // 
            // txtPathRegs
            // 
            this.txtPathRegs.Location = new System.Drawing.Point(104, 16);
            this.txtPathRegs.Name = "txtPathRegs";
            this.txtPathRegs.Size = new System.Drawing.Size(299, 20);
            this.txtPathRegs.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(809, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(370, 433);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 30);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtMinRegs
            // 
            this.txtMinRegs.Location = new System.Drawing.Point(301, 20);
            this.txtMinRegs.MaxLength = 2;
            this.txtMinRegs.Name = "txtMinRegs";
            this.txtMinRegs.Size = new System.Drawing.Size(38, 20);
            this.txtMinRegs.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chckActivaHora);
            this.groupBox1.Controls.Add(this.chckActivaReg);
            this.groupBox1.Controls.Add(this.txtMinHs);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMinRegs);
            this.groupBox1.Location = new System.Drawing.Point(12, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 78);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Automatizacion Rutinas";
            // 
            // chckActivaHora
            // 
            this.chckActivaHora.AutoSize = true;
            this.chckActivaHora.Location = new System.Drawing.Point(21, 51);
            this.chckActivaHora.Name = "chckActivaHora";
            this.chckActivaHora.Size = new System.Drawing.Size(56, 17);
            this.chckActivaHora.TabIndex = 11;
            this.chckActivaHora.Text = "Activa";
            this.chckActivaHora.UseVisualStyleBackColor = true;
            // 
            // chckActivaReg
            // 
            this.chckActivaReg.AutoSize = true;
            this.chckActivaReg.Location = new System.Drawing.Point(21, 20);
            this.chckActivaReg.Name = "chckActivaReg";
            this.chckActivaReg.Size = new System.Drawing.Size(56, 17);
            this.chckActivaReg.TabIndex = 10;
            this.chckActivaReg.Text = "Activa";
            this.chckActivaReg.UseVisualStyleBackColor = true;
            this.chckActivaReg.CheckedChanged += new System.EventHandler(this.chckActivaReg_CheckedChanged);
            // 
            // txtMinHs
            // 
            this.txtMinHs.Location = new System.Drawing.Point(318, 49);
            this.txtMinHs.Name = "txtMinHs";
            this.txtMinHs.Size = new System.Drawing.Size(38, 20);
            this.txtMinHs.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ejecutar rutina de sincronización de hora cada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "minutos.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "minutos.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ejecutar rutina de bajada de registros cada:";
            // 
            // groupFtp
            // 
            this.groupFtp.Controls.Add(this.txtPathFtp);
            this.groupFtp.Controls.Add(this.label11);
            this.groupFtp.Controls.Add(this.txtContraseña);
            this.groupFtp.Controls.Add(this.label10);
            this.groupFtp.Controls.Add(this.txtUsuario);
            this.groupFtp.Controls.Add(this.label9);
            this.groupFtp.Controls.Add(this.txtPuerto);
            this.groupFtp.Controls.Add(this.label8);
            this.groupFtp.Controls.Add(this.txtServidor);
            this.groupFtp.Controls.Add(this.label7);
            this.groupFtp.Enabled = false;
            this.groupFtp.Location = new System.Drawing.Point(471, 62);
            this.groupFtp.Name = "groupFtp";
            this.groupFtp.Size = new System.Drawing.Size(392, 139);
            this.groupFtp.TabIndex = 5;
            this.groupFtp.TabStop = false;
            this.groupFtp.Text = "FTP";
            // 
            // chckActivarFtp
            // 
            this.chckActivarFtp.AutoSize = true;
            this.chckActivarFtp.Location = new System.Drawing.Point(471, 43);
            this.chckActivarFtp.Name = "chckActivarFtp";
            this.chckActivarFtp.Size = new System.Drawing.Size(59, 17);
            this.chckActivarFtp.TabIndex = 0;
            this.chckActivarFtp.Text = "Activar";
            this.chckActivarFtp.UseVisualStyleBackColor = true;
            this.chckActivarFtp.CheckedChanged += new System.EventHandler(this.chckActivarFtp_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Servidor:";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(88, 37);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(150, 20);
            this.txtServidor.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(256, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Puerto:";
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(303, 37);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(61, 20);
            this.txtPuerto.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(75, 73);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(114, 20);
            this.txtUsuario.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(195, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Contraseña:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(259, 73);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(117, 20);
            this.txtContraseña.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Path de subida:";
            // 
            // txtPathFtp
            // 
            this.txtPathFtp.Location = new System.Drawing.Point(94, 113);
            this.txtPathFtp.Name = "txtPathFtp";
            this.txtPathFtp.Size = new System.Drawing.Size(282, 20);
            this.txtPathFtp.TabIndex = 10;
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 550);
            this.Controls.Add(this.groupFtp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupArchivos);
            this.Controls.Add(this.chckActivarFtp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Configuracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion";
            this.groupArchivos.ResumeLayout(false);
            this.groupArchivos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupFtp.ResumeLayout(false);
            this.groupFtp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupArchivos;
        private System.Windows.Forms.TextBox txtPathLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPathRegs;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtMinRegs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMinHs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chckActivaHora;
        private System.Windows.Forms.CheckBox chckActivaReg;
        private System.Windows.Forms.GroupBox groupFtp;
        private System.Windows.Forms.TextBox txtPathFtp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chckActivarFtp;
    }
}