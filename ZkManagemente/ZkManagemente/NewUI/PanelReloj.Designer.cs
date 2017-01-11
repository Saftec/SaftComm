﻿namespace ZkManagement.NewUI
{
    partial class PanelReloj
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridEquipos = new MetroFramework.Controls.MetroGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puerto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Regs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.linkNuevo = new MetroFramework.Controls.MetroLink();
            this.linkEdit = new MetroFramework.Controls.MetroLink();
            this.linkDelete = new MetroFramework.Controls.MetroLink();
            this.linkConnect = new MetroFramework.Controls.MetroLink();
            this.linkDesconnect = new MetroFramework.Controls.MetroLink();
            this.linkSincHora = new MetroFramework.Controls.MetroLink();
            this.linkDescRegs = new MetroFramework.Controls.MetroLink();
            this.linkBorrarRegs = new MetroFramework.Controls.MetroLink();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridEquipos)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridEquipos
            // 
            this.gridEquipos.AllowUserToAddRows = false;
            this.gridEquipos.AllowUserToResizeRows = false;
            this.gridEquipos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridEquipos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridEquipos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridEquipos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridEquipos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.gridEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEquipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DNS,
            this.Nombre,
            this.IP,
            this.Puerto,
            this.Numero,
            this.Estado,
            this.Modelo,
            this.Clave,
            this.Regs});
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridEquipos.DefaultCellStyle = dataGridViewCellStyle26;
            this.gridEquipos.EnableHeadersVisualStyles = false;
            this.gridEquipos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridEquipos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridEquipos.Location = new System.Drawing.Point(32, 38);
            this.gridEquipos.Name = "gridEquipos";
            this.gridEquipos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridEquipos.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.gridEquipos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEquipos.Size = new System.Drawing.Size(852, 378);
            this.gridEquipos.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "IdReloj";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // DNS
            // 
            this.DNS.DataPropertyName = "DNS";
            this.DNS.HeaderText = "DNS";
            this.DNS.Name = "DNS";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // IP
            // 
            this.IP.DataPropertyName = "IP";
            this.IP.HeaderText = "Dir. Ip";
            this.IP.Name = "IP";
            this.IP.ReadOnly = true;
            // 
            // Puerto
            // 
            this.Puerto.DataPropertyName = "Puerto";
            this.Puerto.HeaderText = "Puerto";
            this.Puerto.Name = "Puerto";
            this.Puerto.ReadOnly = true;
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "Numero";
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "Modelo";
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // Clave
            // 
            this.Clave.DataPropertyName = "Clave";
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            this.Clave.Visible = false;
            // 
            // Regs
            // 
            this.Regs.DataPropertyName = "Regs";
            this.Regs.HeaderText = "Cant. Regs.";
            this.Regs.Name = "Regs";
            this.Regs.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.linkNuevo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.linkEdit, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.linkDelete, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.linkConnect, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.linkDesconnect, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.linkSincHora, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.linkDescRegs, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.linkBorrarRegs, 7, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(32, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(744, 29);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // linkNuevo
            // 
            this.linkNuevo.Location = new System.Drawing.Point(3, 3);
            this.linkNuevo.Name = "linkNuevo";
            this.linkNuevo.Size = new System.Drawing.Size(87, 23);
            this.linkNuevo.TabIndex = 3;
            this.linkNuevo.Text = "Nuevo";
            this.linkNuevo.UseSelectable = true;
            this.linkNuevo.Click += new System.EventHandler(this.linkNuevo_Click);
            // 
            // linkEdit
            // 
            this.linkEdit.Location = new System.Drawing.Point(96, 3);
            this.linkEdit.Name = "linkEdit";
            this.linkEdit.Size = new System.Drawing.Size(87, 23);
            this.linkEdit.TabIndex = 4;
            this.linkEdit.Text = "Editar";
            this.linkEdit.UseSelectable = true;
            this.linkEdit.Click += new System.EventHandler(this.linkEdit_Click);
            // 
            // linkDelete
            // 
            this.linkDelete.Location = new System.Drawing.Point(189, 3);
            this.linkDelete.Name = "linkDelete";
            this.linkDelete.Size = new System.Drawing.Size(87, 23);
            this.linkDelete.TabIndex = 5;
            this.linkDelete.Text = "Eliminar";
            this.linkDelete.UseSelectable = true;
            this.linkDelete.Click += new System.EventHandler(this.linkDelete_Click);
            // 
            // linkConnect
            // 
            this.linkConnect.Location = new System.Drawing.Point(282, 3);
            this.linkConnect.Name = "linkConnect";
            this.linkConnect.Size = new System.Drawing.Size(87, 23);
            this.linkConnect.TabIndex = 6;
            this.linkConnect.Text = "Conectar";
            this.linkConnect.UseSelectable = true;
            this.linkConnect.Click += new System.EventHandler(this.linkConnect_Click);
            // 
            // linkDesconnect
            // 
            this.linkDesconnect.Location = new System.Drawing.Point(375, 3);
            this.linkDesconnect.Name = "linkDesconnect";
            this.linkDesconnect.Size = new System.Drawing.Size(87, 23);
            this.linkDesconnect.TabIndex = 7;
            this.linkDesconnect.Text = "Desconectar";
            this.linkDesconnect.UseSelectable = true;
            this.linkDesconnect.Click += new System.EventHandler(this.linkDesconnect_Click);
            // 
            // linkSincHora
            // 
            this.linkSincHora.Location = new System.Drawing.Point(468, 3);
            this.linkSincHora.Name = "linkSincHora";
            this.linkSincHora.Size = new System.Drawing.Size(87, 23);
            this.linkSincHora.TabIndex = 8;
            this.linkSincHora.Text = "Sinc. Hora";
            this.linkSincHora.UseSelectable = true;
            this.linkSincHora.Click += new System.EventHandler(this.linkSincHora_Click);
            // 
            // linkDescRegs
            // 
            this.linkDescRegs.Location = new System.Drawing.Point(561, 3);
            this.linkDescRegs.Name = "linkDescRegs";
            this.linkDescRegs.Size = new System.Drawing.Size(87, 23);
            this.linkDescRegs.TabIndex = 9;
            this.linkDescRegs.Text = "Desc. Regs";
            this.linkDescRegs.UseSelectable = true;
            this.linkDescRegs.Click += new System.EventHandler(this.linkDescRegs_Click);
            // 
            // linkBorrarRegs
            // 
            this.linkBorrarRegs.Location = new System.Drawing.Point(654, 3);
            this.linkBorrarRegs.Name = "linkBorrarRegs";
            this.linkBorrarRegs.Size = new System.Drawing.Size(87, 23);
            this.linkBorrarRegs.TabIndex = 10;
            this.linkBorrarRegs.Text = "Borrar Regs.";
            this.linkBorrarRegs.UseSelectable = true;
            this.linkBorrarRegs.Click += new System.EventHandler(this.linkBorrarRegs_Click);
            // 
            // txtLog
            // 
            this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(159, 486);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(571, 118);
            this.txtLog.TabIndex = 3;
            this.txtLog.Text = "";
            // 
            // NewReloj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gridEquipos);
            this.Name = "NewReloj";
            this.Load += new System.EventHandler(this.NewReloj_Load);
            this.Controls.SetChildIndex(this.gridEquipos, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.txtLog, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridEquipos)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid gridEquipos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puerto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Regs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLink linkNuevo;
        private MetroFramework.Controls.MetroLink linkEdit;
        private MetroFramework.Controls.MetroLink linkDelete;
        private MetroFramework.Controls.MetroLink linkConnect;
        private MetroFramework.Controls.MetroLink linkDesconnect;
        private MetroFramework.Controls.MetroLink linkSincHora;
        private MetroFramework.Controls.MetroLink linkDescRegs;
        private MetroFramework.Controls.MetroLink linkBorrarRegs;
        private System.Windows.Forms.RichTextBox txtLog;
    }
}