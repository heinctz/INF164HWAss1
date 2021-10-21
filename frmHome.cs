using System;
using System.Windows.Forms;
using INF164HWAss1.ExceptionHandling;

namespace INF164HWAss1
{
    public partial class frmHome : Form
    {
        private int maxLevel = 0;
        private int minLevel = 0;

        private int gold;
        private Tamagotchi tamagotchi;

        public frmHome()
        {
            InitializeComponent();

            this.tamagotchi = new Tamagotchi(maxLevel, maxLevel, maxLevel);
            this.gold = 0;
        }

        public int Gold
        {
            get { return this.gold; }
            set { this.gold = value; }
        }

        public Tamagotchi HomeTamagotchi
        {
            get { return this.tamagotchi; }
            set { this.tamagotchi = value; }
        }
    }
}
