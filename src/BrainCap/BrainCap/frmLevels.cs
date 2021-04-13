using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainCap
{
    public partial class frmLevels : Form
    {
        public frmLevels()
        {
            InitializeComponent();
        }

        private void btnAimTrainer_Click(object sender, EventArgs e)
        {
            var frmAimTrainer = new frmAimTrainer();
            frmAimTrainer.Show();
            this.Hide();
        } 

        private void btnReactionTime_Click(object sender, EventArgs e)
        {
            var frmReactionTime = new frmReactionTime();
            frmReactionTime.Show();
            this.Hide();
        }
<<<<<<< HEAD

        private void button1_Click(object sender, EventArgs e)
        {
            var frmClickCounter = new frmClickCounter();
            frmClickCounter.Show();
            this.Hide();
        }
=======
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Work in progress !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

>>>>>>> Killian
    }
}
