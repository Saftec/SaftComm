namespace ZkManagement.NewUI.PanelesConfigs
{
    partial class PanelFichadas
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
            this.chckEjecutarRutina = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroDateTime3 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroCheckBox3 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox2 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cbFormatos = new MetroFramework.Controls.MetroComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chckFicheroCopia = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // chckEjecutarRutina
            // 
            this.chckEjecutarRutina.AutoSize = true;
            this.chckEjecutarRutina.Location = new System.Drawing.Point(76, 186);
            this.chckEjecutarRutina.Name = "chckEjecutarRutina";
            this.chckEjecutarRutina.Size = new System.Drawing.Size(165, 15);
            this.chckEjecutarRutina.TabIndex = 3;
            this.chckEjecutarRutina.Text = "Ejecutar Rutinas en esta PC";
            this.chckEjecutarRutina.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.metroDateTime3);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroDateTime2);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroDateTime1);
            this.groupBox1.Controls.Add(this.metroCheckBox3);
            this.groupBox1.Controls.Add(this.metroCheckBox2);
            this.groupBox1.Controls.Add(this.metroCheckBox1);
            this.groupBox1.Location = new System.Drawing.Point(76, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 283);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rutinas";
            // 
            // metroDateTime3
            // 
            this.metroDateTime3.CustomFormat = "hh:MM";
            this.metroDateTime3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.metroDateTime3.Location = new System.Drawing.Point(279, 175);
            this.metroDateTime3.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime3.Name = "metroDateTime3";
            this.metroDateTime3.Size = new System.Drawing.Size(82, 29);
            this.metroDateTime3.TabIndex = 9;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(109, 218);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(155, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Hora de fin de ejecucion:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(109, 181);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(152, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Hora de inicio ejecucion:";
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.CustomFormat = "hh:MM";
            this.metroDateTime2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.metroDateTime2.Location = new System.Drawing.Point(279, 214);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.Size = new System.Drawing.Size(82, 29);
            this.metroDateTime2.TabIndex = 6;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(109, 110);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(239, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Ejecutar la sincronización de hora cada:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(109, 47);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(221, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Ejecutar la bajada de registros cada:";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.CustomFormat = "hh:MM";
            this.metroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.metroDateTime1.Location = new System.Drawing.Point(339, 41);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(82, 29);
            this.metroDateTime1.TabIndex = 3;
            // 
            // metroCheckBox3
            // 
            this.metroCheckBox3.AutoSize = true;
            this.metroCheckBox3.Location = new System.Drawing.Point(35, 204);
            this.metroCheckBox3.Name = "metroCheckBox3";
            this.metroCheckBox3.Size = new System.Drawing.Size(60, 15);
            this.metroCheckBox3.TabIndex = 2;
            this.metroCheckBox3.Text = "Activar";
            this.metroCheckBox3.UseSelectable = true;
            // 
            // metroCheckBox2
            // 
            this.metroCheckBox2.AutoSize = true;
            this.metroCheckBox2.Location = new System.Drawing.Point(35, 114);
            this.metroCheckBox2.Name = "metroCheckBox2";
            this.metroCheckBox2.Size = new System.Drawing.Size(60, 15);
            this.metroCheckBox2.TabIndex = 1;
            this.metroCheckBox2.Text = "Activar";
            this.metroCheckBox2.UseSelectable = true;
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(35, 51);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(60, 15);
            this.metroCheckBox1.TabIndex = 0;
            this.metroCheckBox1.Text = "Activar";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(8, 39);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(177, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Formato de descarga activo:";
            // 
            // cbFormatos
            // 
            this.cbFormatos.FormattingEnabled = true;
            this.cbFormatos.ItemHeight = 23;
            this.cbFormatos.Location = new System.Drawing.Point(191, 33);
            this.cbFormatos.Name = "cbFormatos";
            this.cbFormatos.Size = new System.Drawing.Size(154, 29);
            this.cbFormatos.TabIndex = 11;
            this.cbFormatos.UseSelectable = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.cbFormatos);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Location = new System.Drawing.Point(76, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 92);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Formato";
            // 
            // chckFicheroCopia
            // 
            this.chckFicheroCopia.AutoSize = true;
            this.chckFicheroCopia.Location = new System.Drawing.Point(76, 45);
            this.chckFicheroCopia.Name = "chckFicheroCopia";
            this.chckFicheroCopia.Size = new System.Drawing.Size(219, 15);
            this.chckFicheroCopia.TabIndex = 13;
            this.chckFicheroCopia.Text = "Descargar fichadas a fichero de copia";
            this.chckFicheroCopia.UseSelectable = true;
            // 
            // PanelFichadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chckFicheroCopia);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chckEjecutarRutina);
            this.Name = "PanelFichadas";
            this.Controls.SetChildIndex(this.chckEjecutarRutina, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.chckFicheroCopia, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox chckEjecutarRutina;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox3;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox2;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime metroDateTime3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cbFormatos;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroCheckBox chckFicheroCopia;
    }
}
