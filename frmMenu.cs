using System;
using System.Media;
using System.Windows.Forms;
using System.IO;

namespace INF164HWAss1
{
    public partial class frmMenu : Form
    {
        private SoundPlayer backgroundMusic;
        private bool soundPlaying;

        public frmMenu()
        {
            InitializeComponent();

            backgroundMusic = new SoundPlayer(@"..\..\music\beat.wav");
            soundPlaying = false;
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
            try
            {
                string message;
                using (StreamReader inputFile = new StreamReader(@"..\..\files\instructions.txt"))
                {
                    message = inputFile.ReadToEnd();
                }

                MessageBox.Show(message, "Instructions", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            catch (FileNotFoundException)
            {
                MessageBox.Show("Instructions could not be loaded", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMusic_Click(object sender, EventArgs e)
        {
            if (!soundPlaying)
            {
                backgroundMusic.PlayLooping();
                soundPlaying = true;
                btnMusic.Text = "Turn Music Off";
            }
            else
            {
                backgroundMusic.Stop();
                soundPlaying = false;
                btnMusic.Text = "Turn Music On";
            }

        }
    }
}
