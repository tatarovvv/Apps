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
            this.labelScoreGeel = new System.Windows.Forms.Label();
            this.labelScoreBlauw = new System.Windows.Forms.Label();
            this.labelBeurt = new System.Windows.Forms.Label();
            this.labelBlauwText = new System.Windows.Forms.Label();
            this.labelGeelText = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
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
            this.knopNieuwspel.Click += new System.EventHandler(this.NieuwSpel);
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
            this.knopHelp.Click += new System.EventHandler(this.Help);
            // 
            // labelGeel
            // 
            this.labelGeel.AutoSize = true;
            this.labelGeel.Font = new System.Drawing.Font("Wide awake", 36F);
            this.labelGeel.ForeColor = System.Drawing.Color.Yellow;
            this.labelGeel.Location = new System.Drawing.Point(12, 100);
            this.labelGeel.Name = "labelGeel";
            this.labelGeel.Size = new System.Drawing.Size(103, 78);
            this.labelGeel.TabIndex = 2;
            this.labelGeel.Text = "geel";
            // 
            // labelBlauw
            // 
            this.labelBlauw.AutoSize = true;
            this.labelBlauw.Font = new System.Drawing.Font("Wide awake", 36F);
            this.labelBlauw.ForeColor = System.Drawing.Color.Blue;
            this.labelBlauw.Location = new System.Drawing.Point(472, 100);
            this.labelBlauw.Name = "labelBlauw";
            this.labelBlauw.Size = new System.Drawing.Size(133, 78);
            this.labelBlauw.TabIndex = 3;
            this.labelBlauw.Text = "blauw";
            // 
            // panelSpeelveld
            // 
            this.panelSpeelveld.BackColor = System.Drawing.Color.Gray;
            this.panelSpeelveld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSpeelveld.Location = new System.Drawing.Point(112, 247);
            this.panelSpeelveld.Margin = new System.Windows.Forms.Padding(2);
            this.panelSpeelveld.Name = "panelSpeelveld";
            this.panelSpeelveld.Size = new System.Drawing.Size(413, 390);
            this.panelSpeelveld.TabIndex = 4;
            // 
            // labelScoreGeel
            // 
            this.labelScoreGeel.AutoSize = true;
            this.labelScoreGeel.Font = new System.Drawing.Font("Wide awake", 36F);
            this.labelScoreGeel.ForeColor = System.Drawing.Color.Yellow;
            this.labelScoreGeel.Location = new System.Drawing.Point(101, 100);
            this.labelScoreGeel.Name = "labelScoreGeel";
            this.labelScoreGeel.Size = new System.Drawing.Size(53, 78);
            this.labelScoreGeel.TabIndex = 5;
            this.labelScoreGeel.Text = "2";
            // 
            // labelScoreBlauw
            // 
            this.labelScoreBlauw.AutoSize = true;
            this.labelScoreBlauw.Font = new System.Drawing.Font("Wide awake", 36F);
            this.labelScoreBlauw.ForeColor = System.Drawing.Color.Blue;
            this.labelScoreBlauw.Location = new System.Drawing.Point(422, 100);
            this.labelScoreBlauw.Name = "labelScoreBlauw";
            this.labelScoreBlauw.Size = new System.Drawing.Size(53, 78);
            this.labelScoreBlauw.TabIndex = 6;
            this.labelScoreBlauw.Text = "2";
            // 
            // labelBeurt
            // 
            this.labelBeurt.AutoSize = true;
            this.labelBeurt.Font = new System.Drawing.Font("Dagestan", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBeurt.ForeColor = System.Drawing.Color.White;
            this.labelBeurt.Location = new System.Drawing.Point(254, 193);
            this.labelBeurt.Name = "labelBeurt";
            this.labelBeurt.Size = new System.Drawing.Size(192, 33);
            this.labelBeurt.TabIndex = 7;
            this.labelBeurt.Text = " is aan de beurt!";
            // 
            // labelBlauwText
            // 
            this.labelBlauwText.AutoSize = true;
            this.labelBlauwText.Font = new System.Drawing.Font("Dagestan", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBlauwText.ForeColor = System.Drawing.Color.Blue;
            this.labelBlauwText.Location = new System.Drawing.Point(183, 193);
            this.labelBlauwText.Name = "labelBlauwText";
            this.labelBlauwText.Size = new System.Drawing.Size(82, 33);
            this.labelBlauwText.TabIndex = 8;
            this.labelBlauwText.Text = "Blauw";
            // 
            // labelGeelText
            // 
            this.labelGeelText.AutoSize = true;
            this.labelGeelText.Font = new System.Drawing.Font("Dagestan", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGeelText.ForeColor = System.Drawing.Color.Yellow;
            this.labelGeelText.Location = new System.Drawing.Point(197, 193);
            this.labelGeelText.Name = "labelGeelText";
            this.labelGeelText.Size = new System.Drawing.Size(68, 33);
            this.labelGeelText.TabIndex = 9;
            this.labelGeelText.Text = "Geel";
            this.labelGeelText.Visible = false;
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Dagestan", 14F);
            this.PassLabel.ForeColor = System.Drawing.Color.White;
            this.PassLabel.Location = new System.Drawing.Point(154, 660);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(0, 20);
            this.PassLabel.TabIndex = 10;
            // 
            // Reversi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 750);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.labelGeelText);
            this.Controls.Add(this.labelBlauwText);
            this.Controls.Add(this.labelBeurt);
            this.Controls.Add(this.labelScoreBlauw);
            this.Controls.Add(this.labelScoreGeel);
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
        private System.Windows.Forms.Label labelScoreGeel;
        private System.Windows.Forms.Label labelScoreBlauw;
        private System.Windows.Forms.Label labelBeurt;
        private System.Windows.Forms.Label labelBlauwText;
        private System.Windows.Forms.Label labelGeelText;
        private System.Windows.Forms.Label PassLabel;
    }
}