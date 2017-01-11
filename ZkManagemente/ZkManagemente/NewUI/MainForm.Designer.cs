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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnPersonal = new MetroFramework.Controls.MetroButton();
            this.btnEquipos = new MetroFramework.Controls.MetroButton();
            this.btnUsuarios = new MetroFramework.Controls.MetroButton();
            this.pHeader = new System.Windows.Forms.Panel();
            this.mainPanel = new MetroFramework.Controls.MetroPanel();
            this.tableMenu.SuspendLayout();
            this.pHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableMenu
            // 
            resources.ApplyResources(this.tableMenu, "tableMenu");
            this.tableMenu.Controls.Add(this.btnPersonal, 0, 0);
            this.tableMenu.Controls.Add(this.btnEquipos, 1, 0);
            this.tableMenu.Controls.Add(this.btnUsuarios, 2, 0);
            this.tableMenu.Name = "tableMenu";
            // 
            // btnPersonal
            // 
            this.btnPersonal.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonal.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPersonal.ForeColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btnPersonal, "btnPersonal");
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnPersonal.UseCustomBackColor = true;
            this.btnPersonal.UseSelectable = true;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // btnEquipos
            // 
            this.btnEquipos.BackColor = System.Drawing.Color.Transparent;
            this.btnEquipos.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnEquipos.ForeColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btnEquipos, "btnEquipos");
            this.btnEquipos.Name = "btnEquipos";
            this.btnEquipos.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnEquipos.UseCustomBackColor = true;
            this.btnEquipos.UseSelectable = true;
            this.btnEquipos.Click += new System.EventHandler(this.btnEquipos_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnUsuarios.ForeColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btnUsuarios, "btnUsuarios");
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnUsuarios.UseCustomBackColor = true;
            this.btnUsuarios.UseSelectable = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // pHeader
            // 
            this.pHeader.Controls.Add(this.tableMenu);
            resources.ApplyResources(this.pHeader, "pHeader");
            this.pHeader.Name = "pHeader";
            // 
            // mainPanel
            // 
            resources.ApplyResources(this.mainPanel, "mainPanel");
            this.mainPanel.HorizontalScrollbarBarColor = true;
            this.mainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mainPanel.HorizontalScrollbarSize = 10;
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.VerticalScrollbarBarColor = true;
            this.mainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mainPanel.VerticalScrollbarSize = 10;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.pHeader);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.HelpButton = true;
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableMenu.ResumeLayout(false);
            this.pHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableMenu;
        private MetroFramework.Controls.MetroButton btnEquipos;
        private MetroFramework.Controls.MetroButton btnUsuarios;
        private MetroFramework.Controls.MetroButton btnPersonal;
        private Panel pHeader;
        private MetroFramework.Controls.MetroPanel mainPanel;
    }
}