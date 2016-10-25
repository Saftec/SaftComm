namespace ZkManagement.NewUI
{
    partial class Main
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
            this.lblOff = new MetroFramework.Controls.MetroLabel();
            this.btnDispositivos = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // lblOff
            // 
            this.lblOff.AutoSize = true;
            this.lblOff.Location = new System.Drawing.Point(347, 38);
            this.lblOff.Name = "lblOff";
            this.lblOff.Size = new System.Drawing.Size(0, 0);
            this.lblOff.TabIndex = 0;
            this.lblOff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDispositivos
            // 
            this.btnDispositivos.ActiveControl = null;
            this.btnDispositivos.BackColor = System.Drawing.Color.White;
            this.btnDispositivos.Location = new System.Drawing.Point(184, 95);
            this.btnDispositivos.Name = "btnDispositivos";
            this.btnDispositivos.Size = new System.Drawing.Size(75, 23);
            this.btnDispositivos.TabIndex = 1;
            this.btnDispositivos.Text = "Dispositivos";
            this.btnDispositivos.UseSelectable = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 638);
            this.Controls.Add(this.btnDispositivos);
            this.Controls.Add(this.lblOff);
            this.Name = "Main";
            this.Text = "SaftComm";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblOff;
        private MetroFramework.Controls.MetroTile btnDispositivos;
    }
}