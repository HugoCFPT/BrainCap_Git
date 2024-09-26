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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.tsFichierAide = new System.Windows.Forms.ToolStripMenuItem();
            this.tsFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsNiveau = new System.Windows.Forms.ToolStripMenuItem();
            this.tsNiveauQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxTempsRestant = new System.Windows.Forms.GroupBox();
            this.lblTempsRestant = new System.Windows.Forms.Label();
            this.gbxNbCibles = new System.Windows.Forms.GroupBox();
            this.lblNbCiblesTxt = new System.Windows.Forms.Label();
            this.lblNbCiblesInt = new System.Windows.Forms.Label();
            this.gbxNbCiblesRatees = new System.Windows.Forms.GroupBox();
            this.lblNbCiblesRateesTxt = new System.Windows.Forms.Label();
            this.lblNbCiblesRateesInt = new System.Windows.Forms.Label();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.gbxTempsRestant.SuspendLayout();
            this.gbxNbCibles.SuspendLayout();
            this.gbxNbCiblesRatees.SuspendLayout();
            this.pnlStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCible
            // 
            this.btnCible.BackColor = System.Drawing.Color.Lime;
            this.btnCible.ForeColor = System.Drawing.Color.Black;
            this.btnCible.Location = new System.Drawing.Point(95, 197);
            this.btnCible.Name = "btnCible";
            this.btnCible.Size = new System.Drawing.Size(80, 80);
            this.btnCible.TabIndex = 0;
            this.btnCible.UseVisualStyleBackColor = false;
            this.btnCible.Click += new System.EventHandler(this.btnCible_Click);
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
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // lblDecompte
            // 
            this.lblDecompte.AutoSize = true;
            this.lblDecompte.Location = new System.Drawing.Point(107, 24);
            this.lblDecompte.Name = "lblDecompte";
            this.lblDecompte.Size = new System.Drawing.Size(34, 13);
            this.lblDecompte.TabIndex = 3;
            this.lblDecompte.Text = "29.34";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFichier,
            this.tsNiveau});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsFichier
            // 
            this.tsFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFichierAide,
            this.tsFichierQuitter});
            this.tsFichier.Name = "tsFichier";
            this.tsFichier.Size = new System.Drawing.Size(54, 20);
            this.tsFichier.Text = "Fichier";
            // 
            // tsFichierAide
            // 
            this.tsFichierAide.Name = "tsFichierAide";
            this.tsFichierAide.Size = new System.Drawing.Size(111, 22);
            this.tsFichierAide.Text = "?";
            // 
            // tsFichierQuitter
            // 
            this.tsFichierQuitter.Name = "tsFichierQuitter";
            this.tsFichierQuitter.Size = new System.Drawing.Size(111, 22);
            this.tsFichierQuitter.Text = "Quitter";
            // 
            // tsNiveau
            // 
            this.tsNiveau.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNiveauQuitter});
            this.tsNiveau.Name = "tsNiveau";
            this.tsNiveau.Size = new System.Drawing.Size(56, 20);
            this.tsNiveau.Text = "Niveau";
            // 
            // tsNiveauQuitter
            // 
            this.tsNiveauQuitter.Name = "tsNiveauQuitter";
            this.tsNiveauQuitter.Size = new System.Drawing.Size(111, 22);
            this.tsNiveauQuitter.Text = "Quitter";
            // 
            // gbxTempsRestant
            // 
            this.gbxTempsRestant.Controls.Add(this.lblTempsRestant);
            this.gbxTempsRestant.Controls.Add(this.lblDecompte);
            this.gbxTempsRestant.Location = new System.Drawing.Point(183, 18);
            this.gbxTempsRestant.Name = "gbxTempsRestant";
            this.gbxTempsRestant.Size = new System.Drawing.Size(163, 54);
            this.gbxTempsRestant.TabIndex = 5;
            this.gbxTempsRestant.TabStop = false;
            // 
            // lblTempsRestant
            // 
            this.lblTempsRestant.AutoSize = true;
            this.lblTempsRestant.Location = new System.Drawing.Point(18, 24);
            this.lblTempsRestant.Name = "lblTempsRestant";
            this.lblTempsRestant.Size = new System.Drawing.Size(83, 13);
            this.lblTempsRestant.TabIndex = 4;
            this.lblTempsRestant.Text = "Temps restant : ";
            // 
            // gbxNbCibles
            // 
            this.gbxNbCibles.Controls.Add(this.lblNbCiblesTxt);
            this.gbxNbCibles.Controls.Add(this.lblNbCiblesInt);
            this.gbxNbCibles.Location = new System.Drawing.Point(14, 18);
            this.gbxNbCibles.Name = "gbxNbCibles";
            this.gbxNbCibles.Size = new System.Drawing.Size(163, 54);
            this.gbxNbCibles.TabIndex = 6;
            this.gbxNbCibles.TabStop = false;
            // 
            // lblNbCiblesTxt
            // 
            this.lblNbCiblesTxt.AutoSize = true;
            this.lblNbCiblesTxt.Location = new System.Drawing.Point(18, 24);
            this.lblNbCiblesTxt.Name = "lblNbCiblesTxt";
            this.lblNbCiblesTxt.Size = new System.Drawing.Size(91, 13);
            this.lblNbCiblesTxt.TabIndex = 4;
            this.lblNbCiblesTxt.Text = "Cibles touchées : ";
            // 
            // lblNbCiblesInt
            // 
            this.lblNbCiblesInt.AutoSize = true;
            this.lblNbCiblesInt.Location = new System.Drawing.Point(115, 24);
            this.lblNbCiblesInt.Name = "lblNbCiblesInt";
            this.lblNbCiblesInt.Size = new System.Drawing.Size(13, 13);
            this.lblNbCiblesInt.TabIndex = 3;
            this.lblNbCiblesInt.Text = "0";
            // 
            // gbxNbCiblesRatees
            // 
            this.gbxNbCiblesRatees.Controls.Add(this.lblNbCiblesRateesTxt);
            this.gbxNbCiblesRatees.Controls.Add(this.lblNbCiblesRateesInt);
            this.gbxNbCiblesRatees.Location = new System.Drawing.Point(352, 18);
            this.gbxNbCiblesRatees.Name = "gbxNbCiblesRatees";
            this.gbxNbCiblesRatees.Size = new System.Drawing.Size(163, 54);
            this.gbxNbCiblesRatees.TabIndex = 6;
            this.gbxNbCiblesRatees.TabStop = false;
            // 
            // lblNbCiblesRateesTxt
            // 
            this.lblNbCiblesRateesTxt.AutoSize = true;
            this.lblNbCiblesRateesTxt.Location = new System.Drawing.Point(18, 24);
            this.lblNbCiblesRateesTxt.Name = "lblNbCiblesRateesTxt";
            this.lblNbCiblesRateesTxt.Size = new System.Drawing.Size(73, 13);
            this.lblNbCiblesRateesTxt.TabIndex = 4;
            this.lblNbCiblesRateesTxt.Text = "Cibles ratées :";
            // 
            // lblNbCiblesRateesInt
            // 
            this.lblNbCiblesRateesInt.AutoSize = true;
            this.lblNbCiblesRateesInt.Location = new System.Drawing.Point(107, 24);
            this.lblNbCiblesRateesInt.Name = "lblNbCiblesRateesInt";
            this.lblNbCiblesRateesInt.Size = new System.Drawing.Size(13, 13);
            this.lblNbCiblesRateesInt.TabIndex = 3;
            this.lblNbCiblesRateesInt.Text = "0";
            // 
            // pnlStats
            // 
            this.pnlStats.Controls.Add(this.gbxNbCibles);
            this.pnlStats.Controls.Add(this.gbxNbCiblesRatees);
            this.pnlStats.Controls.Add(this.gbxTempsRestant);
            this.pnlStats.Location = new System.Drawing.Point(308, 27);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(530, 86);
            this.pnlStats.TabIndex = 7;
            this.pnlStats.Visible = false;
            // 
            // frmAimTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.btnCible);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnCommencer);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmAimTrainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAimTrainer";
            this.Load += new System.EventHandler(this.frmAimTrainer_Load);
            this.Click += new System.EventHandler(this.frmAimTrainer_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxTempsRestant.ResumeLayout(false);
            this.gbxTempsRestant.PerformLayout();
            this.gbxNbCibles.ResumeLayout(false);
            this.gbxNbCibles.PerformLayout();
            this.gbxNbCiblesRatees.ResumeLayout(false);
            this.gbxNbCiblesRatees.PerformLayout();
            this.pnlStats.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCible;
        private System.Windows.Forms.Button btnCommencer;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label lblDecompte;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsFichier;
        private System.Windows.Forms.ToolStripMenuItem tsFichierQuitter;
        private System.Windows.Forms.ToolStripMenuItem tsFichierAide;
        private System.Windows.Forms.ToolStripMenuItem tsNiveau;
        private System.Windows.Forms.ToolStripMenuItem tsNiveauQuitter;
        private System.Windows.Forms.GroupBox gbxTempsRestant;
        private System.Windows.Forms.Label lblTempsRestant;
        private System.Windows.Forms.GroupBox gbxNbCibles;
        private System.Windows.Forms.Label lblNbCiblesTxt;
        private System.Windows.Forms.Label lblNbCiblesInt;
        private System.Windows.Forms.GroupBox gbxNbCiblesRatees;
        private System.Windows.Forms.Label lblNbCiblesRateesTxt;
        private System.Windows.Forms.Label lblNbCiblesRateesInt;
        private System.Windows.Forms.Panel pnlStats;
    }
}