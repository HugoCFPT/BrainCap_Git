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
    public partial class frmReactionTime : Form
    {
        private int startseconds;

        private DateTime startReactionTime;
        private DateTime endReactionTime;
        private double elapseMilliseconds;
     


        private int sequence;
        public frmReactionTime()
        {
            InitializeComponent();
            sequence = 0;
            lblResult.Visible = false;
        }

        private void frmReactionTime_Click(object sender, EventArgs e)
        {
            switch (sequence)
            {
                case 0:// Start phase
                    {
                        Image myimage = new Bitmap(@"C:\Users\Administrateur\Documents\GitHub\BrainCap_Git\src\BrainCap\BrainCap\ressources\img\RTWait.png");
                        this.BackgroundImage = myimage;

                        Random ran = new Random();
                        startseconds = ran.Next(1000, 5000);
                        System.Threading.Tasks.Task.Delay(startseconds).ContinueWith((_) => StartReaction());
                        ++sequence;
                        break;
                    }
                case 1:// Reaction phase
                    {
                        endReactionTime = DateTime.Now;
                        Image myimage = new Bitmap(@"C:\Users\Administrateur\Documents\GitHub\BrainCap_Git\src\BrainCap\BrainCap\ressources\img\RTResultat.png");
                        this.BackgroundImage = myimage;

                        TimeSpan sp = endReactionTime - startReactionTime;
                        elapseMilliseconds = sp.TotalMilliseconds;
                        ++sequence;
                        lblResult.Text = elapseMilliseconds.ToString();
                        lblResult.Visible = true;
                        break;
                    }
                case 3:

                    {
                 
                        break;
                    }
            }

                    //tmrRdm.Start();
            }

        private void StartReaction()
        {
            Image myimage = new Bitmap(@"C:\Users\Administrateur\Documents\GitHub\BrainCap_Git\src\BrainCap\BrainCap\ressources\img\RTClick.png");
            this.BackgroundImage = myimage;
            startReactionTime = DateTime.Now;
        }
    }
}
