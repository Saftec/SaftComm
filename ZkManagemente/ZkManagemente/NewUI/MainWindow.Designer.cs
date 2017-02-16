namespace ZkManagement.NewUI
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.tableMenu = new System.Windows.Forms.TableLayoutPanel();
            this.linkConfiguracion = new MetroFramework.Controls.MetroLink();
            this.linkPersonal = new MetroFramework.Controls.MetroLink();
            this.linkDispositivos = new MetroFramework.Controls.MetroLink();
            this.linkSincronizacion = new MetroFramework.Controls.MetroLink();
            this.linkUsuarios = new MetroFramework.Controls.MetroLink();
            this.pHeader = new System.Windows.Forms.Panel();
            this.lblUsr = new MetroFramework.Controls.MetroLabel();
            this.lblVersionApp = new MetroFramework.Controls.MetroLabel();
            this.lblVersionBD = new MetroFramework.Controls.MetroLabel();
            this.metroPanel = new MetroFramework.Controls.MetroPanel();
            this.timerRutinaRegs = new System.Windows.Forms.Timer(this.components);
            this.timerRutinaHora = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorkerRutinaRegistros = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerRutinaHora = new System.ComponentModel.BackgroundWorker();
            this.tableMenu.SuspendLayout();
            this.pHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableMenu
            // 
            this.tableMenu.ColumnCount = 5;
            this.tableMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableMenu.Controls.Add(this.linkConfiguracion, 4, 0);
            this.tableMenu.Controls.Add(this.linkPersonal, 0, 0);
            this.tableMenu.Controls.Add(this.linkDispositivos, 1, 0);
            this.tableMenu.Controls.Add(this.linkSincronizacion, 2, 0);
            this.tableMenu.Controls.Add(this.linkUsuarios, 3, 0);
            this.tableMenu.Location = new System.Drawing.Point(0, 0);
            this.tableMenu.Margin = new System.Windows.Forms.Padding(4);
            this.tableMenu.Name = "tableMenu";
            this.tableMenu.RowCount = 1;
            this.tableMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableMenu.Size = new System.Drawing.Size(717, 64);
            this.tableMenu.TabIndex = 2;
            // 
            // linkConfiguracion
            // 
            this.linkConfiguracion.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.linkConfiguracion.Image = global::ZkManagement.Properties.Resources.settings;
            this.linkConfiguracion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkConfiguracion.ImageSize = 20;
            this.linkConfiguracion.Location = new System.Drawing.Point(575, 3);
            this.linkConfiguracion.Name = "linkConfiguracion";
            this.linkConfiguracion.Size = new System.Drawing.Size(137, 58);
            this.linkConfiguracion.Style = MetroFramework.MetroColorStyle.Blue;
            this.linkConfiguracion.TabIndex = 9;
            this.linkConfiguracion.Text = "Configuracion";
            this.linkConfiguracion.UseSelectable = true;
            this.linkConfiguracion.UseStyleColors = true;
            this.linkConfiguracion.Click += new System.EventHandler(this.linkConfiguracion_Click);
            // 
            // linkPersonal
            // 
            this.linkPersonal.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.linkPersonal.Image = global::ZkManagement.Properties.Resources.group;
            this.linkPersonal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkPersonal.ImageSize = 20;
            this.linkPersonal.Location = new System.Drawing.Point(3, 3);
            this.linkPersonal.Name = "linkPersonal";
            this.linkPersonal.Size = new System.Drawing.Size(137, 58);
            this.linkPersonal.Style = MetroFramework.MetroColorStyle.Blue;
            this.linkPersonal.TabIndex = 6;
            this.linkPersonal.Text = "Personal";
            this.linkPersonal.UseSelectable = true;
            this.linkPersonal.UseStyleColors = true;
            this.linkPersonal.Click += new System.EventHandler(this.linkPersonal_Click);
            // 
            // linkDispositivos
            // 
            this.linkDispositivos.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.linkDispositivos.Image = global::ZkManagement.Properties.Resources.clock;
            this.linkDispositivos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkDispositivos.ImageSize = 20;
            this.linkDispositivos.Location = new System.Drawing.Point(146, 3);
            this.linkDispositivos.Name = "linkDispositivos";
            this.linkDispositivos.Size = new System.Drawing.Size(137, 58);
            this.linkDispositivos.Style = MetroFramework.MetroColorStyle.Blue;
            this.linkDispositivos.TabIndex = 8;
            this.linkDispositivos.Text = "Dispositivos";
            this.linkDispositivos.UseSelectable = true;
            this.linkDispositivos.UseStyleColors = true;
            this.linkDispositivos.Click += new System.EventHandler(this.linkDispositivos_Click);
            // 
            // linkSincronizacion
            // 
            this.linkSincronizacion.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.linkSincronizacion.Image = global::ZkManagement.Properties.Resources.sinc;
            this.linkSincronizacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkSincronizacion.ImageSize = 20;
            this.linkSincronizacion.Location = new System.Drawing.Point(289, 3);
            this.linkSincronizacion.Name = "linkSincronizacion";
            this.linkSincronizacion.Size = new System.Drawing.Size(137, 58);
            this.linkSincronizacion.Style = MetroFramework.MetroColorStyle.Blue;
            this.linkSincronizacion.TabIndex = 6;
            this.linkSincronizacion.Text = "Sincronizacion";
            this.linkSincronizacion.UseSelectable = true;
            this.linkSincronizacion.UseStyleColors = true;
            this.linkSincronizacion.Click += new System.EventHandler(this.linkSincronizacion_Click);
            // 
            // linkUsuarios
            // 
            this.linkUsuarios.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.linkUsuarios.Image = global::ZkManagement.Properties.Resources.padlock;
            this.linkUsuarios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkUsuarios.ImageSize = 20;
            this.linkUsuarios.Location = new System.Drawing.Point(432, 3);
            this.linkUsuarios.Name = "linkUsuarios";
            this.linkUsuarios.Size = new System.Drawing.Size(137, 58);
            this.linkUsuarios.Style = MetroFramework.MetroColorStyle.Blue;
            this.linkUsuarios.TabIndex = 7;
            this.linkUsuarios.Text = "Usuarios";
            this.linkUsuarios.UseSelectable = true;
            this.linkUsuarios.UseStyleColors = true;
            this.linkUsuarios.Click += new System.EventHandler(this.linkUsuarios_Click);
            // 
            // pHeader
            // 
            this.pHeader.Controls.Add(this.lblUsr);
            this.pHeader.Controls.Add(this.lblVersionApp);
            this.pHeader.Controls.Add(this.lblVersionBD);
            this.pHeader.Controls.Add(this.tableMenu);
            this.pHeader.Location = new System.Drawing.Point(175, 6);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(854, 67);
            this.pHeader.TabIndex = 3;
            // 
            // lblUsr
            // 
            this.lblUsr.AutoSize = true;
            this.lblUsr.Location = new System.Drawing.Point(724, 42);
            this.lblUsr.Name = "lblUsr";
            this.lblUsr.Size = new System.Drawing.Size(71, 19);
            this.lblUsr.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblUsr.TabIndex = 5;
            this.lblUsr.Text = "<Usuario>";
            this.lblUsr.UseStyleColors = true;
            // 
            // lblVersionApp
            // 
            this.lblVersionApp.AutoSize = true;
            this.lblVersionApp.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblVersionApp.Location = new System.Drawing.Point(724, 22);
            this.lblVersionApp.Name = "lblVersionApp";
            this.lblVersionApp.Size = new System.Drawing.Size(85, 15);
            this.lblVersionApp.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblVersionApp.TabIndex = 4;
            this.lblVersionApp.Text = "<Version App>";
            this.lblVersionApp.UseStyleColors = true;
            // 
            // lblVersionBD
            // 
            this.lblVersionBD.AutoSize = true;
            this.lblVersionBD.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblVersionBD.Location = new System.Drawing.Point(724, 3);
            this.lblVersionBD.Name = "lblVersionBD";
            this.lblVersionBD.Size = new System.Drawing.Size(78, 15);
            this.lblVersionBD.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblVersionBD.TabIndex = 3;
            this.lblVersionBD.Text = "<Version BD>";
            this.lblVersionBD.UseStyleColors = true;
            // 
            // metroPanel
            // 
            this.metroPanel.HorizontalScrollbarBarColor = true;
            this.metroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel.HorizontalScrollbarSize = 10;
            this.metroPanel.Location = new System.Drawing.Point(22, 144);
            this.metroPanel.Name = "metroPanel";
            this.metroPanel.Size = new System.Drawing.Size(1055, 630);
            this.metroPanel.TabIndex = 4;
            this.metroPanel.VerticalScrollbarBarColor = true;
            this.metroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel.VerticalScrollbarSize = 10;
            // 
            // timerRutinaRegs
            // 
            this.timerRutinaRegs.Tick += new System.EventHandler(this.timerRutinaRegs_Tick);
            // 
            // timerRutinaHora
            // 
            this.timerRutinaHora.Tick += new System.EventHandler(this.timerRutinaHora_Tick);
            // 
            // backgroundWorkerRutinaRegistros
            // 
            this.backgroundWorkerRutinaRegistros.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerRutinaRegistros_DoWork);
            // 
            // backgroundWorkerRutinaHora
            // 
            this.backgroundWorkerRutinaHora.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerRutinaHora_DoWork);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1108, 800);
            this.Controls.Add(this.metroPanel);
            this.Controls.Add(this.pHeader);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "MainWindow";
            this.Text = "SaftComm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.tableMenu.ResumeLayout(false);
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableMenu;
        private System.Windows.Forms.Panel pHeader;
        private MetroFramework.Controls.MetroPanel metroPanel;
        private System.Windows.Forms.Timer timerRutinaRegs;
        private System.Windows.Forms.Timer timerRutinaHora;
        private System.ComponentModel.BackgroundWorker backgroundWorkerRutinaRegistros;
        private System.ComponentModel.BackgroundWorker backgroundWorkerRutinaHora;
        private MetroFramework.Controls.MetroLabel lblUsr;
        private MetroFramework.Controls.MetroLabel lblVersionApp;
        private MetroFramework.Controls.MetroLabel lblVersionBD;
        private MetroFramework.Controls.MetroLink linkPersonal;
        private MetroFramework.Controls.MetroLink linkSincronizacion;
        private MetroFramework.Controls.MetroLink linkUsuarios;
        private MetroFramework.Controls.MetroLink linkDispositivos;
        private MetroFramework.Controls.MetroLink linkConfiguracion;
    }
}