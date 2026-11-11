
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ivy_C__SDEV_Final.Forms
{
    public partial class Slots : Form
    {
        private int chips = 100;
        private int bet = 10;
        private int spinsLeft = 0;

        private int final1, final2, final3;

        private Random random = new Random();
        private Timer spinTimer = new Timer();

        public Slots()
        {
            InitializeComponent();

            // Window size
            this.ClientSize = new Size(1280, 720);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Background
            Background.Dock = DockStyle.Fill;
            Background.SizeMode = PictureBoxSizeMode.StretchImage;
            Background.SendToBack();

            // Reposition slot machine controls
            MainMenuButton.SetBounds(30, 30, 150, 45);

            MoneyLabel.SetBounds(1000, 30, 250, 50);
            MoneyLabel.Font = new Font("Arial", 20, FontStyle.Bold);

            pictureBox1.SetBounds(350, 220, 150, 150);
            pictureBox2.SetBounds(565, 220, 150, 150);
            pictureBox3.SetBounds(780, 220, 150, 150);

            SpinButton.SetBounds(525, 450, 250, 70);
            SpinButton.Font = new Font("Arial", 20, FontStyle.Bold);

            MoneySlider.SetBounds(440, 550, 420, 60);
            MoneySlider.Minimum = 5;
            MoneySlider.Maximum = 200;
            MoneySlider.Value = 5;

            // Timer
            spinTimer.Interval = 100;
            spinTimer.Tick += SpinTimer_Tick;

            UpdateMoney();
            UpdateBet();
            ShowRandomSymbols();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateMoney();
            UpdateBet();
        }

        private void UpdateMoney()
        {
            MoneyLabel.Text = "Chips - $" + chips;
        }

        private void UpdateBet()
        {
            bet = MoneySlider.Value;
            SpinButton.Text = "Spin - $" + bet;
        }

        private void ShowRandomSymbols()
        {
            pictureBox1.Image = ListOfIcons.Images[random.Next(ListOfIcons.Images.Count)];
            pictureBox2.Image = ListOfIcons.Images[random.Next(ListOfIcons.Images.Count)];
            pictureBox3.Image = ListOfIcons.Images[random.Next(ListOfIcons.Images.Count)];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (chips <= 0)
            {
                MessageBox.Show("You are out of chips!");
                return;
            }

            if (bet > chips)
            {
                MessageBox.Show("Not enough chips!");
                return;
            }

            // Pay the bet
            chips -= bet;
            UpdateMoney();

            // Random final results
            final1 = random.Next(ListOfIcons.Images.Count);
            final2 = random.Next(ListOfIcons.Images.Count);
            final3 = random.Next(ListOfIcons.Images.Count);

            // Start animation
            spinsLeft = 25;
            SpinButton.Enabled = false;
            MoneySlider.Enabled = false;

            spinTimer.Start();
        }

        private void SpinTimer_Tick(object sender, EventArgs e)
        {
            ShowRandomSymbols();
            spinsLeft--;

            if (spinsLeft <= 0)
            {
                spinTimer.Stop();

                // Show final results
                pictureBox1.Image = ListOfIcons.Images[final1];
                pictureBox2.Image = ListOfIcons.Images[final2];
                pictureBox3.Image = ListOfIcons.Images[final3];

                CheckWin();

                SpinButton.Enabled = true;
                MoneySlider.Enabled = chips > 0;

                MoneySlider.Maximum = Math.Max(5, Math.Min(200, chips));

                if (chips > 0)
                {
                    MoneySlider.Value = Math.Min(MoneySlider.Value, MoneySlider.Maximum);
                    UpdateBet();
                }
                else
                {
                    SpinButton.Enabled = false;
                    MessageBox.Show("GAME OVER! You ran out of chips!");
                }

                UpdateMoney();
            }
        }

        private void CheckWin()
        {
            if (final1 == final2 && final2 == final3)
            {
                int winnings = bet * 5;
                chips += winnings;

                MessageBox.Show("JACKPOT! You won $" + winnings);
            }
            else if (final1 == final2 ||
                     final1 == final3 ||
                     final2 == final3)
            {
                int winnings = bet * 2;
                chips += winnings;

                MessageBox.Show("Two matching symbols! You won $" + winnings);
            }
            else
            {
                MessageBox.Show("No match! You lost $" + bet);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            spinTimer.Stop();

            // Find and reopen the existing Main Menu
            foreach (Form form in Application.OpenForms)
            {
                if (form != this &&
                    form.GetType().Name == "MainMenu")
                {
                    form.Show();
                    this.Close();
                    return;
                }
            }

            MessageBox.Show("Main Menu form was not found.");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            UpdateMoney();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            UpdateBet();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
        }

        private void Background_Click(object sender, EventArgs e)
        {
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            spinTimer.Stop();
            spinTimer.Dispose();

            base.OnFormClosing(e);
        }
    }
}
