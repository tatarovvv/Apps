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
            this.knopNieuwspel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.knopHelp = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelGeel = new System.Windows.Forms.Label();
            this.labelBlauw = new System.Windows.Forms.Label();
            this.panelSpeelveld = new System.Windows.Forms.Panel();
            this.labelScoreGeel = new System.Windows.Forms.Label();
            this.labelScoreBlauw = new System.Windows.Forms.Label();
            this.labelBeurt = new System.Windows.Forms.Label();
            this.labelSpeler1Text = new System.Windows.Forms.Label();
            this.labelSpeler2Text = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.labelTip = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // knopNieuwspel
            // 
            this.knopNieuwspel.Depth = 0;
            this.knopNieuwspel.Location = new System.Drawing.Point(260, 105);
            this.knopNieuwspel.MouseState = MaterialSkin.MouseState.HOVER;
            this.knopNieuwspel.Name = "knopNieuwspel";
            this.knopNieuwspel.Primary = true;
            this.knopNieuwspel.Size = new System.Drawing.Size(80, 37);
            this.knopNieuwspel.TabIndex = 0;
            this.knopNieuwspel.Text = "Nieuw Spel";
            this.toolTip2.SetToolTip(this.knopNieuwspel, "Start een nieuw spel !");
            this.knopNieuwspel.UseVisualStyleBackColor = true;
            this.knopNieuwspel.Click += new System.EventHandler(this.NieuwSpelKnop);
            // 
            // knopHelp
            // 
            this.knopHelp.Depth = 0;
            this.knopHelp.Location = new System.Drawing.Point(260, 148);
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
            // labelSpeler1Text
            // 
            this.labelSpeler1Text.AutoSize = true;
            this.labelSpeler1Text.Font = new System.Drawing.Font("Dagestan", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeler1Text.ForeColor = System.Drawing.Color.Blue;
            this.labelSpeler1Text.Location = new System.Drawing.Point(183, 193);
            this.labelSpeler1Text.Name = "labelSpeler1Text";
            this.labelSpeler1Text.Size = new System.Drawing.Size(82, 33);
            this.labelSpeler1Text.TabIndex = 8;
            this.labelSpeler1Text.Text = "Blauw";
            // 
            // labelSpeler2Text
            // 
            this.labelSpeler2Text.AutoSize = true;
            this.labelSpeler2Text.Font = new System.Drawing.Font("Dagestan", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeler2Text.ForeColor = System.Drawing.Color.Yellow;
            this.labelSpeler2Text.Location = new System.Drawing.Point(197, 193);
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
            this.PassLabel.Location = new System.Drawing.Point(154, 660);
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
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(260, 69);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(80, 30);
            this.materialRaisedButton1.TabIndex = 12;
            this.materialRaisedButton1.Text = "Opties";
            this.toolTip1.SetToolTip(this.materialRaisedButton1, "Help knop laat mogelijke zetten zien!");
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // Reversi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 750);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.labelTip);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.labelSpeler2Text);
            this.Controls.Add(this.labelSpeler1Text);
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
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}