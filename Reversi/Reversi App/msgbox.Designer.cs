namespace Reversi_App
{
    partial class msgbox
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
            this.labelWinnaarB = new System.Windows.Forms.Label();
            this.labelWinnaarG = new System.Windows.Forms.Label();
            this.labelGelijkspel = new System.Windows.Forms.Label();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // labelWinnaarB
            // 
            this.labelWinnaarB.AutoSize = true;
            this.labelWinnaarB.BackColor = System.Drawing.Color.Transparent;
            this.labelWinnaarB.Font = new System.Drawing.Font("Dagestan", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWinnaarB.ForeColor = System.Drawing.Color.Blue;
            this.labelWinnaarB.Location = new System.Drawing.Point(82, 95);
            this.labelWinnaarB.Name = "labelWinnaarB";
            this.labelWinnaarB.Size = new System.Drawing.Size(282, 39);
            this.labelWinnaarB.TabIndex = 1;
            this.labelWinnaarB.Text = "Blauw is de winnaar!";
            // 
            // labelWinnaarG
            // 
            this.labelWinnaarG.AutoSize = true;
            this.labelWinnaarG.BackColor = System.Drawing.Color.Transparent;
            this.labelWinnaarG.Font = new System.Drawing.Font("Dagestan", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWinnaarG.ForeColor = System.Drawing.Color.Yellow;
            this.labelWinnaarG.Location = new System.Drawing.Point(92, 95);
            this.labelWinnaarG.Name = "labelWinnaarG";
            this.labelWinnaarG.Size = new System.Drawing.Size(262, 39);
            this.labelWinnaarG.TabIndex = 2;
            this.labelWinnaarG.Text = "Geel is de winnaar!";
            // 
            // labelGelijkspel
            // 
            this.labelGelijkspel.AutoSize = true;
            this.labelGelijkspel.BackColor = System.Drawing.Color.Transparent;
            this.labelGelijkspel.Font = new System.Drawing.Font("Dagestan", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGelijkspel.ForeColor = System.Drawing.Color.Crimson;
            this.labelGelijkspel.Location = new System.Drawing.Point(82, 95);
            this.labelGelijkspel.Name = "labelGelijkspel";
            this.labelGelijkspel.Size = new System.Drawing.Size(273, 39);
            this.labelGelijkspel.TabIndex = 3;
            this.labelGelijkspel.Text = "Gelijkspel, REMISE !";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(175, 153);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(92, 40);
            this.materialRaisedButton1.TabIndex = 4;
            this.materialRaisedButton1.Text = "OK !";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.KnopKlik);
            // 
            // msgbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(443, 205);
            this.ControlBox = false;
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.labelGelijkspel);
            this.Controls.Add(this.labelWinnaarG);
            this.Controls.Add(this.labelWinnaarB);
            this.Name = "msgbox";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.Sizable = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelWinnaarB;
        private System.Windows.Forms.Label labelWinnaarG;
        private System.Windows.Forms.Label labelGelijkspel;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}