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
        public frmReactionTime()
        {
            InitializeComponent();
        }

        private void frmReactionTime_Click(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"C:\Users\Administrateur\Documents\GitHub\BrainCap_Git\src\BrainCap\BrainCap\ressources\img\RTWait.png");
            this.BackgroundImage = myimage;
            tmrRdm.Start();
        }

        private void frmReactionTime_Load(object sender, EventArgs e)
        {

        }
    }
}
