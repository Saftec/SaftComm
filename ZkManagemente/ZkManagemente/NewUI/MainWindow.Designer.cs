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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tableMenu = new System.Windows.Forms.TableLayoutPanel();
            this.linkConfiguracion = new MetroFramework.Controls.MetroLink();
            this.linkPersonal = new MetroFramework.Controls.MetroLink();
            this.linkSincronizacion = new MetroFramework.Controls.MetroLink();
            this.linkUsuarios = new MetroFramework.Controls.MetroLink();
            this.linkDispositivos = new MetroFramework.Controls.MetroLink();
            this.pHeader = new System.Windows.Forms.Panel();
            this.lblUsr = new MetroFramework.Controls.MetroLabel();
            this.lblVersionApp = new MetroFramework.Controls.MetroLabel();
            this.lblVersionBD = new MetroFramework.Controls.MetroLabel();
            this.metroPanel = new MetroFramework.Controls.MetroPanel();
            this.timerRutinaRegs = new System.Windows.Forms.Timer(this.components);
            this.timerRutinaHora = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorkerRutinaRegistros = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerRutinaHora = new System.ComponentModel.BackgroundWorker();
            this.iconoBandeja = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuBandeja = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.tableMenu.SuspendLayout();
            this.pHeader.SuspendLayout();
            this.contextMenuBandeja.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableMenu
            // 
            this.tableMenu.ColumnCount = 5;
            this.tableMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.81633F));
            this.tableMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.57823F));
            this.tableMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.31973F));
            this.tableMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.64626F));
            this.tableMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.14966F));
            this.tableMenu.Controls.Add(this.linkConfiguracion, 4, 0);
            this.tableMenu.Controls.Add(this.linkPersonal, 0, 0);
            this.tableMenu.Controls.Add(this.linkSincronizacion, 2, 0);
            this.tableMenu.Controls.Add(this.linkUsuarios, 3, 0);
            this.tableMenu.Controls.Add(this.linkDispositivos, 1, 0);
            this.tableMenu.Location = new System.Drawing.Point(0, 0);
            this.tableMenu.Margin = new System.Windows.Forms.Padding(4);
            this.tableMenu.Name = "tableMenu";
            this.tableMenu.RowCount = 1;
            this.tableMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableMenu.Size = new System.Drawing.Size(588, 64);
            this.tableMenu.TabIndex = 2;
            // 
            // linkConfiguracion
            // 
            this.linkConfiguracion.Enabled = false;
            this.linkConfiguracion.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.linkConfiguracion.Image = global::ZkManagement.Properties.Resources.settings;
            this.linkConfiguracion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkConfiguracion.ImageSize = 20;
            this.linkConfiguracion.Location = new System.Drawing.Point(448, 3);
            this.linkConfiguracion.Name = "linkConfiguracion";
            this.linkConfiguracion.Size = new System.Drawing.Size(132, 58);
            this.linkConfiguracion.Style = MetroFramework.MetroColorStyle.Blue;
            this.linkConfiguracion.TabIndex = 9;
            this.linkConfiguracion.Text = "Configuracion";
            this.linkConfiguracion.UseSelectable = true;
            this.linkConfiguracion.UseStyleColors = true;
            this.linkConfiguracion.Click += new System.EventHandler(this.linkConfiguracion_Click);
            // 
            // linkPersonal
            // 
            this.linkPersonal.Enabled = false;
            this.linkPersonal.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.linkPersonal.Image = global::ZkManagement.Properties.Resources.group;
            this.linkPersonal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkPersonal.ImageSize = 20;
            this.linkPersonal.Location = new System.Drawing.Point(3, 3);
            this.linkPersonal.Name = "linkPersonal";
            this.linkPersonal.Size = new System.Drawing.Size(86, 58);
            this.linkPersonal.Style = MetroFramework.MetroColorStyle.Blue;
            this.linkPersonal.TabIndex = 6;
            this.linkPersonal.Text = "Personal";
            this.linkPersonal.UseSelectable = true;
            this.linkPersonal.UseStyleColors = true;
            this.linkPersonal.Click += new System.EventHandler(this.linkPersonal_Click);
            // 
            // linkSincronizacion
            // 
            this.linkSincronizacion.Enabled = false;
            this.linkSincronizacion.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.linkSincronizacion.Image = global::ZkManagement.Properties.Resources.sinc;
            this.linkSincronizacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkSincronizacion.ImageSize = 20;
            this.linkSincronizacion.Location = new System.Drawing.Point(215, 3);
            this.linkSincronizacion.Name = "linkSincronizacion";
            this.linkSincronizacion.Size = new System.Drawing.Size(136, 58);
            this.linkSincronizacion.Style = MetroFramework.MetroColorStyle.Blue;
            this.linkSincronizacion.TabIndex = 6;
            this.linkSincronizacion.Text = "Sincronización";
            this.linkSincronizacion.UseSelectable = true;
            this.linkSincronizacion.UseStyleColors = true;
            this.linkSincronizacion.Click += new System.EventHandler(this.linkSincronizacion_Click);
            // 
            // linkUsuarios
            // 
            this.linkUsuarios.Enabled = false;
            this.linkUsuarios.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.linkUsuarios.Image = global::ZkManagement.Properties.Resources.padlock;
            this.linkUsuarios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkUsuarios.ImageSize = 20;
            this.linkUsuarios.Location = new System.Drawing.Point(357, 3);
            this.linkUsuarios.Name = "linkUsuarios";
            this.linkUsuarios.Size = new System.Drawing.Size(85, 58);
            this.linkUsuarios.Style = MetroFramework.MetroColorStyle.Blue;
            this.linkUsuarios.TabIndex = 7;
            this.linkUsuarios.Text = "Usuarios";
            this.linkUsuarios.UseSelectable = true;
            this.linkUsuarios.UseStyleColors = true;
            this.linkUsuarios.Click += new System.EventHandler(this.linkUsuarios_Click);
            // 
            // linkDispositivos
            // 
            this.linkDispositivos.Enabled = false;
            this.linkDispositivos.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.linkDispositivos.Image = global::ZkManagement.Properties.Resources.clock;
            this.linkDispositivos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkDispositivos.ImageSize = 20;
            this.linkDispositivos.Location = new System.Drawing.Point(95, 3);
            this.linkDispositivos.Name = "linkDispositivos";
            this.linkDispositivos.Size = new System.Drawing.Size(114, 58);
            this.linkDispositivos.Style = MetroFramework.MetroColorStyle.Blue;
            this.linkDispositivos.TabIndex = 8;
            this.linkDispositivos.Text = "Dispositivos";
            this.linkDispositivos.UseSelectable = true;
            this.linkDispositivos.UseStyleColors = true;
            this.linkDispositivos.Click += new System.EventHandler(this.linkDispositivos_Click);
            // 
            // pHeader
            // 
            this.pHeader.Controls.Add(this.lblUsr);
            this.pHeader.Controls.Add(this.lblVersionApp);
            this.pHeader.Controls.Add(this.lblVersionBD);
            this.pHeader.Controls.Add(this.tableMenu);
            this.pHeader.Location = new System.Drawing.Point(128, 14);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(746, 67);
            this.pHeader.TabIndex = 3;
            // 
            // lblUsr
            // 
            this.lblUsr.AutoSize = true;
            this.lblUsr.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblUsr.Location = new System.Drawing.Point(604, 45);
            this.lblUsr.Name = "lblUsr";
            this.lblUsr.Size = new System.Drawing.Size(61, 15);
            this.lblUsr.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblUsr.TabIndex = 5;
            this.lblUsr.Text = "<Usuario>";
            this.lblUsr.UseStyleColors = true;
            // 
            // lblVersionApp
            // 
            this.lblVersionApp.AutoSize = true;
            this.lblVersionApp.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblVersionApp.Location = new System.Drawing.Point(604, 25);
            this.lblVersionApp.Name = "lblVersionApp";
            this.lblVersionApp.Size = new System.Drawing.Size(84, 15);
            this.lblVersionApp.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblVersionApp.TabIndex = 4;
            this.lblVersionApp.Text = "<Version App>";
            this.lblVersionApp.UseStyleColors = true;
            // 
            // lblVersionBD
            // 
            this.lblVersionBD.AutoSize = true;
            this.lblVersionBD.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblVersionBD.Location = new System.Drawing.Point(604, 6);
            this.lblVersionBD.Name = "lblVersionBD";
            this.lblVersionBD.Size = new System.Drawing.Size(77, 15);
            this.lblVersionBD.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblVersionBD.TabIndex = 3;
            this.lblVersionBD.Text = "<Version BD>";
            this.lblVersionBD.UseStyleColors = true;
            // 
            // metroPanel
            // 
            this.metroPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel.HorizontalScrollbarBarColor = true;
            this.metroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel.HorizontalScrollbarSize = 10;
            this.metroPanel.Location = new System.Drawing.Point(17, 105);
            this.metroPanel.Name = "metroPanel";
            this.metroPanel.Size = new System.Drawing.Size(857, 521);
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
            // iconoBandeja
            // 
            this.iconoBandeja.Icon = ((System.Drawing.Icon)(resources.GetObject("iconoBandeja.Icon")));
            this.iconoBandeja.Text = "Saftec";
            this.iconoBandeja.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.iconoBandeja_MouseDoubleClick);
            // 
            // contextMenuBandeja
            // 
            this.contextMenuBandeja.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuSalir,
            this.toolStripMenuAbrir});
            this.contextMenuBandeja.Name = "contextMenuBandeja";
            this.contextMenuBandeja.Size = new System.Drawing.Size(101, 48);
            // 
            // toolStripMenuSalir
            // 
            this.toolStripMenuSalir.Name = "toolStripMenuSalir";
            this.toolStripMenuSalir.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuSalir.Text = "Salir";
            this.toolStripMenuSalir.Click += new System.EventHandler(this.toolStripMenuSalir_Click);
            // 
            // toolStripMenuAbrir
            // 
            this.toolStripMenuAbrir.Name = "toolStripMenuAbrir";
            this.toolStripMenuAbrir.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuAbrir.Text = "Abrir";
            this.toolStripMenuAbrir.Click += new System.EventHandler(this.toolStripMenuAbrir_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 642);
            this.Controls.Add(this.metroPanel);
            this.Controls.Add(this.pHeader);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "MainWindow";
            this.Text = "SafCom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.SizeChanged += new System.EventHandler(this.MainWindow_SizeChanged);
            this.tableMenu.ResumeLayout(false);
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            this.contextMenuBandeja.ResumeLayout(false);
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
        private System.Windows.Forms.NotifyIcon iconoBandeja;
        private System.Windows.Forms.ContextMenuStrip contextMenuBandeja;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuSalir;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuAbrir;
    }
}