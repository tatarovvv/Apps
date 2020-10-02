namespace Mandelbrot_App
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Reset = new System.Windows.Forms.Button();
            this.PanelMandel = new System.Windows.Forms.Panel();
            this.OmhoogKnop = new System.Windows.Forms.Button();
            this.LinksKnop = new System.Windows.Forms.Button();
            this.RechtsKnop = new System.Windows.Forms.Button();
            this.OmlaagKnop = new System.Windows.Forms.Button();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelSchaal = new System.Windows.Forms.Label();
            this.labelMaxIteraties = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxSchaal = new System.Windows.Forms.TextBox();
            this.textBoxMaxIteraties = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonToepassen = new System.Windows.Forms.Button();
            this.checkBoxDarkMode = new System.Windows.Forms.CheckBox();
            this.kleur1 = new System.Windows.Forms.Button();
            this.kleur2 = new System.Windows.Forms.Button();
            this.kleur3 = new System.Windows.Forms.Button();
            this.kleur4 = new System.Windows.Forms.Button();
            this.kleur5 = new System.Windows.Forms.Button();
            this.NotificatieIcoon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SelectieLijst = new System.Windows.Forms.ComboBox();
            this.labelKleur = new System.Windows.Forms.Label();
            this.StandaardKleur = new System.Windows.Forms.Button();
            this.labelLocatie = new System.Windows.Forms.Label();
            this.PanelMandel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Cambria", 8.25F);
            this.Reset.Location = new System.Drawing.Point(697, 12);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 0;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.button1_Click);
            // 
            // PanelMandel
            // 
            this.PanelMandel.Controls.Add(this.OmhoogKnop);
            this.PanelMandel.Controls.Add(this.LinksKnop);
            this.PanelMandel.Controls.Add(this.RechtsKnop);
            this.PanelMandel.Controls.Add(this.OmlaagKnop);
            this.PanelMandel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelMandel.Location = new System.Drawing.Point(26, 131);
            this.PanelMandel.Name = "PanelMandel";
            this.PanelMandel.Size = new System.Drawing.Size(575, 400);
            this.PanelMandel.TabIndex = 1;
            // 
            // OmhoogKnop
            // 
            this.OmhoogKnop.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.OmhoogKnop.Location = new System.Drawing.Point(27, 327);
            this.OmhoogKnop.Name = "OmhoogKnop";
            this.OmhoogKnop.Size = new System.Drawing.Size(20, 20);
            this.OmhoogKnop.TabIndex = 3;
            this.OmhoogKnop.Text = "↑";
            this.OmhoogKnop.UseVisualStyleBackColor = true;
            this.OmhoogKnop.Click += new System.EventHandler(this.OmhoogKnop_Click);
            // 
            // LinksKnop
            // 
            this.LinksKnop.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LinksKnop.Location = new System.Drawing.Point(3, 353);
            this.LinksKnop.Name = "LinksKnop";
            this.LinksKnop.Size = new System.Drawing.Size(20, 20);
            this.LinksKnop.TabIndex = 2;
            this.LinksKnop.Text = "←";
            this.LinksKnop.UseVisualStyleBackColor = true;
            this.LinksKnop.Click += new System.EventHandler(this.LinksKnop_Click);
            // 
            // RechtsKnop
            // 
            this.RechtsKnop.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RechtsKnop.Location = new System.Drawing.Point(50, 353);
            this.RechtsKnop.Name = "RechtsKnop";
            this.RechtsKnop.Size = new System.Drawing.Size(20, 20);
            this.RechtsKnop.TabIndex = 1;
            this.RechtsKnop.Text = "→";
            this.RechtsKnop.UseVisualStyleBackColor = true;
            this.RechtsKnop.Click += new System.EventHandler(this.RechtsKnop_Click);
            // 
            // OmlaagKnop
            // 
            this.OmlaagKnop.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.OmlaagKnop.Location = new System.Drawing.Point(27, 379);
            this.OmlaagKnop.Name = "OmlaagKnop";
            this.OmlaagKnop.Size = new System.Drawing.Size(20, 20);
            this.OmlaagKnop.TabIndex = 0;
            this.OmlaagKnop.Text = "↓";
            this.OmlaagKnop.UseVisualStyleBackColor = true;
            this.OmlaagKnop.Click += new System.EventHandler(this.OmlaagKnop_Click);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.Location = new System.Drawing.Point(2, 38);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(111, 12);
            this.labelX.TabIndex = 2;
            this.labelX.Text = "Centrum X Coördinaat:";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Cambria", 8.25F);
            this.labelY.Location = new System.Drawing.Point(2, 89);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(111, 12);
            this.labelY.TabIndex = 3;
            this.labelY.Text = "Centrum Y Coördinaat:";
            // 
            // labelSchaal
            // 
            this.labelSchaal.AutoSize = true;
            this.labelSchaal.Font = new System.Drawing.Font("Cambria", 8.25F);
            this.labelSchaal.Location = new System.Drawing.Point(319, 38);
            this.labelSchaal.Name = "labelSchaal";
            this.labelSchaal.Size = new System.Drawing.Size(39, 12);
            this.labelSchaal.TabIndex = 4;
            this.labelSchaal.Text = "Schaal: ";
            // 
            // labelMaxIteraties
            // 
            this.labelMaxIteraties.AutoSize = true;
            this.labelMaxIteraties.Font = new System.Drawing.Font("Cambria", 8.25F);
            this.labelMaxIteraties.Location = new System.Drawing.Point(267, 89);
            this.labelMaxIteraties.Name = "labelMaxIteraties";
            this.labelMaxIteraties.Size = new System.Drawing.Size(98, 12);
            this.labelMaxIteraties.TabIndex = 3;
            this.labelMaxIteraties.Text = "Max aantal iteraties:";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(119, 35);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(115, 20);
            this.textBoxX.TabIndex = 5;
            this.textBoxX.Text = "0";
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(119, 85);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(115, 20);
            this.textBoxY.TabIndex = 6;
            this.textBoxY.Text = "0";
            // 
            // textBoxSchaal
            // 
            this.textBoxSchaal.Location = new System.Drawing.Point(371, 35);
            this.textBoxSchaal.Name = "textBoxSchaal";
            this.textBoxSchaal.Size = new System.Drawing.Size(115, 20);
            this.textBoxSchaal.TabIndex = 7;
            this.textBoxSchaal.Text = "0,01";
            // 
            // textBoxMaxIteraties
            // 
            this.textBoxMaxIteraties.Location = new System.Drawing.Point(371, 85);
            this.textBoxMaxIteraties.Name = "textBoxMaxIteraties";
            this.textBoxMaxIteraties.Size = new System.Drawing.Size(115, 20);
            this.textBoxMaxIteraties.TabIndex = 8;
            this.textBoxMaxIteraties.Text = "100";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Cambria", 8.25F);
            this.labelInfo.Location = new System.Drawing.Point(160, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(261, 12);
            this.labelInfo.TabIndex = 9;
            this.labelInfo.Text = "Vul je gewenste waardes in en klik daarna op toepassen.";
            // 
            // buttonToepassen
            // 
            this.buttonToepassen.Font = new System.Drawing.Font("Cambria", 8.25F);
            this.buttonToepassen.Location = new System.Drawing.Point(511, 38);
            this.buttonToepassen.Name = "buttonToepassen";
            this.buttonToepassen.Size = new System.Drawing.Size(90, 67);
            this.buttonToepassen.TabIndex = 10;
            this.buttonToepassen.Text = "Toepassen";
            this.buttonToepassen.UseVisualStyleBackColor = true;
            this.buttonToepassen.Click += new System.EventHandler(this.buttonToepassen_Click);
            // 
            // checkBoxDarkMode
            // 
            this.checkBoxDarkMode.AutoSize = true;
            this.checkBoxDarkMode.Font = new System.Drawing.Font("Cambria", 8.25F);
            this.checkBoxDarkMode.Location = new System.Drawing.Point(697, 41);
            this.checkBoxDarkMode.Name = "checkBoxDarkMode";
            this.checkBoxDarkMode.Size = new System.Drawing.Size(75, 16);
            this.checkBoxDarkMode.TabIndex = 11;
            this.checkBoxDarkMode.Text = "Dark Mode";
            this.checkBoxDarkMode.UseVisualStyleBackColor = true;
            this.checkBoxDarkMode.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // kleur1
            // 
            this.kleur1.Font = new System.Drawing.Font("Cambria", 8.25F);
            this.kleur1.Location = new System.Drawing.Point(607, 131);
            this.kleur1.Name = "kleur1";
            this.kleur1.Size = new System.Drawing.Size(75, 23);
            this.kleur1.TabIndex = 12;
            this.kleur1.Text = "Neon Geel";
            this.kleur1.UseVisualStyleBackColor = true;
            this.kleur1.Click += new System.EventHandler(this.kleur1_Click);
            // 
            // kleur2
            // 
            this.kleur2.Font = new System.Drawing.Font("Cambria", 8.25F);
            this.kleur2.Location = new System.Drawing.Point(607, 160);
            this.kleur2.Name = "kleur2";
            this.kleur2.Size = new System.Drawing.Size(75, 23);
            this.kleur2.TabIndex = 13;
            this.kleur2.Text = "Neon Groen";
            this.kleur2.UseVisualStyleBackColor = true;
            this.kleur2.Click += new System.EventHandler(this.kleur2_Click);
            // 
            // kleur3
            // 
            this.kleur3.Font = new System.Drawing.Font("Cambria", 8.25F);
            this.kleur3.Location = new System.Drawing.Point(607, 189);
            this.kleur3.Name = "kleur3";
            this.kleur3.Size = new System.Drawing.Size(75, 23);
            this.kleur3.TabIndex = 14;
            this.kleur3.Text = "Neon Blauw";
            this.kleur3.UseVisualStyleBackColor = true;
            this.kleur3.Click += new System.EventHandler(this.kleur3_Click);
            // 
            // kleur4
            // 
            this.kleur4.Font = new System.Drawing.Font("Cambria", 8.25F);
            this.kleur4.Location = new System.Drawing.Point(607, 218);
            this.kleur4.Name = "kleur4";
            this.kleur4.Size = new System.Drawing.Size(75, 23);
            this.kleur4.TabIndex = 15;
            this.kleur4.Text = "Neon Rood";
            this.kleur4.UseVisualStyleBackColor = true;
            this.kleur4.Click += new System.EventHandler(this.kleur4_Click);
            // 
            // kleur5
            // 
            this.kleur5.Font = new System.Drawing.Font("Cambria", 8.25F);
            this.kleur5.Location = new System.Drawing.Point(607, 247);
            this.kleur5.Name = "kleur5";
            this.kleur5.Size = new System.Drawing.Size(75, 23);
            this.kleur5.TabIndex = 16;
            this.kleur5.Text = "Neon Grijs";
            this.kleur5.UseVisualStyleBackColor = true;
            this.kleur5.Click += new System.EventHandler(this.kleur5_Click);
            // 
            // NotificatieIcoon
            // 
            this.NotificatieIcoon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotificatieIcoon.Icon")));
            this.NotificatieIcoon.Text = "Mandelbrot App";
            this.NotificatieIcoon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotificatieIcoon_MouseDoubleClick);
            // 
            // SelectieLijst
            // 
            this.SelectieLijst.FormattingEnabled = true;
            this.SelectieLijst.Items.AddRange(new object[] {
            "Het Hoofd",
            "De Brug",
            "De Snelweg",
            "De Cirkel"});
            this.SelectieLijst.Location = new System.Drawing.Point(697, 132);
            this.SelectieLijst.Name = "SelectieLijst";
            this.SelectieLijst.Size = new System.Drawing.Size(75, 21);
            this.SelectieLijst.TabIndex = 17;
            this.SelectieLijst.SelectedIndexChanged += new System.EventHandler(this.SelectieLijst_SelectedIndexChanged);
            // 
            // labelKleur
            // 
            this.labelKleur.AutoSize = true;
            this.labelKleur.Font = new System.Drawing.Font("Cambria", 8.25F);
            this.labelKleur.Location = new System.Drawing.Point(605, 116);
            this.labelKleur.Name = "labelKleur";
            this.labelKleur.Size = new System.Drawing.Size(36, 12);
            this.labelKleur.TabIndex = 18;
            this.labelKleur.Text = "Kleur: ";
            // 
            // StandaardKleur
            // 
            this.StandaardKleur.Font = new System.Drawing.Font("Cambria", 8.25F);
            this.StandaardKleur.Location = new System.Drawing.Point(607, 276);
            this.StandaardKleur.Name = "StandaardKleur";
            this.StandaardKleur.Size = new System.Drawing.Size(75, 23);
            this.StandaardKleur.TabIndex = 19;
            this.StandaardKleur.Text = "Standaard";
            this.StandaardKleur.UseVisualStyleBackColor = true;
            this.StandaardKleur.Click += new System.EventHandler(this.StandaardKleur_Click);
            // 
            // labelLocatie
            // 
            this.labelLocatie.AutoSize = true;
            this.labelLocatie.Font = new System.Drawing.Font("Cambria", 8.25F);
            this.labelLocatie.Location = new System.Drawing.Point(695, 117);
            this.labelLocatie.Name = "labelLocatie";
            this.labelLocatie.Size = new System.Drawing.Size(42, 12);
            this.labelLocatie.TabIndex = 20;
            this.labelLocatie.Text = "Locatie:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.labelLocatie);
            this.Controls.Add(this.StandaardKleur);
            this.Controls.Add(this.labelKleur);
            this.Controls.Add(this.SelectieLijst);
            this.Controls.Add(this.kleur5);
            this.Controls.Add(this.kleur4);
            this.Controls.Add(this.kleur3);
            this.Controls.Add(this.kleur2);
            this.Controls.Add(this.kleur1);
            this.Controls.Add(this.checkBoxDarkMode);
            this.Controls.Add(this.buttonToepassen);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.textBoxMaxIteraties);
            this.Controls.Add(this.textBoxSchaal);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.labelMaxIteraties);
            this.Controls.Add(this.labelSchaal);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.PanelMandel);
            this.Controls.Add(this.Reset);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mandelbrot App";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.PanelMandel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Panel PanelMandel;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelSchaal;
        private System.Windows.Forms.Label labelMaxIteraties;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxSchaal;
        private System.Windows.Forms.TextBox textBoxMaxIteraties;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonToepassen;
        private System.Windows.Forms.CheckBox checkBoxDarkMode;
        private System.Windows.Forms.Button kleur1;
        private System.Windows.Forms.Button kleur2;
        private System.Windows.Forms.Button kleur3;
        private System.Windows.Forms.Button kleur4;
        private System.Windows.Forms.Button kleur5;
        private System.Windows.Forms.NotifyIcon NotificatieIcoon;
        private System.Windows.Forms.Button OmhoogKnop;
        private System.Windows.Forms.Button LinksKnop;
        private System.Windows.Forms.Button RechtsKnop;
        private System.Windows.Forms.Button OmlaagKnop;
        private System.Windows.Forms.ComboBox SelectieLijst;
        private System.Windows.Forms.Label labelKleur;
        private System.Windows.Forms.Button StandaardKleur;
        private System.Windows.Forms.Label labelLocatie;
    }
}

