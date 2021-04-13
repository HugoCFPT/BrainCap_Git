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
    public partial class frmClickCounter : Form
    {
        Timer tmrDecompte = new Timer();
        int timeLeft = 10;
        double Clics = 0;
        double Score = 0;

        public frmClickCounter()
        {
            InitializeComponent();

            //set properties for the Timer
            tmrDecompte.Interval = 1000;
            tmrDecompte.Enabled = true;

            //Set the event handler for the timer, named "myTimer_Tick"
            tmrDecompte.Tick += tmrDecompte_Tick;

            //Start the timer as soon as the form is loaded
            tmrDecompte.Start();

            //Show the time set in the "timeLeft" variable
            string timeLeft2 = timeLeft.ToString();
            if (timeLeft2 != "10")
            {
                lblDecompte.Text = timeLeft2.Substring(0, 5);
            }
        }
        private void tmrDecompte_Tick(object sender, EventArgs e)
        {
            //perform these actions at the interval set in the properties.
            lblDecompte.Text = timeLeft.ToString();
            timeLeft -= 1;

            if (timeLeft < 0)
            {
                pnlStats.Hide();
                pnlScore.Visible = true;
                btnOk.Visible = true;
                tmrDecompte.Stop();
                Score = Clics / 10;
                lblScoreInt.Text = Score.ToString() + "c/s (" + Clics + " clics)";
            }
        }
        private void btnCommencer_Click(object sender, EventArgs e)
        {
            pnlStats.Visible = true;
            btnCommencer.Hide();
            btnRetour.Hide();
            btnClick.Visible = true;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            var FormLevels = new frmLevels();
            FormLevels.Show();
            this.Hide();
        }

        private void frmClickCounter_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Clics = 0;
            timeLeft = 10;
            lblScoreInt.Text = "0";
            btnOk.Hide();
            pnlScore.Visible = false;
            btnCommencer.Show();
            btnRetour.Show();
            btnClick.Hide();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            Clics++;
            lblNbClicsInt.Text = Clics.ToString();
        }
    }
}
