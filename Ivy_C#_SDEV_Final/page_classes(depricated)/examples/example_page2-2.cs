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
    partial class ExampleTabPageS2
    {
        private void init()
        {
            this.HeaderLabel = new Label();
            HeaderLabel.Text = "Guessing Game";
            HeaderLabel.Location = new System.Drawing.Point(240, 0);
            HeaderLabel.Size = new System.Drawing.Size(100, 24);

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
        private Label HeaderLabel;
        private Label PromptLabel;
        private Label ResponseLabel;
        private TextBox AnswerBox;
        private Button AnswerButton;
        private Timer ResetMsg;
    }
}