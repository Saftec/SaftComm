namespace ZkManagement.Interfaz
{
    partial class SincronizarDispositivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SincronizarDispositivo));
            this.comboRelojes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupSeleccion = new System.Windows.Forms.GroupBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.labelEstado = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dgvLocal = new System.Windows.Forms.DataGridView();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Privilegios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDispositivo = new System.Windows.Forms.DataGridView();
            this.Leg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Privilegio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.checkTodos = new System.Windows.Forms.CheckBox();
            this.checkTodosLocal = new System.Windows.Forms.CheckBox();
            this.backgroundWorkerSincronizacion = new System.ComponentModel.BackgroundWorker();
            this.rtbxLog = new System.Windows.Forms.RichTextBox();
            this.backgroundWorkerCargaDatos = new System.ComponentModel.BackgroundWorker();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.groupSeleccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispositivo)).BeginInit();
            this.SuspendLayout();
            // 
            // comboRelojes
            // 
            this.comboRelojes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRelojes.FormattingEnabled = true;
            this.comboRelojes.Location = new System.Drawing.Point(102, 33);
            this.comboRelojes.Name = "comboRelojes";
            this.comboRelojes.Size = new System.Drawing.Size(153, 21);
            this.comboRelojes.TabIndex = 0;
            this.comboRelojes.SelectedIndexChanged += new System.EventHandler(this.comboRelojes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dispositivo:";
            // 
            // groupSeleccion
            // 
            this.groupSeleccion.Controls.Add(this.btnConectar);
            this.groupSeleccion.Controls.Add(this.labelEstado);
            this.groupSeleccion.Controls.Add(this.comboRelojes);
            this.groupSeleccion.Controls.Add(this.btnMostrar);
            this.groupSeleccion.Controls.Add(this.label1);
            this.groupSeleccion.Location = new System.Drawing.Point(227, 14);
            this.groupSeleccion.Name = "groupSeleccion";
            this.groupSeleccion.Size = new System.Drawing.Size(631, 80);
            this.groupSeleccion.TabIndex = 3;
            this.groupSeleccion.TabStop = false;
            this.groupSeleccion.Text = "Seleccionar Dispositivo";
            // 
            // btnConectar
            // 
            this.btnConectar.Image = global::ZkManagement.Properties.Resources.connect;
            this.btnConectar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConectar.Location = new System.Drawing.Point(278, 48);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(118, 23);
            this.btnConectar.TabIndex = 4;
            this.btnConectar.Text = "Sólo conectar";
            this.btnConectar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(462, 36);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(80, 13);
            this.labelEstado.TabIndex = 3;
            this.labelEstado.Text = "Desconectado";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Image = global::ZkManagement.Properties.Resources.view;
            this.btnMostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrar.Location = new System.Drawing.Point(278, 19);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(118, 23);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar Usuarios";
            this.btnMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dgvLocal
            // 
            this.dgvLocal.AllowUserToAddRows = false;
            this.dgvLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Legajo,
            this.Nombre,
            this.Cant,
            this.Seleccionar,
            this.Id,
            this.Privilegios,
            this.Clave,
            this.Tarjeta});
            this.dgvLocal.Location = new System.Drawing.Point(93, 125);
            this.dgvLocal.Name = "dgvLocal";
            this.dgvLocal.ReadOnly = true;
            this.dgvLocal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocal.Size = new System.Drawing.Size(363, 420);
            this.dgvLocal.TabIndex = 4;
            this.dgvLocal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLocal_CellContentClick);
            // 
            // Legajo
            // 
            this.Legajo.DataPropertyName = "Legajo";
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            this.Legajo.Width = 70;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Cant
            // 
            this.Cant.DataPropertyName = "Cant";
            this.Cant.HeaderText = "Cant Huellas";
            this.Cant.Name = "Cant";
            this.Cant.ReadOnly = true;
            this.Cant.Width = 60;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 70;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "IdEmpleado";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Privilegios
            // 
            this.Privilegios.DataPropertyName = "Privilegio";
            this.Privilegios.HeaderText = "Privilegios";
            this.Privilegios.Name = "Privilegios";
            this.Privilegios.ReadOnly = true;
            this.Privilegios.Visible = false;
            // 
            // Clave
            // 
            this.Clave.DataPropertyName = "Pin";
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            this.Clave.Visible = false;
            // 
            // Tarjeta
            // 
            this.Tarjeta.DataPropertyName = "Tarjeta";
            this.Tarjeta.HeaderText = "Tarjeta";
            this.Tarjeta.Name = "Tarjeta";
            this.Tarjeta.ReadOnly = true;
            this.Tarjeta.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuarios en base de datos";
            // 
            // dgvDispositivo
            // 
            this.dgvDispositivo.AllowUserToAddRows = false;
            this.dgvDispositivo.AllowUserToDeleteRows = false;
            this.dgvDispositivo.AllowUserToOrderColumns = true;
            this.dgvDispositivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDispositivo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Leg,
            this.Nom,
            this.Pin,
            this.RFID,
            this.Privilegio,
            this.Seleccion});
            this.dgvDispositivo.Location = new System.Drawing.Point(505, 125);
            this.dgvDispositivo.Name = "dgvDispositivo";
            this.dgvDispositivo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDispositivo.Size = new System.Drawing.Size(413, 420);
            this.dgvDispositivo.TabIndex = 6;
            this.dgvDispositivo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDispositivo_CellContentClick);
            // 
            // Leg
            // 
            this.Leg.DataPropertyName = "Legajo";
            this.Leg.HeaderText = "Legajo";
            this.Leg.Name = "Leg";
            this.Leg.ReadOnly = true;
            this.Leg.Width = 60;
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "Nombre";
            this.Nom.HeaderText = "Nombre";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Pin
            // 
            this.Pin.DataPropertyName = "Pin";
            this.Pin.HeaderText = "Pin";
            this.Pin.Name = "Pin";
            this.Pin.ReadOnly = true;
            this.Pin.Width = 40;
            // 
            // RFID
            // 
            this.RFID.DataPropertyName = "Tarjeta";
            this.RFID.HeaderText = "Tarjeta";
            this.RFID.Name = "RFID";
            this.RFID.ReadOnly = true;
            this.RFID.Width = 50;
            // 
            // Privilegio
            // 
            this.Privilegio.DataPropertyName = "Privilegio";
            this.Privilegio.HeaderText = "Privilegios";
            this.Privilegio.Name = "Privilegio";
            this.Privilegio.ReadOnly = true;
            this.Privilegio.Width = 50;
            // 
            // Seleccion
            // 
            this.Seleccion.HeaderText = "Seleccionar";
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Seleccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Seleccion.Width = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(641, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Usuarios en dispositivo";
            // 
            // checkTodos
            // 
            this.checkTodos.AutoSize = true;
            this.checkTodos.Location = new System.Drawing.Point(851, 106);
            this.checkTodos.Name = "checkTodos";
            this.checkTodos.Size = new System.Drawing.Size(56, 17);
            this.checkTodos.TabIndex = 10;
            this.checkTodos.Text = "Todos";
            this.checkTodos.UseVisualStyleBackColor = true;
            this.checkTodos.CheckedChanged += new System.EventHandler(this.checkTodos_CheckedChanged);
            // 
            // checkTodosLocal
            // 
            this.checkTodosLocal.AutoSize = true;
            this.checkTodosLocal.Location = new System.Drawing.Point(399, 106);
            this.checkTodosLocal.Name = "checkTodosLocal";
            this.checkTodosLocal.Size = new System.Drawing.Size(56, 17);
            this.checkTodosLocal.TabIndex = 11;
            this.checkTodosLocal.Text = "Todos";
            this.checkTodosLocal.UseVisualStyleBackColor = true;
            this.checkTodosLocal.CheckedChanged += new System.EventHandler(this.checkTodosLocal_CheckedChanged);
            // 
            // backgroundWorkerSincronizacion
            // 
            this.backgroundWorkerSincronizacion.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerSincronizacion_DoWork);
            this.backgroundWorkerSincronizacion.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerSincronizacion_ProgressChanged);
            this.backgroundWorkerSincronizacion.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerSincronizacion_RunWorkerCompleted);
            // 
            // rtbxLog
            // 
            this.rtbxLog.Location = new System.Drawing.Point(277, 599);
            this.rtbxLog.Name = "rtbxLog";
            this.rtbxLog.Size = new System.Drawing.Size(426, 96);
            this.rtbxLog.TabIndex = 15;
            this.rtbxLog.Text = "";
            // 
            // backgroundWorkerCargaDatos
            // 
            this.backgroundWorkerCargaDatos.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerCargaDatos_DoWork);
            this.backgroundWorkerCargaDatos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerCargaDatos_RunWorkerCompleted);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::ZkManagement.Properties.Resources.delete;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(843, 551);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnDescargar
            // 
            this.btnDescargar.Image = global::ZkManagement.Properties.Resources.download2;
            this.btnDescargar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDescargar.Location = new System.Drawing.Point(586, 551);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(105, 38);
            this.btnDescargar.TabIndex = 9;
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDescargar.UseVisualStyleBackColor = true;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Image = global::ZkManagement.Properties.Resources.upload;
            this.btnCargar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCargar.Location = new System.Drawing.Point(164, 551);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(105, 38);
            this.btnCargar.TabIndex = 8;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // SincronizarDispositivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 698);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.rtbxLog);
            this.Controls.Add(this.checkTodosLocal);
            this.Controls.Add(this.checkTodos);
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDispositivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLocal);
            this.Controls.Add(this.groupSeleccion);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SincronizarDispositivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SincronizarDispositivo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SincronizarDispositivo_FormClosing);
            this.Load += new System.EventHandler(this.SincronizarDispositivo_Load);
            this.groupSeleccion.ResumeLayout(false);
            this.groupSeleccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispositivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboRelojes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.GroupBox groupSeleccion;
        private System.Windows.Forms.DataGridView dgvLocal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDispositivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.CheckBox checkTodos;
        private System.Windows.Forms.CheckBox checkTodosLocal;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSincronizacion;
        private System.Windows.Forms.RichTextBox rtbxLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Privilegios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarjeta;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCargaDatos;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Leg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pin;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Privilegio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccion;
    }
}