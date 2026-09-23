using Ivy_C__SDEV_Final;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace page_classes
{
    public partial class ExampleTabPage : TabPage
    {
        string page_name = "Example (Guessing Game)";
        Random rand = new Random();
        int prev_guess = -1;
        int current_guess;
        int num = -1;
        private Label HeaderLabel;
        private Label PromptLabel;
        private Label ResponseLabel;
        private TextBox AnswerBox;
        private Button AnswerButton;
        private Timer ResetMsg;
        public ExampleTabPage()
        {
            this.Text = page_name;

            this.HeaderLabel = new Label();
            HeaderLabel.Text = "Guessing Game";
            HeaderLabel.Location = new System.Drawing.Point(240, 0);
            HeaderLabel.Size = new System.Drawing.Size(100,24);

            this.PromptLabel = new Label();
            PromptLabel.Text = "Pick a number from 1 to 10";
            PromptLabel.Location = new System.Drawing.Point(0, 16);
            PromptLabel.Size = new System.Drawing.Size(200, 24);

            this.ResponseLabel = new Label();
            ResponseLabel.Text = "Placeholder";
            ResponseLabel.Location = new System.Drawing.Point(0, 48);
            ResponseLabel.Size = new System.Drawing.Size(256, 24);

            this.AnswerBox = new TextBox();
            AnswerBox.Location = new System.Drawing.Point(0, 80);
            AnswerBox.Size = new System.Drawing.Size(32, 32);
            AnswerBox.TabIndex = 0;

            this.AnswerButton = new Button();
            AnswerButton.Text = "Guess";
            AnswerButton.Location = new System.Drawing.Point(0, 110);
            AnswerButton.Size = new System.Drawing.Size(64, 24);
            AnswerButton.Click += new EventHandler(this.OnAnswerButtonClick);
            AnswerButton.TabIndex = 1;

            this.ResetMsg = new Timer();

            this.Controls.AddRange(new Control[]
            {
                    HeaderLabel,
                    PromptLabel,
                    ResponseLabel,
                    AnswerBox,
                    AnswerButton
            });
        }
        public void OnAnswerButtonClick(object sender, EventArgs e)
        {
            AnswerButton.Enabled = false;
            ResponseLabel.Text = "Thinking";
            GameLogic();
        }
        public async Task GameLogic()
        {
            current_guess = Convert.ToInt32(AnswerBox.Text);
            if (num == -1)
            {
                num = rand.Next(1, 11);
            }
            if (prev_guess != -1)
            {
                if (current_guess < prev_guess && prev_guess < num)
                {
                    ResponseLabel.Text = ("Idiot, I said you were low not high.");
                    await Task.Delay(2000);
                }
                if (current_guess > prev_guess && prev_guess > num)
                {
                    ResponseLabel.Text = ("Idiot, I said you were high not low.");
                    await Task.Delay(2000);
                }
            }
            if (current_guess < num)
            {
                ResponseLabel.Text = ("Too low, guess higher!");
            }
            else if (current_guess > num)
            {
                ResponseLabel.Text = ("Too high, guess lower!");
            }
            prev_guess = current_guess;

            if (current_guess == num)
            {
                ResponseLabel.Text = $"You Win! The number was {Convert.ToInt32(num)}";
                await Task.Delay(1000);
                num = -1;
                prev_guess = -1;
                ResponseLabel.Text = "Guessing Game has reset, Guess again!";
                AnswerBox.Clear();
            }
            AnswerButton.Enabled = true;
        }
    }
}
    