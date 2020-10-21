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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reversi));
            this.knopNieuwspel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.knopHelp = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelGeel = new System.Windows.Forms.Label();
            this.labelBlauw = new System.Windows.Forms.Label();
            this.panelSpeelveld = new System.Windows.Forms.Panel();
            this.labelBeurt = new System.Windows.Forms.Label();
            this.labelScoreGeel = new System.Windows.Forms.Label();
            this.labelScoreBlauw = new System.Windows.Forms.Label();
            this.labelSpeler1Text = new System.Windows.Forms.Label();
            this.labelSpeler2Text = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.labelTip = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.knopOpties = new MaterialSkin.Controls.MaterialRaisedButton();
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // knopNieuwspel
            // 
            this.knopNieuwspel.Depth = 0;
            this.knopNieuwspel.Location = new System.Drawing.Point(257, 126);
            this.knopNieuwspel.MouseState = MaterialSkin.MouseState.HOVER;
            this.knopNieuwspel.Name = "knopNieuwspel";
            this.knopNieuwspel.Primary = true;
            this.knopNieuwspel.Size = new System.Drawing.Size(80, 37);
            this.knopNieuwspel.TabIndex = 0;
            this.knopNieuwspel.Text = "Nieuw Spel";
            this.toolTip2.SetToolTip(this.knopNieuwspel, "Start een nieuw spel!");
            this.knopNieuwspel.UseVisualStyleBackColor = true;
            this.knopNieuwspel.Click += new System.EventHandler(this.NieuwSpelKnop);
            // 
            // knopHelp
            // 
            this.knopHelp.Depth = 0;
            this.knopHelp.Location = new System.Drawing.Point(257, 169);
            this.knopHelp.MouseState = MaterialSkin.MouseState.HOVER;
            this.knopHelp.Name = "knopHelp";
            this.knopHelp.Primary = true;
            this.knopHelp.Size = new System.Drawing.Size(80, 30);
            this.knopHelp.TabIndex = 1;
            this.knopHelp.Text = "Help";
            this.toolTip1.SetToolTip(this.knopHelp, "Help knop laat mogelijke zetten zien!");
            this.knopHelp.UseVisualStyleBackColor = true;
            this.knopHelp.Click += new System.EventHandler(this.Help);
            // 
            // labelGeel
            // 
            this.labelGeel.AutoSize = true;
            this.labelGeel.BackColor = System.Drawing.Color.Transparent;
            this.labelGeel.Font = new System.Drawing.Font("Wide awake", 36F);
            this.labelGeel.ForeColor = System.Drawing.Color.Yellow;
            this.labelGeel.Location = new System.Drawing.Point(0, 100);
            this.labelGeel.Name = "labelGeel";
            this.labelGeel.Size = new System.Drawing.Size(103, 78);
            this.labelGeel.TabIndex = 2;
            this.labelGeel.Text = "geel";
            // 
            // labelBlauw
            // 
            this.labelBlauw.AutoSize = true;
            this.labelBlauw.BackColor = System.Drawing.Color.Transparent;
            this.labelBlauw.Font = new System.Drawing.Font("Wide awake", 36F);
            this.labelBlauw.ForeColor = System.Drawing.Color.Blue;
            this.labelBlauw.Location = new System.Drawing.Point(467, 100);
            this.labelBlauw.Name = "labelBlauw";
            this.labelBlauw.Size = new System.Drawing.Size(133, 78);
            this.labelBlauw.TabIndex = 3;
            this.labelBlauw.Text = "blauw";
            // 
            // panelSpeelveld
            // 
            this.panelSpeelveld.BackColor = System.Drawing.Color.Gray;
            this.panelSpeelveld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSpeelveld.Location = new System.Drawing.Point(88, 268);
            this.panelSpeelveld.Margin = new System.Windows.Forms.Padding(2);
            this.panelSpeelveld.Name = "panelSpeelveld";
            this.panelSpeelveld.Size = new System.Drawing.Size(413, 390);
            this.panelSpeelveld.TabIndex = 4;
            // 
            // labelBeurt
            // 
            this.labelBeurt.AutoSize = true;
            this.labelBeurt.BackColor = System.Drawing.Color.Transparent;
            this.labelBeurt.Font = new System.Drawing.Font("Dagestan", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBeurt.ForeColor = System.Drawing.Color.White;
            this.labelBeurt.Location = new System.Drawing.Point(50, 210);
            this.labelBeurt.Name = "labelBeurt";
            this.labelBeurt.Size = new System.Drawing.Size(85, 33);
            this.labelBeurt.TabIndex = 7;
            this.labelBeurt.Text = "Beurt:";
            // 
            // labelScoreGeel
            // 
            this.labelScoreGeel.AutoSize = true;
            this.labelScoreGeel.BackColor = System.Drawing.Color.Transparent;
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
            this.labelScoreBlauw.BackColor = System.Drawing.Color.Transparent;
            this.labelScoreBlauw.Font = new System.Drawing.Font("Wide awake", 36F);
            this.labelScoreBlauw.ForeColor = System.Drawing.Color.Blue;
            this.labelScoreBlauw.Location = new System.Drawing.Point(428, 100);
            this.labelScoreBlauw.Name = "labelScoreBlauw";
            this.labelScoreBlauw.Size = new System.Drawing.Size(53, 78);
            this.labelScoreBlauw.TabIndex = 6;
            this.labelScoreBlauw.Text = "2";
            // 
            // labelSpeler1Text
            // 
            this.labelSpeler1Text.AutoSize = true;
            this.labelSpeler1Text.BackColor = System.Drawing.Color.Transparent;
            this.labelSpeler1Text.Font = new System.Drawing.Font("Dagestan", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeler1Text.ForeColor = System.Drawing.Color.Blue;
            this.labelSpeler1Text.Location = new System.Drawing.Point(255, 233);
            this.labelSpeler1Text.Name = "labelSpeler1Text";
            this.labelSpeler1Text.Size = new System.Drawing.Size(82, 33);
            this.labelSpeler1Text.TabIndex = 8;
            this.labelSpeler1Text.Text = "Blauw";
            // 
            // labelSpeler2Text
            // 
            this.labelSpeler2Text.AutoSize = true;
            this.labelSpeler2Text.BackColor = System.Drawing.Color.Transparent;
            this.labelSpeler2Text.Font = new System.Drawing.Font("Dagestan", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeler2Text.ForeColor = System.Drawing.Color.Yellow;
            this.labelSpeler2Text.Location = new System.Drawing.Point(269, 233);
            this.labelSpeler2Text.Name = "labelSpeler2Text";
            this.labelSpeler2Text.Size = new System.Drawing.Size(68, 33);
            this.labelSpeler2Text.TabIndex = 9;
            this.labelSpeler2Text.Text = "Geel";
            this.labelSpeler2Text.Visible = false;
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Dagestan", 14F);
            this.PassLabel.ForeColor = System.Drawing.Color.Crimson;
            this.PassLabel.Location = new System.Drawing.Point(150, 660);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(0, 20);
            this.PassLabel.TabIndex = 10;
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.Font = new System.Drawing.Font("Dagestan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTip.Location = new System.Drawing.Point(174, 683);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(249, 17);
            this.labelTip.TabIndex = 11;
            this.labelTip.Text = "Tip: Gebruik de help knop als je vast zit !";
            this.labelTip.Visible = false;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Help Knop";
            // 
            // toolTip2
            // 
            this.toolTip2.ToolTipTitle = "Nieuw Spel";
            // 
            // knopOpties
            // 
            this.knopOpties.Depth = 0;
            this.knopOpties.Location = new System.Drawing.Point(257, 76);
            this.knopOpties.MouseState = MaterialSkin.MouseState.HOVER;
            this.knopOpties.Name = "knopOpties";
            this.knopOpties.Primary = true;
            this.knopOpties.Size = new System.Drawing.Size(80, 37);
            this.knopOpties.TabIndex = 12;
            this.knopOpties.Text = "Opties";
            this.toolTip3.SetToolTip(this.knopOpties, "Verander de opties van het spel!");
            this.knopOpties.UseVisualStyleBackColor = true;
            this.knopOpties.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // toolTip3
            // 
            this.toolTip3.ToolTipTitle = "Opties";
            // 
            // Reversi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 750);
            this.Controls.Add(this.labelBeurt);
            this.Controls.Add(this.knopOpties);
            this.Controls.Add(this.labelTip);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.labelSpeler2Text);
            this.Controls.Add(this.labelSpeler1Text);
            this.Controls.Add(this.labelScoreBlauw);
            this.Controls.Add(this.labelScoreGeel);
            this.Controls.Add(this.panelSpeelveld);
            this.Controls.Add(this.labelBlauw);
            this.Controls.Add(this.labelGeel);
            this.Controls.Add(this.knopHelp);
            this.Controls.Add(this.knopNieuwspel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reversi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reversi Game";
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
        private System.Windows.Forms.Label labelSpeler1Text;
        private System.Windows.Forms.Label labelSpeler2Text;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private MaterialSkin.Controls.MaterialRaisedButton knopOpties;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}