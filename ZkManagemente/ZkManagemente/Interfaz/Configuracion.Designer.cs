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
            this.txtMinHs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chckActivaReg = new System.Windows.Forms.CheckBox();
            this.chckActivaHora = new System.Windows.Forms.CheckBox();
            this.groupArchivos.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.groupArchivos.Size = new System.Drawing.Size(425, 80);
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
            this.txtMinRegs.Location = new System.Drawing.Point(310, 20);
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
            this.groupBox1.Size = new System.Drawing.Size(425, 78);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Automatizacion Rutinas";
            // 
            // txtMinHs
            // 
            this.txtMinHs.Location = new System.Drawing.Point(326, 49);
            this.txtMinHs.Name = "txtMinHs";
            this.txtMinHs.Size = new System.Drawing.Size(38, 20);
            this.txtMinHs.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ejecutar rutina de sincronización de hora cada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(373, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "minutos.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "minutos.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ejecutar rutina de bajada de registros cada:";
            // 
            // chckActivaReg
            // 
            this.chckActivaReg.AutoSize = true;
            this.chckActivaReg.Location = new System.Drawing.Point(30, 21);
            this.chckActivaReg.Name = "chckActivaReg";
            this.chckActivaReg.Size = new System.Drawing.Size(56, 17);
            this.chckActivaReg.TabIndex = 10;
            this.chckActivaReg.Text = "Activa";
            this.chckActivaReg.UseVisualStyleBackColor = true;
            // 
            // chckActivaHora
            // 
            this.chckActivaHora.AutoSize = true;
            this.chckActivaHora.Location = new System.Drawing.Point(30, 51);
            this.chckActivaHora.Name = "chckActivaHora";
            this.chckActivaHora.Size = new System.Drawing.Size(56, 17);
            this.chckActivaHora.TabIndex = 11;
            this.chckActivaHora.Text = "Activa";
            this.chckActivaHora.UseVisualStyleBackColor = true;
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 550);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupArchivos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Configuracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion";
            this.groupArchivos.ResumeLayout(false);
            this.groupArchivos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}