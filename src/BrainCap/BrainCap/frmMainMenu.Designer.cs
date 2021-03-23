namespace BrainCap
{
    partial class frmMainMenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.btnLevels = new System.Windows.Forms.Button();
            this.btnChallenge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLevels
            // 
            this.btnLevels.BackColor = System.Drawing.Color.MintCream;
            this.btnLevels.Location = new System.Drawing.Point(124, 146);
            this.btnLevels.Name = "btnLevels";
            this.btnLevels.Size = new System.Drawing.Size(196, 152);
            this.btnLevels.TabIndex = 0;
            this.btnLevels.Text = "Niveaux";
            this.btnLevels.UseVisualStyleBackColor = false;
            this.btnLevels.Click += new System.EventHandler(this.btnLevels_Click);
            // 
            // btnChallenge
            // 
            this.btnChallenge.BackColor = System.Drawing.Color.MintCream;
            this.btnChallenge.Location = new System.Drawing.Point(442, 146);
            this.btnChallenge.Name = "btnChallenge";
            this.btnChallenge.Size = new System.Drawing.Size(201, 152);
            this.btnChallenge.TabIndex = 1;
            this.btnChallenge.Text = "Challenge";
            this.btnChallenge.UseVisualStyleBackColor = false;
            this.btnChallenge.Click += new System.EventHandler(this.btnChallenge_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnChallenge);
            this.Controls.Add(this.btnLevels);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainMenu";
            this.RightToLeftLayout = true;
            this.Text = "BrainCap";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLevels;
        private System.Windows.Forms.Button btnChallenge;
    }
}

