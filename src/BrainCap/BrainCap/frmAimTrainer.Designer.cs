namespace BrainCap
{
    partial class frmAimTrainer
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
            this.btnCible = new System.Windows.Forms.Button();
            this.btnCommencer = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.lblDecompte = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCible
            // 
            this.btnCible.BackColor = System.Drawing.Color.Lime;
            this.btnCible.ForeColor = System.Drawing.Color.Black;
            this.btnCible.Location = new System.Drawing.Point(123, 73);
            this.btnCible.Name = "btnCible";
            this.btnCible.Size = new System.Drawing.Size(80, 80);
            this.btnCible.TabIndex = 0;
            this.btnCible.UseVisualStyleBackColor = false;
            // 
            // btnCommencer
            // 
            this.btnCommencer.Location = new System.Drawing.Point(330, 174);
            this.btnCommencer.Name = "btnCommencer";
            this.btnCommencer.Size = new System.Drawing.Size(486, 181);
            this.btnCommencer.TabIndex = 1;
            this.btnCommencer.Text = "Commencer";
            this.btnCommencer.UseVisualStyleBackColor = true;
            this.btnCommencer.Click += new System.EventHandler(this.btnCommencer_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(330, 417);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(486, 181);
            this.btnRetour.TabIndex = 2;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            // 
            // lblDecompte
            // 
            this.lblDecompte.AutoSize = true;
            this.lblDecompte.Location = new System.Drawing.Point(592, 58);
            this.lblDecompte.Name = "lblDecompte";
            this.lblDecompte.Size = new System.Drawing.Size(35, 13);
            this.lblDecompte.TabIndex = 3;
            this.lblDecompte.Text = "label1";
            // 
            // frmAimTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.lblDecompte);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnCommencer);
            this.Controls.Add(this.btnCible);
            this.Name = "frmAimTrainer";
            this.Text = "frmAimTrainer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCible;
        private System.Windows.Forms.Button btnCommencer;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label lblDecompte;
    }
}