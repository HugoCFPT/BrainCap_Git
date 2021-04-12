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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnReactionTime = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAimTrainer
            // 
            this.btnAimTrainer.Location = new System.Drawing.Point(65, 128);
            this.btnAimTrainer.Name = "btnAimTrainer";
            this.btnAimTrainer.Size = new System.Drawing.Size(158, 101);
            this.btnAimTrainer.TabIndex = 0;
            this.btnAimTrainer.Text = "Aim trainer";
            this.btnAimTrainer.UseVisualStyleBackColor = true;
            this.btnAimTrainer.Click += new System.EventHandler(this.btnAimTrainer_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 101);
            this.button1.TabIndex = 1;
            this.button1.Text = "Click Counter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(229, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 101);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(65, 235);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 101);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(557, 128);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 101);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnReactionTime
            // 
            this.btnReactionTime.Location = new System.Drawing.Point(393, 128);
            this.btnReactionTime.Name = "btnReactionTime";
            this.btnReactionTime.Size = new System.Drawing.Size(158, 101);
            this.btnReactionTime.TabIndex = 5;
            this.btnReactionTime.Text = "Reaction Time";
            this.btnReactionTime.UseVisualStyleBackColor = true;
            this.btnReactionTime.Click += new System.EventHandler(this.btnReactionTime_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(557, 235);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(158, 101);
            this.button6.TabIndex = 6;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(393, 235);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(158, 101);
            this.button7.TabIndex = 7;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // frmLevels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnReactionTime);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAimTrainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLevels";
            this.Text = "Niveaux";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAimTrainer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnReactionTime;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}