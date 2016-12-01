using System.Windows.Forms;

namespace ZkManagement.NewUI
{
    partial class MainForm
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
            this.btnPersonal = new MetroFramework.Controls.MetroButton();
            this.btnEquipos = new MetroFramework.Controls.MetroButton();
            this.btnUsuarios = new MetroFramework.Controls.MetroButton();
            this.MainPanel = new MetroFramework.Controls.MetroPanel();
            this.tableMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableMenu
            // 
            this.tableMenu.ColumnCount = 4;
            this.tableMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableMenu.Controls.Add(this.btnPersonal, 0, 0);
            this.tableMenu.Controls.Add(this.btnEquipos, 1, 0);
            this.tableMenu.Controls.Add(this.btnUsuarios, 2, 0);
            this.tableMenu.Location = new System.Drawing.Point(235, 10);
            this.tableMenu.Margin = new System.Windows.Forms.Padding(4);
            this.tableMenu.Name = "tableMenu";
            this.tableMenu.RowCount = 1;
            this.tableMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMenu.Size = new System.Drawing.Size(577, 75);
            this.tableMenu.TabIndex = 1;
            // 
            // btnPersonal
            // 
            this.btnPersonal.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonal.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPersonal.ForeColor = System.Drawing.Color.Red;
            this.btnPersonal.Location = new System.Drawing.Point(3, 3);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(138, 69);
            this.btnPersonal.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnPersonal.TabIndex = 5;
            this.btnPersonal.Text = "Personal";
            this.btnPersonal.UseCustomBackColor = true;
            this.btnPersonal.UseSelectable = true;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // btnEquipos
            // 
            this.btnEquipos.BackColor = System.Drawing.Color.Transparent;
            this.btnEquipos.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnEquipos.ForeColor = System.Drawing.Color.Red;
            this.btnEquipos.Location = new System.Drawing.Point(147, 3);
            this.btnEquipos.Name = "btnEquipos";
            this.btnEquipos.Size = new System.Drawing.Size(138, 69);
            this.btnEquipos.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnEquipos.TabIndex = 3;
            this.btnEquipos.Text = "Equipos";
            this.btnEquipos.UseCustomBackColor = true;
            this.btnEquipos.UseSelectable = true;
            this.btnEquipos.Click += new System.EventHandler(this.btnEquipos_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnUsuarios.ForeColor = System.Drawing.Color.Red;
            this.btnUsuarios.Location = new System.Drawing.Point(291, 3);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(138, 69);
            this.btnUsuarios.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnUsuarios.TabIndex = 4;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseCustomBackColor = true;
            this.btnUsuarios.UseSelectable = true;
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.AutoSize = true;
            this.MainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainPanel.HorizontalScrollbarBarColor = true;
            this.MainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.MainPanel.HorizontalScrollbarSize = 13;
            this.MainPanel.Location = new System.Drawing.Point(48, 105);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(0, 0);
            this.MainPanel.TabIndex = 2;
            this.MainPanel.VerticalScrollbarBarColor = true;
            this.MainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.MainPanel.VerticalScrollbarSize = 15;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 779);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.tableMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(30, 78, 30, 26);
            this.Text = "SaftComm";
            this.tableMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableMenu;
        private MetroFramework.Controls.MetroPanel MainPanel;
        private MetroFramework.Controls.MetroButton btnEquipos;
        private MetroFramework.Controls.MetroButton btnUsuarios;
        private MetroFramework.Controls.MetroButton btnPersonal;
    }
}