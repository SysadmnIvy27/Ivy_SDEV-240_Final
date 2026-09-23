using Ivy_C__SDEV_Final;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Ivy_C__SDEV_Final.Program;

namespace page_classes
{
    public partial class Mainmenu : TabPage
    {
        string page_name = "Main Menu"; // The name of the TabPage header
        int timer_time = 300; // The amount of time on the timer by default
        decimal timer_remain = 0; // The current remaining time on the timer
        private TextBox name_text; // The text box where the user enters their name
        private Button name_btn; // The button that confirms the user's name
        private Button chips_btn; // The button that gives the player free chips
        private Label name_label; // The label that displays the players name
        private Label time_remaining; // The label for the 5 minutes between free chips
        private Timer chip_refresh; // The timer for the 5 minutes between free chips
        public event EventHandler InfoChanged; // An event handler for updating player 
        public Mainmenu() // The constructor of the Mainmenu class. Callable with 'TabPage variablename = new Mainmenu'
        {
            this.Text = page_name; // Sets the name of the TabPage header 'or tab name'

            this.chip_refresh = new Timer(); // creates a new timer under the variable chip_refresh
            chip_refresh.Interval = 1000; // sets the interval of chip_refresh in miliseconds to 1000ms or one second
            chip_refresh.Enabled = true; // ensures that chip_refresh is enabled
            chip_refresh.Tick += new EventHandler(this.timer_timeout); // connects the tick event to the timer_timeout event handler
            
            this.name_text = new TextBox(); // creates a new textbox under the variable name_text
            name_text.Location = new System.Drawing.Point(0, 0); // sets the position (x,y) of name_text from top left hand corner of the window
            name_text.Size = new System.Drawing.Size(120,16); // sets the rectangular size of name_text
            name_text.TabIndex = 0; // sets the TabIndex to 0

            this.name_btn = new Button(); // creates a new button under the variable name_btn
            name_btn.Text = "Confirm name."; // sets the text of name_btn
            name_btn.Location = new System.Drawing.Point(0, 32); // sets the position (x,y) of name_btn from top left hand corner of the window
            name_btn.Size = new System.Drawing.Size(120, 28); // sets the rectangular size of name_btn
            name_btn.Click += new EventHandler(this.OnNameBtnClick); // connects the Click event to the OnNameBtnClick event handler
            name_btn.TabIndex = 1; // sets the TabIndex to 1

            this.chips_btn = new Button(); // creates a new button under the variable chips_btn
            chips_btn.Text = "Claim 100 free chips!"; // sets the text of chips_btn
            chips_btn.Location = new System.Drawing.Point(0,84); // sets the position (x,y) of chips_btn from top left hand corner of the window
            chips_btn.Size = new System.Drawing.Size(120,28); // sets the rectangular size of chips_btn
            chips_btn.Click += new EventHandler(this.OnChipsBtnClicked); // connects the Click event to the OnChipsBtnClicked event handler
            chips_btn.TabIndex = 2; // sets the TabIndex to 2

            this.name_label = new Label(); // creates a new label under the variable name_label
            name_label.Location = new System.Drawing.Point(200,0); // sets the position (x,y) of name_label from top left hand corner of the window
            name_label.Size = new System.Drawing.Size(64,16); // sets the rectangular size of name_label

            this.time_remaining = new Label(); // creates a new label under the variable time_remaining
            time_remaining.Text = "0:00"; // sets the text of time_remaining
            time_remaining.Location = new System.Drawing.Point(0,120); // sets the position (x,y) of time_remaining from top left hand corner of the window
            time_remaining.Size = new System.Drawing.Size(32,16); // sets the rectangular size of time_remaining

            this.Controls.AddRange(new Control[] // Add all child controls to the parent TabPage
            {
                name_text,
                name_label,
                name_btn,
                chips_btn,
                time_remaining
            });
        }
        private void OnNameBtnClick(object sender, EventArgs e) // Event listener for setting the User's name when the name_btn is clicked
        {
            username = name_text.Text;
            name_label.Text = username;
            InfoChanged?.Invoke(this, EventArgs.Empty);
            name_btn.Enabled = false;
            Debug.WriteLine(username);
        }
        private void OnChipsBtnClicked(object sender, EventArgs e)
        {
            chips = chips + 100;
            InfoChanged?.Invoke(this, EventArgs.Empty);
            timer_remain = timer_time;
            chip_refresh.Start();
            chips_btn.Enabled = false;
        }
        private void timer_timeout(object sender, EventArgs e)
        {
            if (timer_remain > 0)
            {
                timer_remain--;
                decimal minutes = Math.Floor(timer_remain / 60);
                decimal seconds = (timer_remain % 60);
                string formatted = $"{minutes}:{seconds:00}";
                time_remaining.Text = formatted;
            } else
            {
                chip_refresh.Stop();
                chips_btn.Enabled = true;
            }
        }

    }
}
