namespace ZkManagement.NewUI
{
    partial class EditEmpleado
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtTarjeta = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtDni = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtLegajo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtPin = new MetroFramework.Controls.MetroTextBox();
            this.cbPrivilegio = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtApellido = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(432, 404);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(72, 404);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(51, 94);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Nombre:";
            this.metroLabel1.UseStyleColors = true;
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(119, 94);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(211, 23);
            this.txtNombre.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.TabIndex = 3;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.UseStyleColors = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(61, 227);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Tarjeta:";
            this.metroLabel2.UseStyleColors = true;
            // 
            // txtTarjeta
            // 
            // 
            // 
            // 
            this.txtTarjeta.CustomButton.Image = null;
            this.txtTarjeta.CustomButton.Location = new System.Drawing.Point(81, 1);
            this.txtTarjeta.CustomButton.Name = "";
            this.txtTarjeta.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTarjeta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTarjeta.CustomButton.TabIndex = 1;
            this.txtTarjeta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTarjeta.CustomButton.UseSelectable = true;
            this.txtTarjeta.CustomButton.Visible = false;
            this.txtTarjeta.Lines = new string[0];
            this.txtTarjeta.Location = new System.Drawing.Point(119, 223);
            this.txtTarjeta.MaxLength = 10;
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.PasswordChar = '\0';
            this.txtTarjeta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTarjeta.SelectedText = "";
            this.txtTarjeta.SelectionLength = 0;
            this.txtTarjeta.SelectionStart = 0;
            this.txtTarjeta.ShortcutsEnabled = true;
            this.txtTarjeta.Size = new System.Drawing.Size(103, 23);
            this.txtTarjeta.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTarjeta.TabIndex = 5;
            this.txtTarjeta.UseSelectable = true;
            this.txtTarjeta.UseStyleColors = true;
            this.txtTarjeta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTarjeta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(79, 161);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(34, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "DNI:";
            this.metroLabel3.UseStyleColors = true;
            // 
            // txtDni
            // 
            // 
            // 
            // 
            this.txtDni.CustomButton.Image = null;
            this.txtDni.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtDni.CustomButton.Name = "";
            this.txtDni.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDni.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDni.CustomButton.TabIndex = 1;
            this.txtDni.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDni.CustomButton.UseSelectable = true;
            this.txtDni.CustomButton.Visible = false;
            this.txtDni.Lines = new string[0];
            this.txtDni.Location = new System.Drawing.Point(119, 161);
            this.txtDni.MaxLength = 12;
            this.txtDni.Name = "txtDni";
            this.txtDni.PasswordChar = '\0';
            this.txtDni.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDni.SelectedText = "";
            this.txtDni.SelectionLength = 0;
            this.txtDni.SelectionStart = 0;
            this.txtDni.ShortcutsEnabled = true;
            this.txtDni.Size = new System.Drawing.Size(125, 23);
            this.txtDni.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDni.TabIndex = 7;
            this.txtDni.UseSelectable = true;
            this.txtDni.UseStyleColors = true;
            this.txtDni.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDni.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(375, 161);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(51, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Legajo:";
            this.metroLabel4.UseStyleColors = true;
            // 
            // txtLegajo
            // 
            // 
            // 
            // 
            this.txtLegajo.CustomButton.Image = null;
            this.txtLegajo.CustomButton.Location = new System.Drawing.Point(81, 1);
            this.txtLegajo.CustomButton.Name = "";
            this.txtLegajo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLegajo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLegajo.CustomButton.TabIndex = 1;
            this.txtLegajo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLegajo.CustomButton.UseSelectable = true;
            this.txtLegajo.CustomButton.Visible = false;
            this.txtLegajo.Lines = new string[0];
            this.txtLegajo.Location = new System.Drawing.Point(432, 157);
            this.txtLegajo.MaxLength = 50;
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.PasswordChar = '\0';
            this.txtLegajo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLegajo.SelectedText = "";
            this.txtLegajo.SelectionLength = 0;
            this.txtLegajo.SelectionStart = 0;
            this.txtLegajo.ShortcutsEnabled = true;
            this.txtLegajo.Size = new System.Drawing.Size(103, 23);
            this.txtLegajo.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLegajo.TabIndex = 9;
            this.txtLegajo.UseSelectable = true;
            this.txtLegajo.UseStyleColors = true;
            this.txtLegajo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLegajo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(396, 283);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(30, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Pin:";
            this.metroLabel5.UseStyleColors = true;
            // 
            // txtPin
            // 
            // 
            // 
            // 
            this.txtPin.CustomButton.Image = null;
            this.txtPin.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtPin.CustomButton.Name = "";
            this.txtPin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPin.CustomButton.TabIndex = 1;
            this.txtPin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPin.CustomButton.UseSelectable = true;
            this.txtPin.CustomButton.Visible = false;
            this.txtPin.Lines = new string[0];
            this.txtPin.Location = new System.Drawing.Point(432, 283);
            this.txtPin.MaxLength = 6;
            this.txtPin.Name = "txtPin";
            this.txtPin.PasswordChar = '\0';
            this.txtPin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPin.SelectedText = "";
            this.txtPin.SelectionLength = 0;
            this.txtPin.SelectionStart = 0;
            this.txtPin.ShortcutsEnabled = true;
            this.txtPin.Size = new System.Drawing.Size(75, 23);
            this.txtPin.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPin.TabIndex = 11;
            this.txtPin.UseSelectable = true;
            this.txtPin.UseStyleColors = true;
            this.txtPin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbPrivilegio
            // 
            this.cbPrivilegio.FormattingEnabled = true;
            this.cbPrivilegio.ItemHeight = 23;
            this.cbPrivilegio.Items.AddRange(new object[] {
            "Usuario",
            "Administrador"});
            this.cbPrivilegio.Location = new System.Drawing.Point(432, 223);
            this.cbPrivilegio.Name = "cbPrivilegio";
            this.cbPrivilegio.Size = new System.Drawing.Size(135, 29);
            this.cbPrivilegio.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbPrivilegio.TabIndex = 12;
            this.cbPrivilegio.UseSelectable = true;
            this.cbPrivilegio.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(360, 229);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(66, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "Privilegio:";
            this.metroLabel6.UseStyleColors = true;
            // 
            // txtApellido
            // 
            // 
            // 
            // 
            this.txtApellido.CustomButton.Image = null;
            this.txtApellido.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.txtApellido.CustomButton.Name = "";
            this.txtApellido.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtApellido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApellido.CustomButton.TabIndex = 1;
            this.txtApellido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApellido.CustomButton.UseSelectable = true;
            this.txtApellido.CustomButton.Visible = false;
            this.txtApellido.Lines = new string[0];
            this.txtApellido.Location = new System.Drawing.Point(432, 94);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PasswordChar = '\0';
            this.txtApellido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApellido.SelectedText = "";
            this.txtApellido.SelectionLength = 0;
            this.txtApellido.SelectionStart = 0;
            this.txtApellido.ShortcutsEnabled = true;
            this.txtApellido.Size = new System.Drawing.Size(211, 23);
            this.txtApellido.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApellido.TabIndex = 14;
            this.txtApellido.UseSelectable = true;
            this.txtApellido.UseStyleColors = true;
            this.txtApellido.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtApellido.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(364, 94);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(61, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel7.TabIndex = 15;
            this.metroLabel7.Text = "Apellido:";
            this.metroLabel7.UseStyleColors = true;
            // 
            // EditEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 550);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.cbPrivilegio);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtTarjeta);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.metroLabel1);
            this.Name = "EditEmpleado";
            this.Text = "Empleados";
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.metroLabel1, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.metroLabel2, 0);
            this.Controls.SetChildIndex(this.txtTarjeta, 0);
            this.Controls.SetChildIndex(this.metroLabel3, 0);
            this.Controls.SetChildIndex(this.txtDni, 0);
            this.Controls.SetChildIndex(this.metroLabel4, 0);
            this.Controls.SetChildIndex(this.txtLegajo, 0);
            this.Controls.SetChildIndex(this.metroLabel5, 0);
            this.Controls.SetChildIndex(this.txtPin, 0);
            this.Controls.SetChildIndex(this.cbPrivilegio, 0);
            this.Controls.SetChildIndex(this.metroLabel6, 0);
            this.Controls.SetChildIndex(this.txtApellido, 0);
            this.Controls.SetChildIndex(this.metroLabel7, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtTarjeta;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtDni;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtLegajo;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtPin;
        private MetroFramework.Controls.MetroComboBox cbPrivilegio;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtApellido;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}