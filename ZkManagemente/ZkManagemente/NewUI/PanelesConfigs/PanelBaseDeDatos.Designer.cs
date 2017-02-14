namespace ZkManagement.NewUI.PanelesConfigs
{
    partial class PanelBaseDeDatos
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
            this.groupSQL = new System.Windows.Forms.GroupBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtPasswordSQL = new MetroFramework.Controls.MetroTextBox();
            this.txtUsuarioSQL = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtBase = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtServer = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupAccess = new System.Windows.Forms.GroupBox();
            this.btnExaminar = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtPath = new MetroFramework.Controls.MetroTextBox();
            this.rbSQL = new MetroFramework.Controls.MetroRadioButton();
            this.rbAccess = new MetroFramework.Controls.MetroRadioButton();
            this.groupSQL.SuspendLayout();
            this.groupAccess.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupSQL
            // 
            this.groupSQL.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupSQL.Controls.Add(this.metroLabel4);
            this.groupSQL.Controls.Add(this.txtPasswordSQL);
            this.groupSQL.Controls.Add(this.txtUsuarioSQL);
            this.groupSQL.Controls.Add(this.metroLabel3);
            this.groupSQL.Controls.Add(this.txtBase);
            this.groupSQL.Controls.Add(this.metroLabel2);
            this.groupSQL.Controls.Add(this.txtServer);
            this.groupSQL.Controls.Add(this.metroLabel1);
            this.groupSQL.Enabled = false;
            this.groupSQL.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupSQL.Location = new System.Drawing.Point(145, 64);
            this.groupSQL.Name = "groupSQL";
            this.groupSQL.Size = new System.Drawing.Size(528, 211);
            this.groupSQL.TabIndex = 4;
            this.groupSQL.TabStop = false;
            this.groupSQL.Text = "SQL Server";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(268, 153);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(78, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Contraseña:";
            this.metroLabel4.UseStyleColors = true;
            // 
            // txtPasswordSQL
            // 
            // 
            // 
            // 
            this.txtPasswordSQL.CustomButton.Image = null;
            this.txtPasswordSQL.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.txtPasswordSQL.CustomButton.Name = "";
            this.txtPasswordSQL.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPasswordSQL.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPasswordSQL.CustomButton.TabIndex = 1;
            this.txtPasswordSQL.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPasswordSQL.CustomButton.UseSelectable = true;
            this.txtPasswordSQL.CustomButton.Visible = false;
            this.txtPasswordSQL.Lines = new string[0];
            this.txtPasswordSQL.Location = new System.Drawing.Point(352, 153);
            this.txtPasswordSQL.MaxLength = 32767;
            this.txtPasswordSQL.Name = "txtPasswordSQL";
            this.txtPasswordSQL.PasswordChar = '*';
            this.txtPasswordSQL.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPasswordSQL.SelectedText = "";
            this.txtPasswordSQL.SelectionLength = 0;
            this.txtPasswordSQL.SelectionStart = 0;
            this.txtPasswordSQL.ShortcutsEnabled = true;
            this.txtPasswordSQL.Size = new System.Drawing.Size(161, 23);
            this.txtPasswordSQL.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPasswordSQL.TabIndex = 6;
            this.txtPasswordSQL.UseSelectable = true;
            this.txtPasswordSQL.UseStyleColors = true;
            this.txtPasswordSQL.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPasswordSQL.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUsuarioSQL
            // 
            // 
            // 
            // 
            this.txtUsuarioSQL.CustomButton.Image = null;
            this.txtUsuarioSQL.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.txtUsuarioSQL.CustomButton.Name = "";
            this.txtUsuarioSQL.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUsuarioSQL.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsuarioSQL.CustomButton.TabIndex = 1;
            this.txtUsuarioSQL.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsuarioSQL.CustomButton.UseSelectable = true;
            this.txtUsuarioSQL.CustomButton.Visible = false;
            this.txtUsuarioSQL.Lines = new string[] {
        "saftec"};
            this.txtUsuarioSQL.Location = new System.Drawing.Point(68, 153);
            this.txtUsuarioSQL.MaxLength = 32767;
            this.txtUsuarioSQL.Name = "txtUsuarioSQL";
            this.txtUsuarioSQL.PasswordChar = '\0';
            this.txtUsuarioSQL.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuarioSQL.SelectedText = "";
            this.txtUsuarioSQL.SelectionLength = 0;
            this.txtUsuarioSQL.SelectionStart = 0;
            this.txtUsuarioSQL.ShortcutsEnabled = true;
            this.txtUsuarioSQL.Size = new System.Drawing.Size(142, 23);
            this.txtUsuarioSQL.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsuarioSQL.TabIndex = 5;
            this.txtUsuarioSQL.Text = "saftec";
            this.txtUsuarioSQL.UseSelectable = true;
            this.txtUsuarioSQL.UseStyleColors = true;
            this.txtUsuarioSQL.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsuarioSQL.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 153);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Usuario:";
            this.metroLabel3.UseStyleColors = true;
            // 
            // txtBase
            // 
            // 
            // 
            // 
            this.txtBase.CustomButton.Image = null;
            this.txtBase.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.txtBase.CustomButton.Name = "";
            this.txtBase.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBase.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBase.CustomButton.TabIndex = 1;
            this.txtBase.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBase.CustomButton.UseSelectable = true;
            this.txtBase.CustomButton.Visible = false;
            this.txtBase.Lines = new string[] {
        "SaftCommDB"};
            this.txtBase.Location = new System.Drawing.Point(106, 99);
            this.txtBase.MaxLength = 32767;
            this.txtBase.Name = "txtBase";
            this.txtBase.PasswordChar = '\0';
            this.txtBase.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBase.SelectedText = "";
            this.txtBase.SelectionLength = 0;
            this.txtBase.SelectionStart = 0;
            this.txtBase.ShortcutsEnabled = true;
            this.txtBase.Size = new System.Drawing.Size(168, 23);
            this.txtBase.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBase.TabIndex = 3;
            this.txtBase.Text = "SaftCommDB";
            this.txtBase.UseSelectable = true;
            this.txtBase.UseStyleColors = true;
            this.txtBase.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBase.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 99);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(94, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Base de datos:";
            this.metroLabel2.UseStyleColors = true;
            // 
            // txtServer
            // 
            // 
            // 
            // 
            this.txtServer.CustomButton.Image = null;
            this.txtServer.CustomButton.Location = new System.Drawing.Point(418, 1);
            this.txtServer.CustomButton.Name = "";
            this.txtServer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtServer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtServer.CustomButton.TabIndex = 1;
            this.txtServer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtServer.CustomButton.UseSelectable = true;
            this.txtServer.CustomButton.Visible = false;
            this.txtServer.Lines = new string[0];
            this.txtServer.Location = new System.Drawing.Point(73, 37);
            this.txtServer.MaxLength = 32767;
            this.txtServer.Name = "txtServer";
            this.txtServer.PasswordChar = '\0';
            this.txtServer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtServer.SelectedText = "";
            this.txtServer.SelectionLength = 0;
            this.txtServer.SelectionStart = 0;
            this.txtServer.ShortcutsEnabled = true;
            this.txtServer.Size = new System.Drawing.Size(440, 23);
            this.txtServer.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtServer.TabIndex = 1;
            this.txtServer.UseSelectable = true;
            this.txtServer.UseStyleColors = true;
            this.txtServer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtServer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 37);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(61, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Servidor:";
            this.metroLabel1.UseStyleColors = true;
            // 
            // groupAccess
            // 
            this.groupAccess.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupAccess.Controls.Add(this.btnExaminar);
            this.groupAccess.Controls.Add(this.metroLabel5);
            this.groupAccess.Controls.Add(this.txtPath);
            this.groupAccess.Enabled = false;
            this.groupAccess.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupAccess.Location = new System.Drawing.Point(145, 306);
            this.groupAccess.Name = "groupAccess";
            this.groupAccess.Size = new System.Drawing.Size(528, 178);
            this.groupAccess.TabIndex = 5;
            this.groupAccess.TabStop = false;
            this.groupAccess.Text = "MS Access";
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(407, 59);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(106, 23);
            this.btnExaminar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnExaminar.TabIndex = 9;
            this.btnExaminar.Text = "Buscar";
            this.btnExaminar.UseSelectable = true;
            this.btnExaminar.UseStyleColors = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(6, 23);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(38, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Path:";
            this.metroLabel5.UseStyleColors = true;
            // 
            // txtPath
            // 
            // 
            // 
            // 
            this.txtPath.CustomButton.Image = null;
            this.txtPath.CustomButton.Location = new System.Drawing.Point(441, 1);
            this.txtPath.CustomButton.Name = "";
            this.txtPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPath.CustomButton.TabIndex = 1;
            this.txtPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPath.CustomButton.UseSelectable = true;
            this.txtPath.CustomButton.Visible = false;
            this.txtPath.Lines = new string[0];
            this.txtPath.Location = new System.Drawing.Point(50, 19);
            this.txtPath.MaxLength = 32767;
            this.txtPath.Name = "txtPath";
            this.txtPath.PasswordChar = '\0';
            this.txtPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPath.SelectedText = "";
            this.txtPath.SelectionLength = 0;
            this.txtPath.SelectionStart = 0;
            this.txtPath.ShortcutsEnabled = true;
            this.txtPath.Size = new System.Drawing.Size(463, 23);
            this.txtPath.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPath.TabIndex = 0;
            this.txtPath.UseSelectable = true;
            this.txtPath.UseStyleColors = true;
            this.txtPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rbSQL
            // 
            this.rbSQL.AutoSize = true;
            this.rbSQL.Location = new System.Drawing.Point(12, 243);
            this.rbSQL.Name = "rbSQL";
            this.rbSQL.Size = new System.Drawing.Size(79, 15);
            this.rbSQL.Style = MetroFramework.MetroColorStyle.Blue;
            this.rbSQL.TabIndex = 6;
            this.rbSQL.Text = "SQL Server";
            this.rbSQL.UseSelectable = true;
            this.rbSQL.UseStyleColors = true;
            this.rbSQL.CheckedChanged += new System.EventHandler(this.rbSQL_CheckedChanged);
            // 
            // rbAccess
            // 
            this.rbAccess.AutoSize = true;
            this.rbAccess.Location = new System.Drawing.Point(12, 296);
            this.rbAccess.Name = "rbAccess";
            this.rbAccess.Size = new System.Drawing.Size(79, 15);
            this.rbAccess.Style = MetroFramework.MetroColorStyle.Blue;
            this.rbAccess.TabIndex = 7;
            this.rbAccess.Text = "MS Access";
            this.rbAccess.UseSelectable = true;
            this.rbAccess.UseStyleColors = true;
            this.rbAccess.CheckedChanged += new System.EventHandler(this.rbAccess_CheckedChanged);
            // 
            // PanelBaseDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbAccess);
            this.Controls.Add(this.rbSQL);
            this.Controls.Add(this.groupAccess);
            this.Controls.Add(this.groupSQL);
            this.Name = "PanelBaseDeDatos";
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.groupSQL, 0);
            this.Controls.SetChildIndex(this.groupAccess, 0);
            this.Controls.SetChildIndex(this.rbSQL, 0);
            this.Controls.SetChildIndex(this.rbAccess, 0);
            this.groupSQL.ResumeLayout(false);
            this.groupSQL.PerformLayout();
            this.groupAccess.ResumeLayout(false);
            this.groupAccess.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupSQL;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtPasswordSQL;
        private MetroFramework.Controls.MetroTextBox txtUsuarioSQL;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtBase;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtServer;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupAccess;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtPath;
        private MetroFramework.Controls.MetroRadioButton rbSQL;
        private MetroFramework.Controls.MetroRadioButton rbAccess;
        private MetroFramework.Controls.MetroButton btnExaminar;
    }
}
