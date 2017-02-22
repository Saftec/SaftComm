using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZkManagement.NewUI.PanelesConfigs
{
    public partial class PanelGral : GenericConfigsPanel
    {
        private MetroFramework.Controls.MetroCheckBox chckIniciarWindows;

        private void InitializeComponent()
        {
            this.chckIniciarWindows = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // chckIniciarWindows
            // 
            this.chckIniciarWindows.AutoSize = true;
            this.chckIniciarWindows.Location = new System.Drawing.Point(210, 108);
            this.chckIniciarWindows.Name = "chckIniciarWindows";
            this.chckIniciarWindows.Size = new System.Drawing.Size(189, 15);
            this.chckIniciarWindows.Style = MetroFramework.MetroColorStyle.Blue;
            this.chckIniciarWindows.TabIndex = 3;
            this.chckIniciarWindows.Text = "Iniciar Aplicación con Windows";
            this.chckIniciarWindows.UseSelectable = true;
            this.chckIniciarWindows.UseStyleColors = true;
            // 
            // PanelGral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.chckIniciarWindows);
            this.Name = "PanelGral";
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.chckIniciarWindows, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
