namespace ZkManagement.NewUI
{
    partial class EditUsuario
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
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.cbPermisos = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtApellido = new MetroFramework.Controls.MetroTextBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.lblPassword = new MetroFramework.Controls.MetroLabel();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtUsuario
            // 
            // 
            // 
            // 
            this.txtUsuario.CustomButton.Image = null;
            this.txtUsuario.CustomButton.Location = new System.Drawing.Point(215, 1);
            this.txtUsuario.CustomButton.Name = "";
            this.txtUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsuario.CustomButton.TabIndex = 1;
            this.txtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsuario.CustomButton.UseSelectable = true;
            this.txtUsuario.CustomButton.Visible = false;
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(319, 57);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(237, 23);
            this.txtUsuario.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.UseSelectable = true;
            this.txtUsuario.UseStyleColors = true;
            this.txtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbPermisos
            // 
            this.cbPermisos.FormattingEnabled = true;
            this.cbPermisos.ItemHeight = 23;
            this.cbPermisos.Items.AddRange(new object[] {
            "1 - Administrador",
            "2 - Supervisor",
            "3 - Operador"});
            this.cbPermisos.Location = new System.Drawing.Point(328, 354);
            this.cbPermisos.Name = "cbPermisos";
            this.cbPermisos.Size = new System.Drawing.Size(177, 29);
            this.cbPermisos.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbPermisos.TabIndex = 5;
            this.cbPermisos.UseSelectable = true;
            this.cbPermisos.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(253, 364);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Permisos:";
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(257, 57);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(56, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Usuario:";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(251, 192);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(62, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Nombre:";
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(252, 253);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(61, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Apellido:";
            this.metroLabel4.UseStyleColors = true;
            // 
            // txtApellido
            // 
            // 
            // 
            // 
            this.txtApellido.CustomButton.Image = null;
            this.txtApellido.CustomButton.Location = new System.Drawing.Point(215, 1);
            this.txtApellido.CustomButton.Name = "";
            this.txtApellido.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtApellido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApellido.CustomButton.TabIndex = 1;
            this.txtApellido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApellido.CustomButton.UseSelectable = true;
            this.txtApellido.CustomButton.Visible = false;
            this.txtApellido.Lines = new string[0];
            this.txtApellido.Location = new System.Drawing.Point(319, 249);
            this.txtApellido.MaxLength = 32767;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PasswordChar = '\0';
            this.txtApellido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApellido.SelectedText = "";
            this.txtApellido.SelectionLength = 0;
            this.txtApellido.SelectionStart = 0;
            this.txtApellido.ShortcutsEnabled = true;
            this.txtApellido.Size = new System.Drawing.Size(237, 23);
            this.txtApellido.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApellido.TabIndex = 4;
            this.txtApellido.UseSelectable = true;
            this.txtApellido.UseStyleColors = true;
            this.txtApellido.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtApellido.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(215, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(319, 188);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(237, 23);
            this.txtNombre.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.TabIndex = 3;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.UseStyleColors = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(235, 107);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 19);
            this.lblPassword.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Contraseña:";
            this.lblPassword.UseStyleColors = true;
            this.lblPassword.Visible = false;
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(215, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(319, 107);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(237, 23);
            this.txtPassword.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseStyleColors = true;
            this.txtPassword.Visible = false;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // EditUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 581);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cbPermisos);
            this.Controls.Add(this.txtUsuario);
            this.Name = "EditUsuario";
            this.Text = "EditUsuario";
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.txtUsuario, 0);
            this.Controls.SetChildIndex(this.cbPermisos, 0);
            this.Controls.SetChildIndex(this.metroLabel1, 0);
            this.Controls.SetChildIndex(this.metroLabel2, 0);
            this.Controls.SetChildIndex(this.metroLabel3, 0);
            this.Controls.SetChildIndex(this.metroLabel4, 0);
            this.Controls.SetChildIndex(this.txtApellido, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.lblPassword, 0);
            this.Controls.SetChildIndex(this.txtPassword, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtUsuario;
        private MetroFramework.Controls.MetroComboBox cbPermisos;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtApellido;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroLabel lblPassword;
        private MetroFramework.Controls.MetroTextBox txtPassword;
    }
}