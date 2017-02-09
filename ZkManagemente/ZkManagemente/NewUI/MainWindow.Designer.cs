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
            this.tableMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnSinc = new MetroFramework.Controls.MetroButton();
            this.btnEquipos = new MetroFramework.Controls.MetroButton();
            this.btnUsuarios = new MetroFramework.Controls.MetroButton();
            this.btnPersonal = new MetroFramework.Controls.MetroButton();
            this.btnConfig = new MetroFramework.Controls.MetroButton();
            this.pHeader = new System.Windows.Forms.Panel();
            this.metroPanel = new MetroFramework.Controls.MetroPanel();
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
            this.tableMenu.Controls.Add(this.btnSinc, 0, 0);
            this.tableMenu.Controls.Add(this.btnEquipos, 0, 0);
            this.tableMenu.Controls.Add(this.btnUsuarios, 2, 0);
            this.tableMenu.Controls.Add(this.btnPersonal, 0, 0);
            this.tableMenu.Controls.Add(this.btnConfig, 4, 0);
            this.tableMenu.Location = new System.Drawing.Point(0, 0);
            this.tableMenu.Margin = new System.Windows.Forms.Padding(4);
            this.tableMenu.Name = "tableMenu";
            this.tableMenu.RowCount = 1;
            this.tableMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMenu.Size = new System.Drawing.Size(717, 64);
            this.tableMenu.TabIndex = 2;
            // 
            // btnSinc
            // 
            this.btnSinc.BackColor = System.Drawing.Color.Transparent;
            this.btnSinc.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSinc.ForeColor = System.Drawing.Color.Red;
            this.btnSinc.Location = new System.Drawing.Point(289, 3);
            this.btnSinc.Name = "btnSinc";
            this.btnSinc.Size = new System.Drawing.Size(137, 58);
            this.btnSinc.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnSinc.TabIndex = 8;
            this.btnSinc.Text = "Sincronizacion";
            this.btnSinc.UseCustomBackColor = true;
            this.btnSinc.UseSelectable = true;
            this.btnSinc.UseStyleColors = true;
            this.btnSinc.Click += new System.EventHandler(this.btnSinc_Click);
            // 
            // btnEquipos
            // 
            this.btnEquipos.BackColor = System.Drawing.Color.Transparent;
            this.btnEquipos.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnEquipos.ForeColor = System.Drawing.Color.Red;
            this.btnEquipos.Location = new System.Drawing.Point(146, 3);
            this.btnEquipos.Name = "btnEquipos";
            this.btnEquipos.Size = new System.Drawing.Size(137, 58);
            this.btnEquipos.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnEquipos.TabIndex = 6;
            this.btnEquipos.Text = "Dispositivos";
            this.btnEquipos.UseCustomBackColor = true;
            this.btnEquipos.UseSelectable = true;
            this.btnEquipos.UseStyleColors = true;
            this.btnEquipos.Click += new System.EventHandler(this.btnEquipos_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnUsuarios.ForeColor = System.Drawing.Color.Red;
            this.btnUsuarios.Location = new System.Drawing.Point(432, 3);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(137, 58);
            this.btnUsuarios.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnUsuarios.TabIndex = 4;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseCustomBackColor = true;
            this.btnUsuarios.UseSelectable = true;
            this.btnUsuarios.UseStyleColors = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnPersonal
            // 
            this.btnPersonal.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonal.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPersonal.ForeColor = System.Drawing.Color.Red;
            this.btnPersonal.Location = new System.Drawing.Point(3, 3);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(137, 58);
            this.btnPersonal.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnPersonal.TabIndex = 5;
            this.btnPersonal.Text = "Personal";
            this.btnPersonal.UseCustomBackColor = true;
            this.btnPersonal.UseSelectable = true;
            this.btnPersonal.UseStyleColors = true;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnConfig.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnConfig.ForeColor = System.Drawing.Color.Red;
            this.btnConfig.Location = new System.Drawing.Point(575, 3);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(138, 58);
            this.btnConfig.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnConfig.TabIndex = 7;
            this.btnConfig.Text = "Configuracion";
            this.btnConfig.UseCustomBackColor = true;
            this.btnConfig.UseSelectable = true;
            this.btnConfig.UseStyleColors = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // pHeader
            // 
            this.pHeader.Controls.Add(this.tableMenu);
            this.pHeader.Location = new System.Drawing.Point(175, 6);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(826, 67);
            this.pHeader.TabIndex = 3;
            // 
            // metroPanel
            // 
            this.metroPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroPanel.HorizontalScrollbarBarColor = true;
            this.metroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel.HorizontalScrollbarSize = 10;
            this.metroPanel.Location = new System.Drawing.Point(6, 93);
            this.metroPanel.Name = "metroPanel";
            this.metroPanel.Size = new System.Drawing.Size(995, 583);
            this.metroPanel.TabIndex = 4;
            this.metroPanel.VerticalScrollbarBarColor = true;
            this.metroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel.VerticalScrollbarSize = 10;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 699);
            this.Controls.Add(this.metroPanel);
            this.Controls.Add(this.pHeader);
            this.Name = "MainWindow";
            this.Text = "SaftComm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tableMenu.ResumeLayout(false);
            this.pHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableMenu;
        private MetroFramework.Controls.MetroButton btnPersonal;
        private MetroFramework.Controls.MetroButton btnUsuarios;
        private System.Windows.Forms.Panel pHeader;
        private MetroFramework.Controls.MetroPanel metroPanel;
        private MetroFramework.Controls.MetroButton btnEquipos;
        private MetroFramework.Controls.MetroButton btnConfig;
        private MetroFramework.Controls.MetroButton btnSinc;
    }
}