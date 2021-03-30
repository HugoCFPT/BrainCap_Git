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
    public partial class frmAimTrainer : Form
    {
        Random rand = new Random();
        Timer tmrDecompte = new Timer();
        double timeLeft = 30.00;
        int NbCibles = 0;
        int NbCiblesRatees = 0;

        public frmAimTrainer()
        {
            InitializeComponent();

            //set properties for the Timer
            tmrDecompte.Interval = 1;
            tmrDecompte.Enabled = true;

            //Set the event handler for the timer, named "myTimer_Tick"
            tmrDecompte.Tick += tmrDecompte_Tick;

            //Start the timer as soon as the form is loaded
            tmrDecompte.Start();

            //Show the time set in the "timeLeft" variable
            string timeLeft2 = timeLeft.ToString();
            if (timeLeft2 != "30")
            {
                lblDecompte.Text = timeLeft2.Substring(0, 5);
            }
        }

        private void btnCommencer_Click(object sender, EventArgs e)
        {
            int locationX = rand.Next(12, 1092);
            int locationY = rand.Next(105, 669);
            //int sizeA = rand.Next(0, 1000);
            //int sizeB = rand.Next(0, 1000);
            btnCible.Location = new Point(locationX, locationY);

            btnCommencer.Hide();
            btnRetour.Hide();
            btnCible.Show();
            tsNiveau.Visible = true;
            pnlStats.Visible = true;
            NbCibles = 0;
            NbCiblesRatees = 0;

            lblNbCiblesRateesInt.Text = Convert.ToString(NbCiblesRatees);

            //btnCible.Size = new Size(sizeA, sizeB);

        }

        private void tmrDecompte_Tick(object sender, EventArgs e)
        {
            //perform these actions at the interval set in the properties.
            lblDecompte.Text = timeLeft.ToString();
            timeLeft -= 0.01;

            if (timeLeft < 0)
            {
                tmrDecompte.Stop();
            }
        }

        private void btnCible_Click(object sender, EventArgs e)
        {
            int locationX = rand.Next(12, 1092);
            int locationY = rand.Next(87, 669);
            btnCible.Location = new Point(locationX, locationY);

            NbCibles++;
            lblNbCiblesInt.Text = Convert.ToString(NbCibles);
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            var FormLevels = new frmLevels();
            FormLevels.Show();
            this.Hide();
        }

        private void frmAimTrainer_Load(object sender, EventArgs e)
        {
            btnCible.Hide();
            tsNiveau.Visible = false;
        }

        private void frmAimTrainer_Click(object sender, EventArgs e)
        {
            NbCiblesRatees++;
            lblNbCiblesRateesInt.Text = Convert.ToString(NbCiblesRatees);
        }
    }
}
