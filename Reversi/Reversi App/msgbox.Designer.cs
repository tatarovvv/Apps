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
            this.labelWinnaar = new System.Windows.Forms.Label();
            this.OkKnop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWinnaar
            // 
            this.labelWinnaar.AutoSize = true;
            this.labelWinnaar.Font = new System.Drawing.Font("Dagestan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWinnaar.ForeColor = System.Drawing.Color.Blue;
            this.labelWinnaar.Location = new System.Drawing.Point(46, 35);
            this.labelWinnaar.Name = "labelWinnaar";
            this.labelWinnaar.Size = new System.Drawing.Size(263, 37);
            this.labelWinnaar.TabIndex = 0;
            this.labelWinnaar.Text = "Blauw is de winnaar!";
            // 
            // OkKnop
            // 
            this.OkKnop.Font = new System.Drawing.Font("American Signs", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkKnop.Location = new System.Drawing.Point(104, 89);
            this.OkKnop.Name = "OkKnop";
            this.OkKnop.Size = new System.Drawing.Size(153, 43);
            this.OkKnop.TabIndex = 1;
            this.OkKnop.Text = "Nieuw Spel !";
            this.OkKnop.UseVisualStyleBackColor = true;
            // 
            // msgbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 144);
            this.Controls.Add(this.OkKnop);
            this.Controls.Add(this.labelWinnaar);
            this.Name = "msgbox";
            this.ShowIcon = false;
            this.Text = "Winnaar ?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWinnaar;
        private System.Windows.Forms.Button OkKnop;
    }
}