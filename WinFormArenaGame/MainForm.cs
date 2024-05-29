using ArenaGame;
using ArenaGame.Heroes;
using ArenaGame.Weapons;
using ArenaGame.Special_Weapons;
using System.Linq;

namespace WinFormArenaGame
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }
        public Hero heroA, heroB;
        public ISpecialWeapon? weaponA, weaponB;

        private void gameNotification(GameEngine.NotificationArgs args)
        {
            TextBox tbAttacker;
            if (args.Attacker.Equals(heroA))
            {
                tbAttacker = tbKnight;
            }
            else
                tbAttacker = tbAssassin;

            tbAttacker.AppendText(
                $"{args.Attacker.Name} attacked {args.Defender.Name} with {Math.Round(args.Attack, 2)} and caused {Math.Round(args.Damage, 2)} damage.\r\n");

            DateTime dt = DateTime.Now;

            while (DateTime.Now - dt < TimeSpan.FromMilliseconds(300))
            {
                Application.DoEvents();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox1.SelectedIndex)
            {
                case 0://knight
                    label2.Text = "Knight:";
                    heroA = new Knight("Knight", 10, 20, new Sword("Sword"), null);
                    break;
                case 1://assassin
                    label2.Text = "Assassin: ";
                    heroA = new Assassin("Assassin", 10, 5, new Dagger("Dagger"), null);
                    break;
                case 2://new hero 1
                    label2.Text = "Paladin: ";
                    heroA = new Paladin("Paladin", 15, 7, new Sword("Sword"), null);
                    break;
                case 3:// new hero 2
                    label2.Text = "Barbarian: ";
                    heroA = new Barbarian("Barbarian", 15, 7, new Sword("Sword"), null);
                    break;

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0://knight
                    label1.Text = "Knight: ";
                    heroB = new Knight("Knight", 10, 20, new Sword("Sword"), null);
                    break;
                case 1://assassin
                    label1.Text = "Assassin: ";
                    heroB = new Assassin("Assassin", 10, 5, new Dagger("Dagger"), null);
                    break;
                case 2://new hero 1
                    label1.Text = "Paladin: ";
                    heroB = new Paladin("Paladin", 15, 7, new Sword("Sword"), null);
                    break;
                case 3:// new hero 2
                    label1.Text = "Barbarian: ";
                    heroB = new Barbarian("Barbarian", 15, 7, new Sword("Sword"), null);
                    break;

            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1 && comboBox3.SelectedIndex != -1 && comboBox4.SelectedIndex != -1)
            {
                lbWinner.Text = "";
                tbAssassin.Text = "";
                tbKnight.Text = "";
                lbWinner.Visible = false;

                heroA.SpecialWeapon = weaponA;
                heroB.SpecialWeapon = weaponB;
                GameEngine gameEngine = new GameEngine()
                {
                    HeroA = heroA,
                    HeroB = heroB,
                    NotificationsCallBack = gameNotification
                };

                imgFight.Enabled = true;
                gameEngine.Fight();
                imgFight.Enabled = false;

                lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
                lbWinner.Visible = true;
            }
            else
            {
                MessageBox.Show("Select one from each boxes!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private void lbWinner_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            lbWinner.Text = String.Empty;
            tbAssassin.Text = String.Empty;
            tbKnight.Text = String.Empty;
            label1.Text = String.Empty;
            label2.Text = String.Empty;
            label8.Text = String.Empty;
            label9.Text = String.Empty;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedIndex)
            {
                case 0://axe
                    weaponA = new LeviathanAxe("leviathan1");
                    label8.Text = "Spceial power: " + weaponA.SpecialPower;
                    break;
                case 1://blades
                    weaponA = new BladesOfChaos("Kratos1");
                    label8.Text = "Spceial power: " + weaponA.SpecialPower;
                    break;
                case 2://spear
                    weaponA = new DupnirSpear("Odin1");
                    label8.Text = "Spceial power: " + weaponA.SpecialPower;
                    break;
                case 3://none
                    weaponA = null;
                    break;

            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox4.SelectedIndex)
            {
                case 0://axe
                    weaponB = new LeviathanAxe("levi2");
                    label9.Text = "Spceial power: " + weaponB.SpecialPower;
                    break;
                case 1://blades
                    weaponB = new BladesOfChaos("ZEUSSS");
                    label9.Text = "Spceial power: " + weaponB.SpecialPower;
                    break;
                case 2://spear
                    weaponB = new DupnirSpear("Kratos2");
                    label9.Text = "Spceial power: " + weaponB.SpecialPower;
                    break;
                case 3://none
                    weaponB = null;
                    break;

            }
        }
    }
}