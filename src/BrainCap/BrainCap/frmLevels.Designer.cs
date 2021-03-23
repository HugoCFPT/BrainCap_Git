namespace BrainCap
{
    partial class frmLevels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLevels));
            this.btnAimTrainer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAimTrainer
            // 
            this.btnAimTrainer.Location = new System.Drawing.Point(154, 127);
            this.btnAimTrainer.Name = "btnAimTrainer";
            this.btnAimTrainer.Size = new System.Drawing.Size(158, 101);
            this.btnAimTrainer.TabIndex = 0;
            this.btnAimTrainer.Text = "Aim trainer";
            this.btnAimTrainer.UseVisualStyleBackColor = true;
            this.btnAimTrainer.Click += new System.EventHandler(this.btnAimTrainer_Click);
            // 
            // frmLevels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.btnAimTrainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLevels";
            this.Text = "Niveaux";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAimTrainer;
    }
}