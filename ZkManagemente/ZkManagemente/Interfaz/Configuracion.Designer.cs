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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPathRegs = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtMinRegs = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chckActivarHorarios = new System.Windows.Forms.CheckBox();
            this.txtHSHasta = new System.Windows.Forms.TextBox();
            this.txtHSDesde = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chckActivaHora = new System.Windows.Forms.CheckBox();
            this.chckActivaReg = new System.Windows.Forms.CheckBox();
            this.txtMinHs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupFtp = new System.Windows.Forms.GroupBox();
            this.txtPathFtp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chckActivarFtp = new System.Windows.Forms.CheckBox();
            this.groupArchivos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupFtp.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupArchivos
            // 
            this.groupArchivos.Controls.Add(this.label1);
            this.groupArchivos.Controls.Add(this.txtPathRegs);
            this.groupArchivos.Location = new System.Drawing.Point(12, 110);
            this.groupArchivos.Name = "groupArchivos";
            this.groupArchivos.Size = new System.Drawing.Size(429, 52);
            this.groupArchivos.TabIndex = 0;
            this.groupArchivos.TabStop = false;
            this.groupArchivos.Text = "Archivo de Registros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Archivo registros: ";
            // 
            // txtPathRegs
            // 
            this.txtPathRegs.Location = new System.Drawing.Point(104, 21);
            this.txtPathRegs.Name = "txtPathRegs";
            this.txtPathRegs.Size = new System.Drawing.Size(299, 22);
            this.txtPathRegs.TabIndex = 0;
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
            this.txtMinRegs.Enabled = false;
            this.txtMinRegs.Location = new System.Drawing.Point(315, 18);
            this.txtMinRegs.MaxLength = 2;
            this.txtMinRegs.Name = "txtMinRegs";
            this.txtMinRegs.Size = new System.Drawing.Size(38, 22);
            this.txtMinRegs.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chckActivarHorarios);
            this.groupBox1.Controls.Add(this.txtHSHasta);
            this.groupBox1.Controls.Add(this.txtHSDesde);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chckActivaHora);
            this.groupBox1.Controls.Add(this.chckActivaReg);
            this.groupBox1.Controls.Add(this.txtMinHs);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMinRegs);
            this.groupBox1.Location = new System.Drawing.Point(12, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 130);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Automatizacion Rutinas";
            // 
            // chckActivarHorarios
            // 
            this.chckActivarHorarios.AutoSize = true;
            this.chckActivarHorarios.Location = new System.Drawing.Point(21, 50);
            this.chckActivarHorarios.Name = "chckActivarHorarios";
            this.chckActivarHorarios.Size = new System.Drawing.Size(60, 17);
            this.chckActivarHorarios.TabIndex = 16;
            this.chckActivarHorarios.Text = "Activar";
            this.chckActivarHorarios.UseVisualStyleBackColor = true;
            this.chckActivarHorarios.CheckedChanged += new System.EventHandler(this.chckActivarHorarios_CheckedChanged);
            // 
            // txtHSHasta
            // 
            this.txtHSHasta.Enabled = false;
            this.txtHSHasta.Location = new System.Drawing.Point(288, 48);
            this.txtHSHasta.Name = "txtHSHasta";
            this.txtHSHasta.Size = new System.Drawing.Size(43, 22);
            this.txtHSHasta.TabIndex = 15;
            // 
            // txtHSDesde
            // 
            this.txtHSDesde.Enabled = false;
            this.txtHSDesde.Location = new System.Drawing.Point(171, 48);
            this.txtHSDesde.Name = "txtHSDesde";
            this.txtHSDesde.Size = new System.Drawing.Size(43, 22);
            this.txtHSDesde.TabIndex = 14;
            this.txtHSDesde.Tag = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(223, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "y hasta las:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "A partir de las:";
            // 
            // chckActivaHora
            // 
            this.chckActivaHora.AutoSize = true;
            this.chckActivaHora.Location = new System.Drawing.Point(21, 103);
            this.chckActivaHora.Name = "chckActivaHora";
            this.chckActivaHora.Size = new System.Drawing.Size(56, 17);
            this.chckActivaHora.TabIndex = 11;
            this.chckActivaHora.Text = "Activa";
            this.chckActivaHora.UseVisualStyleBackColor = true;
            this.chckActivaHora.CheckedChanged += new System.EventHandler(this.chckActivaHora_CheckedChanged);
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
            this.txtMinHs.Enabled = false;
            this.txtMinHs.Location = new System.Drawing.Point(334, 101);
            this.txtMinHs.Name = "txtMinHs";
            this.txtMinHs.Size = new System.Drawing.Size(38, 22);
            this.txtMinHs.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ejecutar rutina de sincronización de hora cada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "minutos.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "minutos.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 13);
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
            this.groupFtp.Location = new System.Drawing.Point(471, 110);
            this.groupFtp.Name = "groupFtp";
            this.groupFtp.Size = new System.Drawing.Size(392, 139);
            this.groupFtp.TabIndex = 5;
            this.groupFtp.TabStop = false;
            this.groupFtp.Text = "FTP";
            // 
            // txtPathFtp
            // 
            this.txtPathFtp.Location = new System.Drawing.Point(94, 113);
            this.txtPathFtp.Name = "txtPathFtp";
            this.txtPathFtp.Size = new System.Drawing.Size(282, 22);
            this.txtPathFtp.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Path de subida:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(259, 73);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(117, 22);
            this.txtContraseña.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(195, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(75, 73);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(114, 22);
            this.txtUsuario.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Usuario:";
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(303, 37);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(61, 22);
            this.txtPuerto.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(256, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Puerto:";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(88, 37);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(150, 22);
            this.txtServidor.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Servidor:";
            // 
            // chckActivarFtp
            // 
            this.chckActivarFtp.AutoSize = true;
            this.chckActivarFtp.Location = new System.Drawing.Point(641, 87);
            this.chckActivarFtp.Name = "chckActivarFtp";
            this.chckActivarFtp.Size = new System.Drawing.Size(60, 17);
            this.chckActivarFtp.TabIndex = 0;
            this.chckActivarFtp.Text = "Activar";
            this.chckActivarFtp.UseVisualStyleBackColor = true;
            this.chckActivarFtp.CheckedChanged += new System.EventHandler(this.chckActivarFtp_CheckedChanged);
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 550);
            this.Controls.Add(this.groupFtp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupArchivos);
            this.Controls.Add(this.chckActivarFtp);
            this.Name = "Configuracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.Configuracion_Load);
            this.Controls.SetChildIndex(this.btnCerrar, 0);
            this.Controls.SetChildIndex(this.chckActivarFtp, 0);
            this.Controls.SetChildIndex(this.groupArchivos, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupFtp, 0);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPathRegs;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtHSHasta;
        private System.Windows.Forms.TextBox txtHSDesde;
        private System.Windows.Forms.CheckBox chckActivarHorarios;
    }
}