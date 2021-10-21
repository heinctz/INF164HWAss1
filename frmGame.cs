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
    public partial class frmGame : Form
    {
        private int gold;
        private Tamagotchi tamagotchi;

        public frmGame(Tamagotchi tamagotchi, int gold)
        {
            InitializeComponent();
            this.gold = gold;
            this.tamagotchi = new Tamagotchi(tamagotchi);
        }
        public int Gold
        {
            get { return gold; }
        }
        public Tamagotchi EditedTamagotchi
        {
            get { return tamagotchi; }
        }

        private void frmGame_Shown(object sender, EventArgs e)
        {
            
        }
    }
}
