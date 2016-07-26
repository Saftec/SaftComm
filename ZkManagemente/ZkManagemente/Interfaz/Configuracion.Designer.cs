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
            this.textPathLog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textPathRegs = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupArchivos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupArchivos
            // 
            this.groupArchivos.Controls.Add(this.textPathLog);
            this.groupArchivos.Controls.Add(this.label2);
            this.groupArchivos.Controls.Add(this.label1);
            this.groupArchivos.Controls.Add(this.textPathRegs);
            this.groupArchivos.Location = new System.Drawing.Point(12, 24);
            this.groupArchivos.Name = "groupArchivos";
            this.groupArchivos.Size = new System.Drawing.Size(425, 80);
            this.groupArchivos.TabIndex = 0;
            this.groupArchivos.TabStop = false;
            this.groupArchivos.Text = "Archivos";
            // 
            // textPathLog
            // 
            this.textPathLog.Location = new System.Drawing.Point(104, 50);
            this.textPathLog.Name = "textPathLog";
            this.textPathLog.Size = new System.Drawing.Size(299, 20);
            this.textPathLog.TabIndex = 3;
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
            // textPathRegs
            // 
            this.textPathRegs.Location = new System.Drawing.Point(104, 16);
            this.textPathRegs.Name = "textPathRegs";
            this.textPathRegs.Size = new System.Drawing.Size(299, 20);
            this.textPathRegs.TabIndex = 0;
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
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 512);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupArchivos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Configuracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion";
            this.groupArchivos.ResumeLayout(false);
            this.groupArchivos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupArchivos;
        private System.Windows.Forms.TextBox textPathLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPathRegs;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnGuardar;
    }
}