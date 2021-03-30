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
            HideResult();
        }

        /// <summary>
        /// Montrer le résultat
        /// </summary>
        /// <param name="InResult">Le résultation en millisecondes</param>
        private void ShowResult(double InResult)
        {
            lblResult.Text = InResult.ToString();
            lblResult.Visible = true;

        }
        /// <summary>
        /// Cacher le résultat
        /// </summary>
        private void HideResult()
        {
            lblResult.Text = "";
            lblResult.Visible = false;

        }

        private void frmReactionTime_Click(object sender, EventArgs e)
        {
            SimulateSequence();
        }

        private void SimulateSequence()
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
                        ShowResult(elapseMilliseconds);
                        break;
                    }
                default: 
                    break;

            }

        }
        private void StartReaction()
        {
            Image myimage = new Bitmap(@"C:\Users\Administrateur\Documents\GitHub\BrainCap_Git\src\BrainCap\BrainCap\ressources\img\RTClick.png");
            this.BackgroundImage = myimage;
            startReactionTime = DateTime.Now;
        }

        private void frmReactionTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'x': // Pour quitter la simulation
                    {
                        this.Close();
                        break;
                    }

                default: // N'importe quelle touche pour recommencer
                    {
                        sequence = 0;
                        HideResult();
                        SimulateSequence();
                        break;
                    }
            }

        }
    }
}
