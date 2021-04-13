
namespace BrainCap
{
    partial class frmClickCounter
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
            this.btnCommencer = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.gbxNbCibles = new System.Windows.Forms.GroupBox();
            this.lblNbClicsTxt = new System.Windows.Forms.Label();
            this.lblNbClicsInt = new System.Windows.Forms.Label();
            this.gbxTempsRestant = new System.Windows.Forms.GroupBox();
            this.lblTempsRestant = new System.Windows.Forms.Label();
            this.lblDecompte = new System.Windows.Forms.Label();
            this.pnlScore = new System.Windows.Forms.Panel();
            this.lblScoreInt = new System.Windows.Forms.Label();
            this.lblScoreTxt = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnClick = new System.Windows.Forms.Button();
            this.pnlStats.SuspendLayout();
            this.gbxNbCibles.SuspendLayout();
            this.gbxTempsRestant.SuspendLayout();
            this.pnlScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCommencer
            // 
            this.btnCommencer.Location = new System.Drawing.Point(364, 178);
            this.btnCommencer.Name = "btnCommencer";
            this.btnCommencer.Size = new System.Drawing.Size(486, 181);
            this.btnCommencer.TabIndex = 2;
            this.btnCommencer.Text = "Commencer";
            this.btnCommencer.UseVisualStyleBackColor = true;
            this.btnCommencer.Click += new System.EventHandler(this.btnCommencer_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(364, 448);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(486, 181);
            this.btnRetour.TabIndex = 3;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // pnlStats
            // 
            this.pnlStats.Controls.Add(this.gbxNbCibles);
            this.pnlStats.Controls.Add(this.gbxTempsRestant);
            this.pnlStats.Location = new System.Drawing.Point(364, 12);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(486, 93);
            this.pnlStats.TabIndex = 8;
            this.pnlStats.Visible = false;
            // 
            // gbxNbCibles
            // 
            this.gbxNbCibles.Controls.Add(this.lblNbClicsTxt);
            this.gbxNbCibles.Controls.Add(this.lblNbClicsInt);
            this.gbxNbCibles.Location = new System.Drawing.Point(48, 19);
            this.gbxNbCibles.Name = "gbxNbCibles";
            this.gbxNbCibles.Size = new System.Drawing.Size(163, 54);
            this.gbxNbCibles.TabIndex = 6;
            this.gbxNbCibles.TabStop = false;
            // 
            // lblNbClicsTxt
            // 
            this.lblNbClicsTxt.AutoSize = true;
            this.lblNbClicsTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblNbClicsTxt.Location = new System.Drawing.Point(36, 24);
            this.lblNbClicsTxt.Name = "lblNbClicsTxt";
            this.lblNbClicsTxt.Size = new System.Drawing.Size(35, 13);
            this.lblNbClicsTxt.TabIndex = 4;
            this.lblNbClicsTxt.Text = "Clics :";
            // 
            // lblNbClicsInt
            // 
            this.lblNbClicsInt.AutoSize = true;
            this.lblNbClicsInt.Location = new System.Drawing.Point(100, 24);
            this.lblNbClicsInt.Name = "lblNbClicsInt";
            this.lblNbClicsInt.Size = new System.Drawing.Size(13, 13);
            this.lblNbClicsInt.TabIndex = 3;
            this.lblNbClicsInt.Text = "0";
            // 
            // gbxTempsRestant
            // 
            this.gbxTempsRestant.Controls.Add(this.lblTempsRestant);
            this.gbxTempsRestant.Controls.Add(this.lblDecompte);
            this.gbxTempsRestant.Location = new System.Drawing.Point(284, 19);
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
            // lblDecompte
            // 
            this.lblDecompte.AutoSize = true;
            this.lblDecompte.Location = new System.Drawing.Point(107, 24);
            this.lblDecompte.Name = "lblDecompte";
            this.lblDecompte.Size = new System.Drawing.Size(34, 13);
            this.lblDecompte.TabIndex = 3;
            this.lblDecompte.Text = "29.34";
            // 
            // pnlScore
            // 
            this.pnlScore.Controls.Add(this.lblScoreInt);
            this.pnlScore.Controls.Add(this.lblScoreTxt);
            this.pnlScore.Location = new System.Drawing.Point(291, 282);
            this.pnlScore.Name = "pnlScore";
            this.pnlScore.Size = new System.Drawing.Size(631, 77);
            this.pnlScore.TabIndex = 9;
            this.pnlScore.Visible = false;
            // 
            // lblScoreInt
            // 
            this.lblScoreInt.AutoSize = true;
            this.lblScoreInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreInt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblScoreInt.Location = new System.Drawing.Point(326, 20);
            this.lblScoreInt.Name = "lblScoreInt";
            this.lblScoreInt.Size = new System.Drawing.Size(150, 39);
            this.lblScoreInt.TabIndex = 1;
            this.lblScoreInt.Text = "un score";
            // 
            // lblScoreTxt
            // 
            this.lblScoreTxt.AutoSize = true;
            this.lblScoreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreTxt.Location = new System.Drawing.Point(3, 20);
            this.lblScoreTxt.Name = "lblScoreTxt";
            this.lblScoreTxt.Size = new System.Drawing.Size(317, 39);
            this.lblScoreTxt.TabIndex = 0;
            this.lblScoreTxt.Text = "Votre score est de :";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(364, 365);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(486, 116);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(12, 126);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(1160, 623);
            this.btnClick.TabIndex = 11;
            this.btnClick.Text = "Click";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Visible = false;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // frmClickCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pnlScore);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnCommencer);
            this.Controls.Add(this.btnClick);
            this.Name = "frmClickCounter";
            this.Text = "frmClickCounter";
            this.Click += new System.EventHandler(this.frmClickCounter_Click);
            this.pnlStats.ResumeLayout(false);
            this.gbxNbCibles.ResumeLayout(false);
            this.gbxNbCibles.PerformLayout();
            this.gbxTempsRestant.ResumeLayout(false);
            this.gbxTempsRestant.PerformLayout();
            this.pnlScore.ResumeLayout(false);
            this.pnlScore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCommencer;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.GroupBox gbxNbCibles;
        private System.Windows.Forms.Label lblNbClicsTxt;
        private System.Windows.Forms.Label lblNbClicsInt;
        private System.Windows.Forms.GroupBox gbxTempsRestant;
        private System.Windows.Forms.Label lblTempsRestant;
        private System.Windows.Forms.Label lblDecompte;
        private System.Windows.Forms.Panel pnlScore;
        private System.Windows.Forms.Label lblScoreInt;
        private System.Windows.Forms.Label lblScoreTxt;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnClick;
    }
}