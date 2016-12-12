namespace ZkManagement.NewUI.Generic
{
    partial class PanelUsuario
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
            this.gridUsuarios = new MetroFramework.Controls.MetroGrid();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UltAcceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPermisos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Permisos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.linkContraseña = new MetroFramework.Controls.MetroLink();
            this.linkNuevo = new MetroFramework.Controls.MetroLink();
            this.linkEdit = new MetroFramework.Controls.MetroLink();
            this.linkDelete = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridUsuarios
            // 
            this.gridUsuarios.AllowUserToAddRows = false;
            this.gridUsuarios.AllowUserToDeleteRows = false;
            this.gridUsuarios.AllowUserToResizeRows = false;
            this.gridUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usuario,
            this.UltAcceso,
            this.IdPermisos,
            this.IdUsuario,
            this.Permisos,
            this.Contraseña});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridUsuarios.EnableHeadersVisualStyles = false;
            this.gridUsuarios.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridUsuarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridUsuarios.Location = new System.Drawing.Point(174, 79);
            this.gridUsuarios.Name = "gridUsuarios";
            this.gridUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUsuarios.Size = new System.Drawing.Size(638, 362);
            this.gridUsuarios.TabIndex = 1;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "Usuario";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // UltAcceso
            // 
            this.UltAcceso.DataPropertyName = "UltAcceso";
            this.UltAcceso.HeaderText = "Utlimo Acceso";
            this.UltAcceso.Name = "UltAcceso";
            this.UltAcceso.ReadOnly = true;
            // 
            // IdPermisos
            // 
            this.IdPermisos.DataPropertyName = "IdPermisos";
            this.IdPermisos.HeaderText = "IdPermisos";
            this.IdPermisos.Name = "IdPermisos";
            this.IdPermisos.ReadOnly = true;
            this.IdPermisos.Visible = false;
            // 
            // IdUsuario
            // 
            this.IdUsuario.DataPropertyName = "IdUsuario";
            this.IdUsuario.HeaderText = "IdUsuario";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            this.IdUsuario.Visible = false;
            // 
            // Permisos
            // 
            this.Permisos.DataPropertyName = "Permisos";
            this.Permisos.HeaderText = "Permisos";
            this.Permisos.Name = "Permisos";
            this.Permisos.ReadOnly = true;
            // 
            // Contraseña
            // 
            this.Contraseña.DataPropertyName = "Contraseña";
            this.Contraseña.HeaderText = "Contraseña";
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.ReadOnly = true;
            this.Contraseña.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.linkContraseña, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.linkNuevo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.linkEdit, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.linkDelete, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(174, 13);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(535, 30);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // linkContraseña
            // 
            this.linkContraseña.Location = new System.Drawing.Point(402, 3);
            this.linkContraseña.Name = "linkContraseña";
            this.linkContraseña.Size = new System.Drawing.Size(130, 23);
            this.linkContraseña.TabIndex = 3;
            this.linkContraseña.Text = "Modificar Contraseña";
            this.linkContraseña.UseSelectable = true;
            this.linkContraseña.Click += new System.EventHandler(this.linkContraseña_Click);
            // 
            // linkNuevo
            // 
            this.linkNuevo.Location = new System.Drawing.Point(3, 3);
            this.linkNuevo.Name = "linkNuevo";
            this.linkNuevo.Size = new System.Drawing.Size(127, 24);
            this.linkNuevo.TabIndex = 0;
            this.linkNuevo.Text = "Nuevo";
            this.linkNuevo.UseSelectable = true;
            this.linkNuevo.Click += new System.EventHandler(this.linkNuevo_Click);
            // 
            // linkEdit
            // 
            this.linkEdit.Location = new System.Drawing.Point(136, 3);
            this.linkEdit.Name = "linkEdit";
            this.linkEdit.Size = new System.Drawing.Size(127, 24);
            this.linkEdit.TabIndex = 1;
            this.linkEdit.Text = "Editar";
            this.linkEdit.UseSelectable = true;
            this.linkEdit.Click += new System.EventHandler(this.linkEdit_Click);
            // 
            // linkDelete
            // 
            this.linkDelete.Location = new System.Drawing.Point(269, 3);
            this.linkDelete.Name = "linkDelete";
            this.linkDelete.Size = new System.Drawing.Size(127, 23);
            this.linkDelete.TabIndex = 2;
            this.linkDelete.Text = "Eliminar";
            this.linkDelete.UseSelectable = true;
            // 
            // PanelUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.gridUsuarios);
            this.Name = "PanelUsuario";
            this.Controls.SetChildIndex(this.gridUsuarios, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid gridUsuarios;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroLink linkNuevo;
        private MetroFramework.Controls.MetroLink linkEdit;
        private MetroFramework.Controls.MetroLink linkDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn UltAcceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPermisos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Permisos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contraseña;
        private MetroFramework.Controls.MetroLink linkContraseña;
    }
}
