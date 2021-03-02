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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnLevels_Click(object sender, EventArgs e)
        {
            var FormLevels = new frmLevels();
            FormLevels.Show();
            this.Hide();
        }

        private void btnChallenge_Click(object sender, EventArgs e)
        {
            var FormChallenge = new frmChallenge();
            FormChallenge.Show();
            this.Hide();
        }
    }
}
