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
            this.groupRutinas = new System.Windows.Forms.GroupBox();
            this.chckBorrarRegs = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtHoraFin = new MetroFramework.Controls.MetroTextBox();
            this.txtHoraInicio = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtMinutosHora = new MetroFramework.Controls.MetroTextBox();
            this.txtMinutosRegs = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.chckActivarHorario = new MetroFramework.Controls.MetroCheckBox();
            this.chckActivarHora = new MetroFramework.Controls.MetroCheckBox();
            this.chckActivarRegs = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cbFormatos = new MetroFramework.Controls.MetroComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chckFicheroCopia = new MetroFramework.Controls.MetroCheckBox();
            this.groupRutinas.SuspendLayout();
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
            this.chckEjecutarRutina.Style = MetroFramework.MetroColorStyle.Blue;
            this.chckEjecutarRutina.TabIndex = 3;
            this.chckEjecutarRutina.Text = "Ejecutar Rutinas en esta PC";
            this.chckEjecutarRutina.UseSelectable = true;
            this.chckEjecutarRutina.UseStyleColors = true;
            this.chckEjecutarRutina.CheckedChanged += new System.EventHandler(this.chckEjecutarRutina_CheckedChanged);
            // 
            // groupRutinas
            // 
            this.groupRutinas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupRutinas.Controls.Add(this.chckBorrarRegs);
            this.groupRutinas.Controls.Add(this.metroLabel9);
            this.groupRutinas.Controls.Add(this.metroLabel8);
            this.groupRutinas.Controls.Add(this.txtHoraFin);
            this.groupRutinas.Controls.Add(this.txtHoraInicio);
            this.groupRutinas.Controls.Add(this.metroLabel7);
            this.groupRutinas.Controls.Add(this.metroLabel6);
            this.groupRutinas.Controls.Add(this.txtMinutosHora);
            this.groupRutinas.Controls.Add(this.txtMinutosRegs);
            this.groupRutinas.Controls.Add(this.metroLabel4);
            this.groupRutinas.Controls.Add(this.metroLabel3);
            this.groupRutinas.Controls.Add(this.metroLabel2);
            this.groupRutinas.Controls.Add(this.metroLabel1);
            this.groupRutinas.Controls.Add(this.chckActivarHorario);
            this.groupRutinas.Controls.Add(this.chckActivarHora);
            this.groupRutinas.Controls.Add(this.chckActivarRegs);
            this.groupRutinas.Enabled = false;
            this.groupRutinas.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupRutinas.Location = new System.Drawing.Point(76, 207);
            this.groupRutinas.Name = "groupRutinas";
            this.groupRutinas.Size = new System.Drawing.Size(531, 315);
            this.groupRutinas.TabIndex = 4;
            this.groupRutinas.TabStop = false;
            this.groupRutinas.Text = "Rutinas";
            // 
            // chckBorrarRegs
            // 
            this.chckBorrarRegs.AutoSize = true;
            this.chckBorrarRegs.Location = new System.Drawing.Point(148, 19);
            this.chckBorrarRegs.Name = "chckBorrarRegs";
            this.chckBorrarRegs.Size = new System.Drawing.Size(206, 15);
            this.chckBorrarRegs.Style = MetroFramework.MetroColorStyle.Blue;
            this.chckBorrarRegs.TabIndex = 18;
            this.chckBorrarRegs.Text = "Borrar registros luego de descargar";
            this.chckBorrarRegs.UseSelectable = true;
            this.chckBorrarRegs.UseStyleColors = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel9.Location = new System.Drawing.Point(279, 244);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(42, 15);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel9.TabIndex = 17;
            this.metroLabel9.Text = "hh:mm";
            this.metroLabel9.UseStyleColors = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel8.Location = new System.Drawing.Point(279, 197);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(42, 15);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel8.TabIndex = 16;
            this.metroLabel8.Text = "hh:mm";
            this.metroLabel8.UseStyleColors = true;
            // 
            // txtHoraFin
            // 
            // 
            // 
            // 
            this.txtHoraFin.CustomButton.Image = null;
            this.txtHoraFin.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtHoraFin.CustomButton.Name = "";
            this.txtHoraFin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHoraFin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHoraFin.CustomButton.TabIndex = 1;
            this.txtHoraFin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHoraFin.CustomButton.UseSelectable = true;
            this.txtHoraFin.CustomButton.Visible = false;
            this.txtHoraFin.Enabled = false;
            this.txtHoraFin.Lines = new string[0];
            this.txtHoraFin.Location = new System.Drawing.Point(267, 218);
            this.txtHoraFin.MaxLength = 5;
            this.txtHoraFin.Name = "txtHoraFin";
            this.txtHoraFin.PasswordChar = '\0';
            this.txtHoraFin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHoraFin.SelectedText = "";
            this.txtHoraFin.SelectionLength = 0;
            this.txtHoraFin.SelectionStart = 0;
            this.txtHoraFin.ShortcutsEnabled = true;
            this.txtHoraFin.Size = new System.Drawing.Size(75, 23);
            this.txtHoraFin.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHoraFin.TabIndex = 15;
            this.txtHoraFin.UseSelectable = true;
            this.txtHoraFin.UseStyleColors = true;
            this.txtHoraFin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHoraFin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtHoraInicio
            // 
            // 
            // 
            // 
            this.txtHoraInicio.CustomButton.Image = null;
            this.txtHoraInicio.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtHoraInicio.CustomButton.Name = "";
            this.txtHoraInicio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHoraInicio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHoraInicio.CustomButton.TabIndex = 1;
            this.txtHoraInicio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHoraInicio.CustomButton.UseSelectable = true;
            this.txtHoraInicio.CustomButton.Visible = false;
            this.txtHoraInicio.Enabled = false;
            this.txtHoraInicio.Lines = new string[0];
            this.txtHoraInicio.Location = new System.Drawing.Point(267, 171);
            this.txtHoraInicio.MaxLength = 5;
            this.txtHoraInicio.Name = "txtHoraInicio";
            this.txtHoraInicio.PasswordChar = '\0';
            this.txtHoraInicio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHoraInicio.SelectedText = "";
            this.txtHoraInicio.SelectionLength = 0;
            this.txtHoraInicio.SelectionStart = 0;
            this.txtHoraInicio.ShortcutsEnabled = true;
            this.txtHoraInicio.Size = new System.Drawing.Size(75, 23);
            this.txtHoraInicio.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHoraInicio.TabIndex = 14;
            this.txtHoraInicio.UseSelectable = true;
            this.txtHoraInicio.UseStyleColors = true;
            this.txtHoraInicio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHoraInicio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(438, 110);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(58, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel7.TabIndex = 13;
            this.metroLabel7.Text = "minutos.";
            this.metroLabel7.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(417, 55);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(58, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "minutos.";
            this.metroLabel6.UseStyleColors = true;
            // 
            // txtMinutosHora
            // 
            // 
            // 
            // 
            this.txtMinutosHora.CustomButton.Image = null;
            this.txtMinutosHora.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtMinutosHora.CustomButton.Name = "";
            this.txtMinutosHora.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMinutosHora.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMinutosHora.CustomButton.TabIndex = 1;
            this.txtMinutosHora.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMinutosHora.CustomButton.UseSelectable = true;
            this.txtMinutosHora.CustomButton.Visible = false;
            this.txtMinutosHora.Enabled = false;
            this.txtMinutosHora.Lines = new string[0];
            this.txtMinutosHora.Location = new System.Drawing.Point(354, 110);
            this.txtMinutosHora.MaxLength = 3;
            this.txtMinutosHora.Name = "txtMinutosHora";
            this.txtMinutosHora.PasswordChar = '\0';
            this.txtMinutosHora.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMinutosHora.SelectedText = "";
            this.txtMinutosHora.SelectionLength = 0;
            this.txtMinutosHora.SelectionStart = 0;
            this.txtMinutosHora.ShortcutsEnabled = true;
            this.txtMinutosHora.Size = new System.Drawing.Size(75, 23);
            this.txtMinutosHora.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMinutosHora.TabIndex = 11;
            this.txtMinutosHora.UseSelectable = true;
            this.txtMinutosHora.UseStyleColors = true;
            this.txtMinutosHora.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMinutosHora.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMinutosRegs
            // 
            // 
            // 
            // 
            this.txtMinutosRegs.CustomButton.Image = null;
            this.txtMinutosRegs.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtMinutosRegs.CustomButton.Name = "";
            this.txtMinutosRegs.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMinutosRegs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMinutosRegs.CustomButton.TabIndex = 1;
            this.txtMinutosRegs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMinutosRegs.CustomButton.UseSelectable = true;
            this.txtMinutosRegs.CustomButton.Visible = false;
            this.txtMinutosRegs.Enabled = false;
            this.txtMinutosRegs.Lines = new string[0];
            this.txtMinutosRegs.Location = new System.Drawing.Point(336, 55);
            this.txtMinutosRegs.MaxLength = 3;
            this.txtMinutosRegs.Name = "txtMinutosRegs";
            this.txtMinutosRegs.PasswordChar = '\0';
            this.txtMinutosRegs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMinutosRegs.SelectedText = "";
            this.txtMinutosRegs.SelectionLength = 0;
            this.txtMinutosRegs.SelectionStart = 0;
            this.txtMinutosRegs.ShortcutsEnabled = true;
            this.txtMinutosRegs.Size = new System.Drawing.Size(75, 23);
            this.txtMinutosRegs.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMinutosRegs.TabIndex = 10;
            this.txtMinutosRegs.UseSelectable = true;
            this.txtMinutosRegs.UseStyleColors = true;
            this.txtMinutosRegs.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMinutosRegs.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(109, 218);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(155, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Hora de fin de ejecucion:";
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(109, 171);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(152, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Hora de inicio ejecucion:";
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(109, 110);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(239, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Ejecutar la sincronización de hora cada:";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(109, 55);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(221, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Ejecutar la bajada de registros cada:";
            this.metroLabel1.UseStyleColors = true;
            // 
            // chckActivarHorario
            // 
            this.chckActivarHorario.AutoSize = true;
            this.chckActivarHorario.Location = new System.Drawing.Point(35, 198);
            this.chckActivarHorario.Name = "chckActivarHorario";
            this.chckActivarHorario.Size = new System.Drawing.Size(60, 15);
            this.chckActivarHorario.Style = MetroFramework.MetroColorStyle.Blue;
            this.chckActivarHorario.TabIndex = 2;
            this.chckActivarHorario.Text = "Activar";
            this.chckActivarHorario.UseSelectable = true;
            this.chckActivarHorario.UseStyleColors = true;
            this.chckActivarHorario.CheckedChanged += new System.EventHandler(this.chckActivarHorario_CheckedChanged);
            // 
            // chckActivarHora
            // 
            this.chckActivarHora.AutoSize = true;
            this.chckActivarHora.Location = new System.Drawing.Point(35, 114);
            this.chckActivarHora.Name = "chckActivarHora";
            this.chckActivarHora.Size = new System.Drawing.Size(60, 15);
            this.chckActivarHora.Style = MetroFramework.MetroColorStyle.Blue;
            this.chckActivarHora.TabIndex = 1;
            this.chckActivarHora.Text = "Activar";
            this.chckActivarHora.UseSelectable = true;
            this.chckActivarHora.UseStyleColors = true;
            this.chckActivarHora.CheckedChanged += new System.EventHandler(this.chckActivarHora_CheckedChanged);
            // 
            // chckActivarRegs
            // 
            this.chckActivarRegs.AutoSize = true;
            this.chckActivarRegs.Location = new System.Drawing.Point(35, 55);
            this.chckActivarRegs.Name = "chckActivarRegs";
            this.chckActivarRegs.Size = new System.Drawing.Size(60, 15);
            this.chckActivarRegs.Style = MetroFramework.MetroColorStyle.Blue;
            this.chckActivarRegs.TabIndex = 0;
            this.chckActivarRegs.Text = "Activar";
            this.chckActivarRegs.UseSelectable = true;
            this.chckActivarRegs.UseStyleColors = true;
            this.chckActivarRegs.CheckedChanged += new System.EventHandler(this.chckActivarRegs_CheckedChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(8, 39);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(177, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Formato de descarga activo:";
            this.metroLabel5.UseStyleColors = true;
            // 
            // cbFormatos
            // 
            this.cbFormatos.FormattingEnabled = true;
            this.cbFormatos.ItemHeight = 23;
            this.cbFormatos.Location = new System.Drawing.Point(191, 33);
            this.cbFormatos.Name = "cbFormatos";
            this.cbFormatos.Size = new System.Drawing.Size(154, 29);
            this.cbFormatos.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbFormatos.TabIndex = 11;
            this.cbFormatos.UseSelectable = true;
            this.cbFormatos.UseStyleColors = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.cbFormatos);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
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
            this.chckFicheroCopia.Size = new System.Drawing.Size(212, 15);
            this.chckFicheroCopia.Style = MetroFramework.MetroColorStyle.Blue;
            this.chckFicheroCopia.TabIndex = 13;
            this.chckFicheroCopia.Text = "Escribir fichadas en fichero de copia";
            this.chckFicheroCopia.UseSelectable = true;
            this.chckFicheroCopia.UseStyleColors = true;
            // 
            // PanelFichadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chckFicheroCopia);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupRutinas);
            this.Controls.Add(this.chckEjecutarRutina);
            this.Name = "PanelFichadas";
            this.Controls.SetChildIndex(this.chckEjecutarRutina, 0);
            this.Controls.SetChildIndex(this.groupRutinas, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.chckFicheroCopia, 0);
            this.groupRutinas.ResumeLayout(false);
            this.groupRutinas.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox chckEjecutarRutina;
        private System.Windows.Forms.GroupBox groupRutinas;
        private MetroFramework.Controls.MetroCheckBox chckActivarHorario;
        private MetroFramework.Controls.MetroCheckBox chckActivarHora;
        private MetroFramework.Controls.MetroCheckBox chckActivarRegs;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cbFormatos;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroCheckBox chckFicheroCopia;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtMinutosHora;
        private MetroFramework.Controls.MetroTextBox txtMinutosRegs;
        private MetroFramework.Controls.MetroTextBox txtHoraFin;
        private MetroFramework.Controls.MetroTextBox txtHoraInicio;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroCheckBox chckBorrarRegs;
    }
}
