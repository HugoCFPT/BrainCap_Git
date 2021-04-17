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
            MessageBox.Show("Work in progress !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult fermer = MessageBox.Show("Voulez vous vraiment Quitter", "Quitter", MessageBoxButtons.YesNo);
            if (fermer == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
              
            }

        }
    }
}
