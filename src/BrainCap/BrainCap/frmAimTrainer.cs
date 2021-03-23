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
        int timeLeft = 30;

        public frmAimTrainer()
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
            lblDecompte.Text = timeLeft.ToString();
        }

        private void btnCommencer_Click(object sender, EventArgs e)
        {
            int locationX = rand.Next(0, 1103);
            int locationY = rand.Next(0, 681);
            //int sizeA = rand.Next(0, 1000);
            //int sizeB = rand.Next(0, 1000);

            btnCible.Location = new Point(locationX, locationY);

            //btnCible.Size = new Size(sizeA, sizeB);
            
        }

        private void tmrDecompte_Tick(object sender, EventArgs e)
        {
            //perform these actions at the interval set in the properties.
            lblDecompte.Text = timeLeft.ToString();
            timeLeft -= 1;

            if (timeLeft < 0)
            {
                tmrDecompte.Stop();
            }
        }
    }
}
