namespace ZkManagement.NewUI
{
    partial class EditReloj
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
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtIp = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtNumero = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtPuerto = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtDns = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtClave = new MetroFramework.Controls.MetroTextBox();
            this.chckRutinas = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(135, 60);
            this.txtNombre.MaxLength = 25;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(190, 23);
            this.txtNombre.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.TabIndex = 5;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.UseStyleColors = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(67, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Nombre:";
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(82, 118);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(47, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Dir. IP:";
            this.metroLabel2.UseStyleColors = true;
            // 
            // txtIp
            // 
            // 
            // 
            // 
            this.txtIp.CustomButton.Image = null;
            this.txtIp.CustomButton.Location = new System.Drawing.Point(87, 1);
            this.txtIp.CustomButton.Name = "";
            this.txtIp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIp.CustomButton.TabIndex = 1;
            this.txtIp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIp.CustomButton.UseSelectable = true;
            this.txtIp.CustomButton.Visible = false;
            this.txtIp.Lines = new string[] {
        "192.168.1.70"};
            this.txtIp.Location = new System.Drawing.Point(135, 118);
            this.txtIp.MaxLength = 32767;
            this.txtIp.Name = "txtIp";
            this.txtIp.PasswordChar = '\0';
            this.txtIp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIp.SelectedText = "";
            this.txtIp.SelectionLength = 0;
            this.txtIp.SelectionStart = 0;
            this.txtIp.ShortcutsEnabled = true;
            this.txtIp.Size = new System.Drawing.Size(109, 23);
            this.txtIp.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIp.TabIndex = 7;
            this.txtIp.Text = "192.168.1.70";
            this.txtIp.UseSelectable = true;
            this.txtIp.UseStyleColors = true;
            this.txtIp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(432, 64);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(61, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Número:";
            this.metroLabel3.UseStyleColors = true;
            // 
            // txtNumero
            // 
            // 
            // 
            // 
            this.txtNumero.CustomButton.Image = null;
            this.txtNumero.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtNumero.CustomButton.Name = "";
            this.txtNumero.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNumero.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumero.CustomButton.TabIndex = 1;
            this.txtNumero.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumero.CustomButton.UseSelectable = true;
            this.txtNumero.CustomButton.Visible = false;
            this.txtNumero.Lines = new string[0];
            this.txtNumero.Location = new System.Drawing.Point(517, 60);
            this.txtNumero.MaxLength = 5;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PasswordChar = '\0';
            this.txtNumero.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumero.SelectedText = "";
            this.txtNumero.SelectionLength = 0;
            this.txtNumero.SelectionStart = 0;
            this.txtNumero.ShortcutsEnabled = true;
            this.txtNumero.Size = new System.Drawing.Size(75, 23);
            this.txtNumero.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumero.TabIndex = 9;
            this.txtNumero.UseSelectable = true;
            this.txtNumero.UseStyleColors = true;
            this.txtNumero.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumero.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(442, 118);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(51, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Puerto:";
            this.metroLabel4.UseStyleColors = true;
            // 
            // txtPuerto
            // 
            // 
            // 
            // 
            this.txtPuerto.CustomButton.Image = null;
            this.txtPuerto.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtPuerto.CustomButton.Name = "";
            this.txtPuerto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPuerto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPuerto.CustomButton.TabIndex = 1;
            this.txtPuerto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPuerto.CustomButton.UseSelectable = true;
            this.txtPuerto.CustomButton.Visible = false;
            this.txtPuerto.Lines = new string[] {
        "4370"};
            this.txtPuerto.Location = new System.Drawing.Point(517, 118);
            this.txtPuerto.MaxLength = 8;
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.PasswordChar = '\0';
            this.txtPuerto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPuerto.SelectedText = "";
            this.txtPuerto.SelectionLength = 0;
            this.txtPuerto.SelectionStart = 0;
            this.txtPuerto.ShortcutsEnabled = true;
            this.txtPuerto.Size = new System.Drawing.Size(75, 23);
            this.txtPuerto.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPuerto.TabIndex = 11;
            this.txtPuerto.Text = "4370";
            this.txtPuerto.UseSelectable = true;
            this.txtPuerto.UseStyleColors = true;
            this.txtPuerto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPuerto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(61, 230);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(68, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Host DNS:";
            this.metroLabel5.UseStyleColors = true;
            // 
            // txtDns
            // 
            // 
            // 
            // 
            this.txtDns.CustomButton.Image = null;
            this.txtDns.CustomButton.Location = new System.Drawing.Point(365, 1);
            this.txtDns.CustomButton.Name = "";
            this.txtDns.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDns.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDns.CustomButton.TabIndex = 1;
            this.txtDns.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDns.CustomButton.UseSelectable = true;
            this.txtDns.CustomButton.Visible = false;
            this.txtDns.Lines = new string[0];
            this.txtDns.Location = new System.Drawing.Point(135, 226);
            this.txtDns.MaxLength = 70;
            this.txtDns.Name = "txtDns";
            this.txtDns.PasswordChar = '\0';
            this.txtDns.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDns.SelectedText = "";
            this.txtDns.SelectionLength = 0;
            this.txtDns.SelectionStart = 0;
            this.txtDns.ShortcutsEnabled = true;
            this.txtDns.Size = new System.Drawing.Size(387, 23);
            this.txtDns.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDns.TabIndex = 13;
            this.txtDns.UseSelectable = true;
            this.txtDns.UseStyleColors = true;
            this.txtDns.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDns.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(85, 174);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(44, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel6.TabIndex = 14;
            this.metroLabel6.Text = "Clave:";
            this.metroLabel6.UseStyleColors = true;
            // 
            // txtClave
            // 
            // 
            // 
            // 
            this.txtClave.CustomButton.Image = null;
            this.txtClave.CustomButton.Location = new System.Drawing.Point(87, 1);
            this.txtClave.CustomButton.Name = "";
            this.txtClave.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtClave.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClave.CustomButton.TabIndex = 1;
            this.txtClave.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClave.CustomButton.UseSelectable = true;
            this.txtClave.CustomButton.Visible = false;
            this.txtClave.Lines = new string[0];
            this.txtClave.Location = new System.Drawing.Point(135, 174);
            this.txtClave.MaxLength = 6;
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClave.SelectedText = "";
            this.txtClave.SelectionLength = 0;
            this.txtClave.SelectionStart = 0;
            this.txtClave.ShortcutsEnabled = true;
            this.txtClave.Size = new System.Drawing.Size(109, 23);
            this.txtClave.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClave.TabIndex = 15;
            this.txtClave.UseSelectable = true;
            this.txtClave.UseStyleColors = true;
            this.txtClave.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClave.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chckRutinas
            // 
            this.chckRutinas.AutoSize = true;
            this.chckRutinas.Checked = true;
            this.chckRutinas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckRutinas.Location = new System.Drawing.Point(432, 178);
            this.chckRutinas.Name = "chckRutinas";
            this.chckRutinas.Size = new System.Drawing.Size(171, 15);
            this.chckRutinas.Style = MetroFramework.MetroColorStyle.Blue;
            this.chckRutinas.TabIndex = 16;
            this.chckRutinas.Text = "Agregar a agenda de rutinas";
            this.chckRutinas.UseSelectable = true;
            this.chckRutinas.UseStyleColors = true;
            // 
            // EditReloj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 550);
            this.Controls.Add(this.chckRutinas);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtDns);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.metroLabel1);
            this.Name = "EditReloj";
            this.Text = "EditReloj";
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.metroLabel1, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.metroLabel2, 0);
            this.Controls.SetChildIndex(this.txtIp, 0);
            this.Controls.SetChildIndex(this.metroLabel3, 0);
            this.Controls.SetChildIndex(this.txtNumero, 0);
            this.Controls.SetChildIndex(this.metroLabel4, 0);
            this.Controls.SetChildIndex(this.txtPuerto, 0);
            this.Controls.SetChildIndex(this.metroLabel5, 0);
            this.Controls.SetChildIndex(this.txtDns, 0);
            this.Controls.SetChildIndex(this.metroLabel6, 0);
            this.Controls.SetChildIndex(this.txtClave, 0);
            this.Controls.SetChildIndex(this.chckRutinas, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtIp;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtNumero;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtPuerto;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtDns;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtClave;
        private MetroFramework.Controls.MetroCheckBox chckRutinas;
    }
}