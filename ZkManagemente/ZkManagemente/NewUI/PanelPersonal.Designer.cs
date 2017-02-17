namespace ZkManagement.NewUI.Generic
{
    partial class PanelPersonal
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
            this.gridPersonal = new MetroFramework.Controls.MetroGrid();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.linkNuevo = new MetroFramework.Controls.MetroLink();
            this.linkEdit = new MetroFramework.Controls.MetroLink();
            this.linkDelete = new MetroFramework.Controls.MetroLink();
            this.txtBuscar = new MetroFramework.Controls.MetroTextBox();
            this.linkSinc = new MetroFramework.Controls.MetroLink();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.rbActivos = new MetroFramework.Controls.MetroRadioButton();
            this.rbBaja = new MetroFramework.Controls.MetroRadioButton();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantHuellas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Privilegio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonal)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridPersonal
            // 
            this.gridPersonal.AllowUserToAddRows = false;
            this.gridPersonal.AllowUserToResizeRows = false;
            this.gridPersonal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridPersonal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPersonal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridPersonal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPersonal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Dni,
            this.Nombre,
            this.Apellido,
            this.Legajo,
            this.CantHuellas,
            this.Tarjeta,
            this.Pin,
            this.Privilegio,
            this.Eliminar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPersonal.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridPersonal.EnableHeadersVisualStyles = false;
            this.gridPersonal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridPersonal.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridPersonal.Location = new System.Drawing.Point(71, 51);
            this.gridPersonal.Name = "gridPersonal";
            this.gridPersonal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPersonal.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridPersonal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPersonal.Size = new System.Drawing.Size(926, 479);
            this.gridPersonal.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.24432F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.24431F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.24431F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.24431F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.005198F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.01754F));
            this.tableLayoutPanel2.Controls.Add(this.linkNuevo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.linkEdit, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.linkDelete, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtBuscar, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.linkSinc, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel1, 4, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(71, 15);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(926, 30);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // linkNuevo
            // 
            this.linkNuevo.Location = new System.Drawing.Point(3, 3);
            this.linkNuevo.Name = "linkNuevo";
            this.linkNuevo.Size = new System.Drawing.Size(127, 24);
            this.linkNuevo.Style = MetroFramework.MetroColorStyle.Blue;
            this.linkNuevo.TabIndex = 0;
            this.linkNuevo.Text = "Nuevo";
            this.linkNuevo.UseSelectable = true;
            this.linkNuevo.UseStyleColors = true;
            this.linkNuevo.Click += new System.EventHandler(this.linkNuevo_Click);
            // 
            // linkEdit
            // 
            this.linkEdit.Location = new System.Drawing.Point(153, 3);
            this.linkEdit.Name = "linkEdit";
            this.linkEdit.Size = new System.Drawing.Size(127, 24);
            this.linkEdit.Style = MetroFramework.MetroColorStyle.Blue;
            this.linkEdit.TabIndex = 1;
            this.linkEdit.Text = "Editar";
            this.linkEdit.UseSelectable = true;
            this.linkEdit.UseStyleColors = true;
            this.linkEdit.Click += new System.EventHandler(this.linkEdit_Click);
            // 
            // linkDelete
            // 
            this.linkDelete.Location = new System.Drawing.Point(303, 3);
            this.linkDelete.Name = "linkDelete";
            this.linkDelete.Size = new System.Drawing.Size(127, 23);
            this.linkDelete.Style = MetroFramework.MetroColorStyle.Blue;
            this.linkDelete.TabIndex = 2;
            this.linkDelete.Text = "Eliminar";
            this.linkDelete.UseSelectable = true;
            this.linkDelete.UseStyleColors = true;
            this.linkDelete.Click += new System.EventHandler(this.linkDelete_Click);
            // 
            // txtBuscar
            // 
            // 
            // 
            // 
            this.txtBuscar.CustomButton.Image = null;
            this.txtBuscar.CustomButton.Location = new System.Drawing.Point(209, 1);
            this.txtBuscar.CustomButton.Name = "";
            this.txtBuscar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBuscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBuscar.CustomButton.TabIndex = 1;
            this.txtBuscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBuscar.CustomButton.UseSelectable = true;
            this.txtBuscar.CustomButton.Visible = false;
            this.txtBuscar.Lines = new string[0];
            this.txtBuscar.Location = new System.Drawing.Point(677, 3);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.ShortcutsEnabled = true;
            this.txtBuscar.Size = new System.Drawing.Size(231, 23);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.UseSelectable = true;
            this.txtBuscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBuscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // linkSinc
            // 
            this.linkSinc.Location = new System.Drawing.Point(453, 3);
            this.linkSinc.Name = "linkSinc";
            this.linkSinc.Size = new System.Drawing.Size(127, 23);
            this.linkSinc.Style = MetroFramework.MetroColorStyle.Blue;
            this.linkSinc.TabIndex = 5;
            this.linkSinc.Text = "Sinc. Dispositivo";
            this.linkSinc.UseSelectable = true;
            this.linkSinc.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.metroLabel1.Location = new System.Drawing.Point(607, 5);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(7, 5, 3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Buscar:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // rbActivos
            // 
            this.rbActivos.AutoSize = true;
            this.rbActivos.Location = new System.Drawing.Point(3, 246);
            this.rbActivos.Name = "rbActivos";
            this.rbActivos.Size = new System.Drawing.Size(62, 15);
            this.rbActivos.TabIndex = 5;
            this.rbActivos.Text = "Activos";
            this.rbActivos.UseSelectable = true;
            this.rbActivos.CheckedChanged += new System.EventHandler(this.rbActivos_CheckedChanged);
            // 
            // rbBaja
            // 
            this.rbBaja.AutoSize = true;
            this.rbBaja.Location = new System.Drawing.Point(3, 281);
            this.rbBaja.Name = "rbBaja";
            this.rbBaja.Size = new System.Drawing.Size(62, 15);
            this.rbBaja.TabIndex = 6;
            this.rbBaja.Text = "De Baja";
            this.rbBaja.UseSelectable = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "IdEmpleado";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Dni
            // 
            this.Dni.DataPropertyName = "DNI";
            this.Dni.HeaderText = "DNI";
            this.Dni.Name = "Dni";
            this.Dni.ReadOnly = true;
            this.Dni.Width = 60;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 125;
            // 
            // Legajo
            // 
            this.Legajo.DataPropertyName = "Legajo";
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            this.Legajo.Width = 80;
            // 
            // CantHuellas
            // 
            this.CantHuellas.DataPropertyName = "Cant";
            this.CantHuellas.HeaderText = "Cant. Huellas";
            this.CantHuellas.Name = "CantHuellas";
            this.CantHuellas.ReadOnly = true;
            // 
            // Tarjeta
            // 
            this.Tarjeta.DataPropertyName = "Tarjeta";
            this.Tarjeta.HeaderText = "Tarjeta";
            this.Tarjeta.Name = "Tarjeta";
            this.Tarjeta.ReadOnly = true;
            // 
            // Pin
            // 
            this.Pin.DataPropertyName = "Pin";
            this.Pin.HeaderText = "Pin";
            this.Pin.Name = "Pin";
            this.Pin.ReadOnly = true;
            // 
            // Privilegio
            // 
            this.Privilegio.DataPropertyName = "Privilegio";
            this.Privilegio.HeaderText = "Privilegio";
            this.Privilegio.Name = "Privilegio";
            this.Privilegio.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 60;
            // 
            // PanelPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbBaja);
            this.Controls.Add(this.rbActivos);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.gridPersonal);
            this.Name = "PanelPersonal";
            this.Controls.SetChildIndex(this.gridPersonal, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            this.Controls.SetChildIndex(this.rbActivos, 0);
            this.Controls.SetChildIndex(this.rbBaja, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonal)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid gridPersonal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroLink linkNuevo;
        private MetroFramework.Controls.MetroLink linkEdit;
        private MetroFramework.Controls.MetroLink linkDelete;
        private MetroFramework.Controls.MetroTextBox txtBuscar;
        private MetroFramework.Controls.MetroLink linkSinc;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroRadioButton rbActivos;
        private MetroFramework.Controls.MetroRadioButton rbBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantHuellas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Privilegio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
    }
}
