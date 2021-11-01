using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF164HWAss1
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Hide();

            frmHome myHome = new frmHome();
            myHome.ShowDialog();

            Show();
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Instructions to be added in the future...", "Notification",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
