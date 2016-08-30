namespace ZkManagement.Interfaz
{
    partial class Empleados
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
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Privilegio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupEmpleados = new System.Windows.Forms.GroupBox();
            this.lblNivel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSinc = new System.Windows.Forms.Button();
            this.chckTodos = new System.Windows.Forms.CheckBox();
            this.tvDeptos = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.groupEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowDrop = true;
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToOrderColumns = true;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Legajo,
            this.Nombre,
            this.Tarjeta,
            this.DNI,
            this.Pin,
            this.Privilegio,
            this.Cant,
            this.Eliminar,
            this.EmpId});
            this.dgvEmpleados.Location = new System.Drawing.Point(119, 73);
            this.dgvEmpleados.MultiSelect = false;
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(705, 271);
            this.dgvEmpleados.TabIndex = 1;
            this.dgvEmpleados.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmpleados_ColumnHeaderMouseClick);
            this.dgvEmpleados.SelectionChanged += new System.EventHandler(this.dgvEmpleados_SelectionChanged_1);
            // 
            // Legajo
            // 
            this.Legajo.DataPropertyName = "Legajo";
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            this.Legajo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Legajo.Width = 75;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.FillWeight = 150F;
            this.Nombre.HeaderText = "Nombre y Apellido";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Nombre.Width = 150;
            // 
            // Tarjeta
            // 
            this.Tarjeta.DataPropertyName = "Tarjeta";
            this.Tarjeta.HeaderText = "Tarjeta";
            this.Tarjeta.Name = "Tarjeta";
            this.Tarjeta.ReadOnly = true;
            this.Tarjeta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // DNI
            // 
            this.DNI.DataPropertyName = "DNI";
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            this.Privilegio.Width = 50;
            // 
            // Cant
            // 
            this.Cant.DataPropertyName = "Cant";
            this.Cant.HeaderText = "Cant. Huellas";
            this.Cant.Name = "Cant";
            this.Cant.ReadOnly = true;
            this.Cant.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Cant.Width = 50;
            // 
            // Eliminar
            // 
            this.Eliminar.DataPropertyName = "(ninguno)";
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 89;
            // 
            // EmpId
            // 
            this.EmpId.DataPropertyName = "IdEmpleado";
            this.EmpId.HeaderText = "EmpId";
            this.EmpId.Name = "EmpId";
            this.EmpId.ReadOnly = true;
            this.EmpId.Visible = false;
            // 
            // groupEmpleados
            // 
            this.groupEmpleados.Controls.Add(this.lblNivel);
            this.groupEmpleados.Controls.Add(this.label7);
            this.groupEmpleados.Controls.Add(this.btnGuardar);
            this.groupEmpleados.Controls.Add(this.btnCancelar);
            this.groupEmpleados.Controls.Add(this.txtPin);
            this.groupEmpleados.Controls.Add(this.label6);
            this.groupEmpleados.Controls.Add(this.txtDNI);
            this.groupEmpleados.Controls.Add(this.label5);
            this.groupEmpleados.Controls.Add(this.txtLegajo);
            this.groupEmpleados.Controls.Add(this.txtTarjeta);
            this.groupEmpleados.Controls.Add(this.label4);
            this.groupEmpleados.Controls.Add(this.label3);
            this.groupEmpleados.Controls.Add(this.txtNombre);
            this.groupEmpleados.Controls.Add(this.label1);
            this.groupEmpleados.Enabled = false;
            this.groupEmpleados.Location = new System.Drawing.Point(91, 396);
            this.groupEmpleados.Name = "groupEmpleados";
            this.groupEmpleados.Size = new System.Drawing.Size(678, 151);
            this.groupEmpleados.TabIndex = 3;
            this.groupEmpleados.TabStop = false;
            this.groupEmpleados.Text = "Modificar Empleados";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(50, 67);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(14, 13);
            this.lblNivel.TabIndex = 15;
            this.lblNivel.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nivel:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::ZkManagement.Properties.Resources.save;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(343, 103);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 40);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::ZkManagement.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(158, 103);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 40);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(547, 32);
            this.txtPin.MaxLength = 5;
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(100, 22);
            this.txtPin.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(509, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pin:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(547, 61);
            this.txtDNI.MaxLength = 12;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(110, 22);
            this.txtDNI.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(509, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "DNI:";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(413, 32);
            this.txtLegajo.MaxLength = 20;
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(79, 22);
            this.txtLegajo.TabIndex = 4;
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Location = new System.Drawing.Point(387, 61);
            this.txtTarjeta.MaxLength = 10;
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(105, 22);
            this.txtTarjeta.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tarjeta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Legajo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(59, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(280, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::ZkManagement.Properties.Resources.delete;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(744, 355);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(80, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::ZkManagement.Properties.Resources.new1;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.Location = new System.Drawing.Point(461, 350);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(96, 38);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::ZkManagement.Properties.Resources.edit;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(334, 350);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(96, 38);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(264, 45);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(193, 22);
            this.txtBuscar.TabIndex = 9;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(208, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Buscar:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ZkManagement.Properties.Resources.search_grande;
            this.pictureBox1.Location = new System.Drawing.Point(461, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 26);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnSinc
            // 
            this.btnSinc.Image = global::ZkManagement.Properties.Resources.sinc2;
            this.btnSinc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSinc.Location = new System.Drawing.Point(546, 44);
            this.btnSinc.Name = "btnSinc";
            this.btnSinc.Size = new System.Drawing.Size(136, 23);
            this.btnSinc.TabIndex = 12;
            this.btnSinc.Text = "Sinc. con Dispositivo";
            this.btnSinc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSinc.UseVisualStyleBackColor = true;
            this.btnSinc.Click += new System.EventHandler(this.button1_Click);
            // 
            // chckTodos
            // 
            this.chckTodos.AutoSize = true;
            this.chckTodos.Location = new System.Drawing.Point(768, 50);
            this.chckTodos.Name = "chckTodos";
            this.chckTodos.Size = new System.Drawing.Size(56, 17);
            this.chckTodos.TabIndex = 13;
            this.chckTodos.Text = "Todos";
            this.chckTodos.UseVisualStyleBackColor = true;
            this.chckTodos.CheckedChanged += new System.EventHandler(this.chckTodos_CheckedChanged);
            // 
            // tvDeptos
            // 
            this.tvDeptos.Location = new System.Drawing.Point(12, 90);
            this.tvDeptos.Name = "tvDeptos";
            this.tvDeptos.Size = new System.Drawing.Size(75, 163);
            this.tvDeptos.TabIndex = 14;
            this.tvDeptos.Visible = false;
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 550);
            this.Controls.Add(this.tvDeptos);
            this.Controls.Add(this.chckTodos);
            this.Controls.Add(this.btnSinc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.groupEmpleados);
            this.Controls.Add(this.dgvEmpleados);
            this.Name = "Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            this.Controls.SetChildIndex(this.btnCerrar, 0);
            this.Controls.SetChildIndex(this.dgvEmpleados, 0);
            this.Controls.SetChildIndex(this.groupEmpleados, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.txtBuscar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.btnSinc, 0);
            this.Controls.SetChildIndex(this.chckTodos, 0);
            this.Controls.SetChildIndex(this.tvDeptos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.groupEmpleados.ResumeLayout(false);
            this.groupEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.GroupBox groupEmpleados;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTarjeta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSinc;
        private System.Windows.Forms.CheckBox chckTodos;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Privilegio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpId;
        private System.Windows.Forms.TreeView tvDeptos;
    }
}