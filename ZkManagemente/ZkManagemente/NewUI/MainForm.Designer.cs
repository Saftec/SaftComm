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
            this.linkPersonal = new MetroFramework.Controls.MetroLink();
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
            this.tableMenu.Controls.Add(this.linkPersonal, 0, 0);
            this.tableMenu.Location = new System.Drawing.Point(157, 8);
            this.tableMenu.Name = "tableMenu";
            this.tableMenu.RowCount = 1;
            this.tableMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMenu.Size = new System.Drawing.Size(385, 57);
            this.tableMenu.TabIndex = 1;
            // 
            // linkPersonal
            // 
            this.linkPersonal.BackColor = System.Drawing.Color.Transparent;
            this.linkPersonal.Location = new System.Drawing.Point(3, 3);
            this.linkPersonal.Name = "linkPersonal";
            this.linkPersonal.Size = new System.Drawing.Size(90, 51);
            this.linkPersonal.Style = MetroFramework.MetroColorStyle.Blue;
            this.linkPersonal.TabIndex = 2;
            this.linkPersonal.Text = "Personal";
            this.linkPersonal.UseCustomBackColor = true;
            this.linkPersonal.UseSelectable = true;
            this.linkPersonal.UseStyleColors = true;
            this.linkPersonal.Click += new System.EventHandler(this.linkPersonal_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSize = true;
            this.MainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainPanel.HorizontalScrollbarBarColor = true;
            this.MainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.MainPanel.HorizontalScrollbarSize = 10;
            this.MainPanel.Location = new System.Drawing.Point(6, 71);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(0, 0);
            this.MainPanel.TabIndex = 2;
            this.MainPanel.VerticalScrollbarBarColor = true;
            this.MainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.MainPanel.VerticalScrollbarSize = 10;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 640);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.tableMenu);
            this.Name = "MainForm";
            this.Text = "SaftComm";
            this.tableMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableMenu;
        private MetroFramework.Controls.MetroPanel MainPanel;
        private MetroFramework.Controls.MetroLink linkPersonal;
    }
}