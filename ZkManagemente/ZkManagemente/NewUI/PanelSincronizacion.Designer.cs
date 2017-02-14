namespace ZkManagement.NewUI
{
    partial class PanelSincronizacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridPersonalLocal = new MetroFramework.Controls.MetroGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantHuellas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Privilegio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cbRelojes = new MetroFramework.Controls.MetroComboBox();
            this.btnUsuarios = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.gridPersonalReloj = new MetroFramework.Controls.MetroGrid();
            this.NombreDisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LegajoDisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TarjetaDisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PinDisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrivilegioDisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeleccionDisp = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.btnDownloadInfo = new MetroFramework.Controls.MetroButton();
            this.btnUploadInfo = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblDispositivo = new MetroFramework.Controls.MetroLabel();
            this.backgroundDownloadInfo = new System.ComponentModel.BackgroundWorker();
            this.backgroundUploadInfo = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new MetroFramework.Controls.MetroProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonalLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonalReloj)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridPersonalLocal
            // 
            this.gridPersonalLocal.AllowUserToAddRows = false;
            this.gridPersonalLocal.AllowUserToResizeRows = false;
            this.gridPersonalLocal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridPersonalLocal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPersonalLocal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridPersonalLocal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPersonalLocal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPersonalLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPersonalLocal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Legajo,
            this.CantHuellas,
            this.Tarjeta,
            this.Pin,
            this.Privilegio,
            this.Seleccionar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPersonalLocal.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridPersonalLocal.EnableHeadersVisualStyles = false;
            this.gridPersonalLocal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridPersonalLocal.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridPersonalLocal.Location = new System.Drawing.Point(3, 73);
            this.gridPersonalLocal.Name = "gridPersonalLocal";
            this.gridPersonalLocal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPersonalLocal.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridPersonalLocal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridPersonalLocal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPersonalLocal.Size = new System.Drawing.Size(550, 479);
            this.gridPersonalLocal.TabIndex = 4;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "IdEmpleado";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre y Apellido";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 120;
            // 
            // Legajo
            // 
            this.Legajo.DataPropertyName = "Legajo";
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            this.Legajo.Width = 60;
            // 
            // CantHuellas
            // 
            this.CantHuellas.DataPropertyName = "Cant";
            this.CantHuellas.HeaderText = "Cant. Huellas";
            this.CantHuellas.Name = "CantHuellas";
            this.CantHuellas.ReadOnly = true;
            this.CantHuellas.Width = 70;
            // 
            // Tarjeta
            // 
            this.Tarjeta.DataPropertyName = "Tarjeta";
            this.Tarjeta.HeaderText = "Tarjeta";
            this.Tarjeta.Name = "Tarjeta";
            this.Tarjeta.ReadOnly = true;
            this.Tarjeta.Width = 50;
            // 
            // Pin
            // 
            this.Pin.DataPropertyName = "Pin";
            this.Pin.HeaderText = "Pin";
            this.Pin.Name = "Pin";
            this.Pin.ReadOnly = true;
            this.Pin.Width = 50;
            // 
            // Privilegio
            // 
            this.Privilegio.DataPropertyName = "Privilegio";
            this.Privilegio.HeaderText = "Privilegio";
            this.Privilegio.Name = "Privilegio";
            this.Privilegio.ReadOnly = true;
            this.Privilegio.Width = 60;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Width = 70;
            // 
            // cbRelojes
            // 
            this.cbRelojes.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbRelojes.FormattingEnabled = true;
            this.cbRelojes.ItemHeight = 23;
            this.cbRelojes.Location = new System.Drawing.Point(120, 3);
            this.cbRelojes.Name = "cbRelojes";
            this.cbRelojes.Size = new System.Drawing.Size(217, 29);
            this.cbRelojes.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbRelojes.TabIndex = 1;
            this.cbRelojes.UseCustomForeColor = true;
            this.cbRelojes.UseSelectable = true;
            this.cbRelojes.UseStyleColors = true;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(343, 3);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(120, 29);
            this.btnUsuarios.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "Ver usuarios en Disp.";
            this.btnUsuarios.UseSelectable = true;
            this.btnUsuarios.UseStyleColors = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(111, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Dispositivo:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // gridPersonalReloj
            // 
            this.gridPersonalReloj.AllowUserToAddRows = false;
            this.gridPersonalReloj.AllowUserToResizeRows = false;
            this.gridPersonalReloj.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridPersonalReloj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPersonalReloj.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridPersonalReloj.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPersonalReloj.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridPersonalReloj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPersonalReloj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreDisp,
            this.LegajoDisp,
            this.TarjetaDisp,
            this.PinDisp,
            this.PrivilegioDisp,
            this.SeleccionDisp});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPersonalReloj.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridPersonalReloj.EnableHeadersVisualStyles = false;
            this.gridPersonalReloj.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridPersonalReloj.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridPersonalReloj.Location = new System.Drawing.Point(596, 73);
            this.gridPersonalReloj.Name = "gridPersonalReloj";
            this.gridPersonalReloj.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPersonalReloj.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridPersonalReloj.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridPersonalReloj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPersonalReloj.Size = new System.Drawing.Size(401, 479);
            this.gridPersonalReloj.TabIndex = 6;
            // 
            // NombreDisp
            // 
            this.NombreDisp.DataPropertyName = "Nombre";
            this.NombreDisp.HeaderText = "Nombre y Apellido";
            this.NombreDisp.Name = "NombreDisp";
            this.NombreDisp.ReadOnly = true;
            // 
            // LegajoDisp
            // 
            this.LegajoDisp.DataPropertyName = "Legajo";
            this.LegajoDisp.HeaderText = "Legajo";
            this.LegajoDisp.Name = "LegajoDisp";
            this.LegajoDisp.ReadOnly = true;
            this.LegajoDisp.Width = 50;
            // 
            // TarjetaDisp
            // 
            this.TarjetaDisp.DataPropertyName = "Tarjeta";
            this.TarjetaDisp.HeaderText = "Tarjeta";
            this.TarjetaDisp.Name = "TarjetaDisp";
            this.TarjetaDisp.ReadOnly = true;
            this.TarjetaDisp.Width = 50;
            // 
            // PinDisp
            // 
            this.PinDisp.DataPropertyName = "Pin";
            this.PinDisp.HeaderText = "Pin";
            this.PinDisp.Name = "PinDisp";
            this.PinDisp.ReadOnly = true;
            this.PinDisp.Width = 50;
            // 
            // PrivilegioDisp
            // 
            this.PrivilegioDisp.DataPropertyName = "Privilegio";
            this.PrivilegioDisp.HeaderText = "Privilegio";
            this.PrivilegioDisp.Name = "PrivilegioDisp";
            this.PrivilegioDisp.ReadOnly = true;
            this.PrivilegioDisp.Width = 55;
            // 
            // SeleccionDisp
            // 
            this.SeleccionDisp.HeaderText = "Seleccionar";
            this.SeleccionDisp.Name = "SeleccionDisp";
            this.SeleccionDisp.Width = 50;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel1.Controls.Add(this.cbRelojes, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUsuarios, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEliminar, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDownloadInfo, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUploadInfo, 5, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(894, 35);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(469, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(145, 29);
            this.btnEliminar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar usuarios de Disp.";
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.UseStyleColors = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnDownloadInfo
            // 
            this.btnDownloadInfo.Location = new System.Drawing.Point(620, 3);
            this.btnDownloadInfo.Name = "btnDownloadInfo";
            this.btnDownloadInfo.Size = new System.Drawing.Size(117, 29);
            this.btnDownloadInfo.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnDownloadInfo.TabIndex = 4;
            this.btnDownloadInfo.Text = "Descargar Usuarios";
            this.btnDownloadInfo.UseSelectable = true;
            this.btnDownloadInfo.UseStyleColors = true;
            this.btnDownloadInfo.Click += new System.EventHandler(this.btnDownloadInfo_Click);
            // 
            // btnUploadInfo
            // 
            this.btnUploadInfo.Location = new System.Drawing.Point(743, 3);
            this.btnUploadInfo.Name = "btnUploadInfo";
            this.btnUploadInfo.Size = new System.Drawing.Size(148, 29);
            this.btnUploadInfo.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnUploadInfo.TabIndex = 5;
            this.btnUploadInfo.Text = "Enviar info. de usuarios";
            this.btnUploadInfo.UseSelectable = true;
            this.btnUploadInfo.UseStyleColors = true;
            this.btnUploadInfo.Click += new System.EventHandler(this.btnUploadInfo_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(3, 51);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(201, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Usuarios en base de datos local";
            this.metroLabel2.UseStyleColors = true;
            // 
            // lblDispositivo
            // 
            this.lblDispositivo.AutoSize = true;
            this.lblDispositivo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDispositivo.Location = new System.Drawing.Point(596, 51);
            this.lblDispositivo.Name = "lblDispositivo";
            this.lblDispositivo.Size = new System.Drawing.Size(157, 19);
            this.lblDispositivo.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDispositivo.TabIndex = 9;
            this.lblDispositivo.Text = "Usuarios en dispositivo: ";
            this.lblDispositivo.UseStyleColors = true;
            // 
            // backgroundDownloadInfo
            // 
            this.backgroundDownloadInfo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundDownloadInfo_DoWork);
            this.backgroundDownloadInfo.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundDownloadInfo_ProgressChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(187, 579);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(614, 23);
            this.progressBar.TabIndex = 10;
            // 
            // PanelSincronizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblDispositivo);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gridPersonalReloj);
            this.Controls.Add(this.gridPersonalLocal);
            this.Name = "PanelSincronizacion";
            this.Controls.SetChildIndex(this.gridPersonalLocal, 0);
            this.Controls.SetChildIndex(this.gridPersonalReloj, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.metroLabel2, 0);
            this.Controls.SetChildIndex(this.lblDispositivo, 0);
            this.Controls.SetChildIndex(this.progressBar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonalLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonalReloj)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid gridPersonalLocal;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbRelojes;
        private MetroFramework.Controls.MetroButton btnUsuarios;
        private MetroFramework.Controls.MetroGrid gridPersonalReloj;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroButton btnEliminar;
        private MetroFramework.Controls.MetroButton btnDownloadInfo;
        private MetroFramework.Controls.MetroButton btnUploadInfo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblDispositivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantHuellas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Privilegio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.ComponentModel.BackgroundWorker backgroundDownloadInfo;
        private System.ComponentModel.BackgroundWorker backgroundUploadInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn LegajoDisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn TarjetaDisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn PinDisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrivilegioDisp;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SeleccionDisp;
        private MetroFramework.Controls.MetroProgressBar progressBar;
    }
}
