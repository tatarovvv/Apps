using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Reversi_App
{
    internal class SpelOpties : MaterialForm
    {
        private Label label1;
        private Label label2;
        private TextBox textBoxGridH;
        private TextBox textBoxGridB;
        private Label label3;
        private Label label4;
        private TextBox textBoxSpeler1;
        private TextBox textBoxSpeler2;
        private Label label5;
        private CheckBox checkBoxSpeler1;
        private CheckBox checkBoxSpeler2;
        private MaterialRaisedButton materialRaisedButton2;
        private MaterialRaisedButton materialRaisedButton1;
        
        // Spelopties voordat het spel begint.
        public SpelOpties()
        {
            // Leuke UX Thema.
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue800, Primary.Blue700, Accent.Yellow200, TextShade.WHITE);
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxGridH = new System.Windows.Forms.TextBox();
            this.textBoxGridB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSpeler1 = new System.Windows.Forms.TextBox();
            this.textBoxSpeler2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.checkBoxSpeler1 = new System.Windows.Forms.CheckBox();
            this.checkBoxSpeler2 = new System.Windows.Forms.CheckBox();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grid Hoogte:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grid Breedte:";
            // 
            // textBoxGridH
            // 
            this.textBoxGridH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGridH.Location = new System.Drawing.Point(152, 109);
            this.textBoxGridH.Name = "textBoxGridH";
            this.textBoxGridH.Size = new System.Drawing.Size(98, 20);
            this.textBoxGridH.TabIndex = 2;
            // 
            // textBoxGridB
            // 
            this.textBoxGridB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGridB.Location = new System.Drawing.Point(152, 146);
            this.textBoxGridB.Name = "textBoxGridB";
            this.textBoxGridB.Size = new System.Drawing.Size(98, 20);
            this.textBoxGridB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Speler 1 Naam:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Speler 2 Naam:";
            // 
            // textBoxSpeler1
            // 
            this.textBoxSpeler1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSpeler1.Location = new System.Drawing.Point(152, 214);
            this.textBoxSpeler1.Name = "textBoxSpeler1";
            this.textBoxSpeler1.Size = new System.Drawing.Size(98, 20);
            this.textBoxSpeler1.TabIndex = 6;
            // 
            // textBoxSpeler2
            // 
            this.textBoxSpeler2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSpeler2.Location = new System.Drawing.Point(152, 243);
            this.textBoxSpeler2.Name = "textBoxSpeler2";
            this.textBoxSpeler2.Size = new System.Drawing.Size(98, 20);
            this.textBoxSpeler2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Wie mag eerst?";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(33, 393);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(203, 70);
            this.materialRaisedButton1.TabIndex = 14;
            this.materialRaisedButton1.Text = "Speel !";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // checkBoxSpeler1
            // 
            this.checkBoxSpeler1.AutoSize = true;
            this.checkBoxSpeler1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSpeler1.ForeColor = System.Drawing.Color.White;
            this.checkBoxSpeler1.Location = new System.Drawing.Point(152, 301);
            this.checkBoxSpeler1.Name = "checkBoxSpeler1";
            this.checkBoxSpeler1.Size = new System.Drawing.Size(84, 24);
            this.checkBoxSpeler1.TabIndex = 15;
            this.checkBoxSpeler1.Text = "Speler 1";
            this.checkBoxSpeler1.UseVisualStyleBackColor = true;
            this.checkBoxSpeler1.CheckedChanged += new System.EventHandler(this.checkBoxSpeler1_CheckedChanged);
            // 
            // checkBoxSpeler2
            // 
            this.checkBoxSpeler2.AutoSize = true;
            this.checkBoxSpeler2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSpeler2.ForeColor = System.Drawing.Color.White;
            this.checkBoxSpeler2.Location = new System.Drawing.Point(152, 331);
            this.checkBoxSpeler2.Name = "checkBoxSpeler2";
            this.checkBoxSpeler2.Size = new System.Drawing.Size(84, 24);
            this.checkBoxSpeler2.TabIndex = 16;
            this.checkBoxSpeler2.Text = "Speler 2";
            this.checkBoxSpeler2.UseVisualStyleBackColor = true;
            this.checkBoxSpeler2.CheckedChanged += new System.EventHandler(this.checkBoxSpeler2_CheckedChanged);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(35, 469);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(201, 39);
            this.materialRaisedButton2.TabIndex = 17;
            this.materialRaisedButton2.Text = "Afsluiten";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // SpelOpties
            // 
            this.ClientSize = new System.Drawing.Size(262, 534);
            this.ControlBox = false;
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.checkBoxSpeler2);
            this.Controls.Add(this.checkBoxSpeler1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSpeler2);
            this.Controls.Add(this.textBoxSpeler1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxGridB);
            this.Controls.Add(this.textBoxGridH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "SpelOpties";
            this.Text = "Reversi Opties";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Eventhandler van 'Speel' knop, nadat die geklikt wordt; 
        // Variabelen gegeven van user worden gepakt en worden zo nodig geparsed en in de Reversi game gebruikt. 

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Reversi.bordHoogte = int.Parse(textBoxGridH.Text);
                Reversi.bordBreedte = int.Parse(textBoxGridB.Text);
                Reversi.Speler1 = textBoxSpeler1.Text;
                Reversi.Speler2 = textBoxSpeler2.Text;
                Hide();
            }

            // Als er niks of geen geldige gegevens worden ingevoerd dan krijgt de user een foutmelding.
            catch
            {
                MessageBox.Show("Vul geldige waardes in!", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Checkbox die bepaalt wie begint.
        private void checkBoxSpeler1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSpeler1.Checked)
            {
                Reversi.beurt = 1;
                checkBoxSpeler2.Checked = false;
            }
        }

        // Checkbox die bepaalt wie begint.
        private void checkBoxSpeler2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSpeler2.Checked)
            {
                Reversi.beurt = 2;
                checkBoxSpeler1.Checked = false;
            }
        }

        // Eventhandler voor 'Afsluiten' knop.
        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}