using System.Drawing;

namespace Reversi_App
{
    partial class Reversi
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
            this.knopNieuwspel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.knopHelp = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelGeel = new System.Windows.Forms.Label();
            this.labelBlauw = new System.Windows.Forms.Label();
            this.panelSpeelveld = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // knopNieuwspel
            // 
            this.knopNieuwspel.Depth = 0;
            this.knopNieuwspel.Location = new System.Drawing.Point(238, 100);
            this.knopNieuwspel.MouseState = MaterialSkin.MouseState.HOVER;
            this.knopNieuwspel.Name = "knopNieuwspel";
            this.knopNieuwspel.Primary = true;
            this.knopNieuwspel.Size = new System.Drawing.Size(124, 37);
            this.knopNieuwspel.TabIndex = 0;
            this.knopNieuwspel.Text = "Nieuw Spel";
            this.knopNieuwspel.UseVisualStyleBackColor = true;
            // 
            // knopHelp
            // 
            this.knopHelp.Depth = 0;
            this.knopHelp.Location = new System.Drawing.Point(260, 143);
            this.knopHelp.MouseState = MaterialSkin.MouseState.HOVER;
            this.knopHelp.Name = "knopHelp";
            this.knopHelp.Primary = true;
            this.knopHelp.Size = new System.Drawing.Size(80, 30);
            this.knopHelp.TabIndex = 1;
            this.knopHelp.Text = "Help";
            this.knopHelp.UseVisualStyleBackColor = true;
            // 
            // labelGeel
            // 
            this.labelGeel.AutoSize = true;
            this.labelGeel.Font = new System.Drawing.Font("Wide awake", 28F);
            this.labelGeel.ForeColor = System.Drawing.Color.Yellow;
            this.labelGeel.Location = new System.Drawing.Point(12, 100);
            this.labelGeel.Name = "labelGeel";
            this.labelGeel.Size = new System.Drawing.Size(83, 61);
            this.labelGeel.TabIndex = 2;
            this.labelGeel.Text = "geel";
            // 
            // labelBlauw
            // 
            this.labelBlauw.AutoSize = true;
            this.labelBlauw.Font = new System.Drawing.Font("Wide awake", 28F);
            this.labelBlauw.ForeColor = System.Drawing.Color.Blue;
            this.labelBlauw.Location = new System.Drawing.Point(491, 100);
            this.labelBlauw.Name = "labelBlauw";
            this.labelBlauw.Size = new System.Drawing.Size(107, 61);
            this.labelBlauw.TabIndex = 3;
            this.labelBlauw.Text = "blauw";
            // 
            // panelSpeelveld
            // 
            this.panelSpeelveld.BackColor = System.Drawing.Color.Gray;
            this.panelSpeelveld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSpeelveld.Location = new System.Drawing.Point(100, 250);
            this.panelSpeelveld.Name = "panelSpeelveld";
            this.panelSpeelveld.Size = new System.Drawing.Size(400, 400);
            this.panelSpeelveld.TabIndex = 4;
            this.panelSpeelveld.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSpeelveld_Paint);
            // 
            // Reversi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(600, 750);
            this.Controls.Add(this.panelSpeelveld);
            this.Controls.Add(this.labelBlauw);
            this.Controls.Add(this.labelGeel);
            this.Controls.Add(this.knopHelp);
            this.Controls.Add(this.knopNieuwspel);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Reversi";
            this.Text = "Reversi App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton knopNieuwspel;
        private MaterialSkin.Controls.MaterialRaisedButton knopHelp;
        private System.Windows.Forms.Label labelGeel;
        private System.Windows.Forms.Label labelBlauw;
        private System.Windows.Forms.Panel panelSpeelveld;
    }
}