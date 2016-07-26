namespace ZkManagement.Interfaz
{
    partial class Relojes
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
            this.dgvRelojes = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puerto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantRegis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbxRutinas = new System.Windows.Forms.GroupBox();
            this.btnRutinaHora = new System.Windows.Forms.Button();
            this.btnRutinaBajar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupManuales = new System.Windows.Forms.GroupBox();
            this.btnHora = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelojes)).BeginInit();
            this.gpbxRutinas.SuspendLayout();
            this.groupManuales.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRelojes
            // 
            this.dgvRelojes.AllowUserToOrderColumns = true;
            this.dgvRelojes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelojes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Puerto,
            this.IP,
            this.Nombre,
            this.CantRegis,
            this.Mac,
            this.Estado,
            this.Modelo});
            this.dgvRelojes.Location = new System.Drawing.Point(24, 116);
            this.dgvRelojes.MultiSelect = false;
            this.dgvRelojes.Name = "dgvRelojes";
            this.dgvRelojes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRelojes.Size = new System.Drawing.Size(839, 215);
            this.dgvRelojes.TabIndex = 0;
            this.dgvRelojes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRelojes_CellContentClick);
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Puerto
            // 
            this.Puerto.HeaderText = "Puerto";
            this.Puerto.Name = "Puerto";
            this.Puerto.ReadOnly = true;
            // 
            // IP
            // 
            this.IP.HeaderText = "IP V4";
            this.IP.Name = "IP";
            this.IP.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // CantRegis
            // 
            this.CantRegis.HeaderText = "Cantidad Registros";
            this.CantRegis.Name = "CantRegis";
            this.CantRegis.ReadOnly = true;
            // 
            // Mac
            // 
            this.Mac.HeaderText = "Mac Address";
            this.Mac.Name = "Mac";
            this.Mac.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // gpbxRutinas
            // 
            this.gpbxRutinas.Controls.Add(this.btnRutinaHora);
            this.gpbxRutinas.Controls.Add(this.btnRutinaBajar);
            this.gpbxRutinas.Location = new System.Drawing.Point(24, 46);
            this.gpbxRutinas.Name = "gpbxRutinas";
            this.gpbxRutinas.Size = new System.Drawing.Size(212, 55);
            this.gpbxRutinas.TabIndex = 1;
            this.gpbxRutinas.TabStop = false;
            this.gpbxRutinas.Text = "Rutinas";
            // 
            // btnRutinaHora
            // 
            this.btnRutinaHora.Location = new System.Drawing.Point(105, 19);
            this.btnRutinaHora.Name = "btnRutinaHora";
            this.btnRutinaHora.Size = new System.Drawing.Size(92, 23);
            this.btnRutinaHora.TabIndex = 1;
            this.btnRutinaHora.Text = "Sinc. Hora";
            this.btnRutinaHora.UseVisualStyleBackColor = true;
            // 
            // btnRutinaBajar
            // 
            this.btnRutinaBajar.Location = new System.Drawing.Point(7, 20);
            this.btnRutinaBajar.Name = "btnRutinaBajar";
            this.btnRutinaBajar.Size = new System.Drawing.Size(92, 23);
            this.btnRutinaBajar.TabIndex = 0;
            this.btnRutinaBajar.Text = "Bajar Registros";
            this.btnRutinaBajar.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(836, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 27);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupManuales
            // 
            this.groupManuales.Controls.Add(this.btnHora);
            this.groupManuales.Controls.Add(this.btnBorrar);
            this.groupManuales.Controls.Add(this.btnDescargar);
            this.groupManuales.Location = new System.Drawing.Point(498, 46);
            this.groupManuales.Name = "groupManuales";
            this.groupManuales.Size = new System.Drawing.Size(326, 55);
            this.groupManuales.TabIndex = 3;
            this.groupManuales.TabStop = false;
            this.groupManuales.Text = "Operaciones Manuales";
            // 
            // btnHora
            // 
            this.btnHora.Location = new System.Drawing.Point(227, 19);
            this.btnHora.Name = "btnHora";
            this.btnHora.Size = new System.Drawing.Size(90, 23);
            this.btnHora.TabIndex = 2;
            this.btnHora.Text = "Sinc. Hora";
            this.btnHora.UseVisualStyleBackColor = true;
            this.btnHora.Click += new System.EventHandler(this.btnHora_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(117, 20);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(90, 23);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "Borrar Regs";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnDescargar
            // 
            this.btnDescargar.Location = new System.Drawing.Point(6, 20);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(90, 23);
            this.btnDescargar.TabIndex = 0;
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.UseVisualStyleBackColor = true;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(267, 53);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(98, 45);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(383, 53);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(98, 45);
            this.btnDesconectar.TabIndex = 1;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Location = new System.Drawing.Point(298, 343);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 47);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editar Equipos";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(200, 17);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(108, 17);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(6, 18);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Relojes";
            // 
            // Relojes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.groupManuales);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gpbxRutinas);
            this.Controls.Add(this.dgvRelojes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Relojes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relojes";
            this.Load += new System.EventHandler(this.Relojes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelojes)).EndInit();
            this.gpbxRutinas.ResumeLayout(false);
            this.groupManuales.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRelojes;
        private System.Windows.Forms.GroupBox gpbxRutinas;
        private System.Windows.Forms.Button btnRutinaHora;
        private System.Windows.Forms.Button btnRutinaBajar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupManuales;
        private System.Windows.Forms.Button btnHora;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puerto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantRegis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
    }
}