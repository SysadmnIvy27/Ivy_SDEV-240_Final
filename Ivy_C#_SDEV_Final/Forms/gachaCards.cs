using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ivy_C__SDEV_Final.Forms
{
    
    public partial class gachaCards : Form
    {
        string jsonCardsPath = "JsonFilePathHere"; // May not need this. May hard bake the cards into program and just use json for individual user data. 
        private int userChips = 10000; // Example value, replace with actual user chips value later on
        private string userName_standin = "Mr. Guy";
        public int UserChips

        {
            get { return userChips; }
            set
            {
                userChips = value;
                lblUserMoney.Text = $"Chips: {userChips}";
            }
        }

        public gachaCards()
        {
            InitializeComponent();
            lblUserMoney.Text = $"Chips: {UserChips}";
            lblUserName.Text = $"{userName_standin}";

        }

        Card[] cards = //ID, Weight, Value, TexturePath
            {
            new Card (1, 50, 100, "C:\\Users\\Jdement3\\Documents\\Group Project\\Ivy_C#_SDEV_Final\\Resources\\gachaCard1_filler.png"), // Common card
            new Card (2, 50, 50, "C:\\Users\\Jdement3\\Documents\\Group Project\\Ivy_C#_SDEV_Final\\Resources\\gachaCard2_filler.png"), // Common card
            new Card (3, 30, 125, "C:\\Users\\Jdement3\\Documents\\Group Project\\Ivy_C#_SDEV_Final\\Resources\\gachaCard3_filler.png"), // Uncommon card
            new Card (4, 15, 200, "C:\\Users\\Jdement3\\Documents\\Group Project\\Ivy_C#_SDEV_Final\\Resources\\gachaCard4_filler.png"), // Rare card
            new Card (5, 5, 300, "C:\\Users\\Jdement3\\Documents\\Group Project\\Ivy_C#_SDEV_Final\\Resources\\gachaCard5_filler.png") // Rare card
            };

        private void btnBuyCopper_Click(object sender, EventArgs e)
        {
            if (UserChips >= 250)
            {
                UserChips -= 250;
                lblUserMoney.Text = $"Chips: {UserChips}";
                OpenPack(5); 
            }
            else if (UserChips < 250)
            {
                MessageBox.Show("Insufficient chips.");
            }
        }

        private void btnBuyIron_Click(object sender, EventArgs e)
        {
            if (UserChips >= 500)
            {
                UserChips -= 500;
                lblUserMoney.Text = $"Chips: {UserChips}";
                OpenPack(5);
            }
            else if (UserChips < 500)
            {
                MessageBox.Show("Insufficient chips.");
            }
        }

        private void btnBuyBronze_Click(object sender, EventArgs e)
        {
            if (UserChips >= 1000)
            {
                userChips -= 1000;
                lblUserMoney.Text = $"Chips: {userChips}";
                OpenPack(5);
            }
            else if (UserChips < 1000)
            {
                MessageBox.Show("Insufficient chips.");
            }
        }

        private void btnBuySilver_Click(object sender, EventArgs e)
        {
            if (UserChips >= 2000)
            {
                userChips -= 2000;
                lblUserMoney.Text = $"Chips: {userChips}";
                OpenPack(5);
            }
            else if(UserChips < 2000)
            {
                MessageBox.Show("Insufficient chips.");
            }
        }

        private void btnBuyGold_Click(object sender, EventArgs e)
        {
            if (UserChips >= 4000)
            {
                userChips -= 4000;
                lblUserMoney.Text = $"Chips: {userChips}";
                OpenPack(5);
            }
            else if (UserChips < 4000)
            {
                MessageBox.Show("Insufficient chips.");
            }
        }

        private void btnViewBinder_Click(object sender, EventArgs e)
        {
            gachaCardsBinder binderForm = new gachaCardsBinder();
            binderForm.Owner = this; // Sets the owner of the binder form to the current gachaCards form
            binderForm.Show();
            this.Hide();
        }
        public class Card
        {
            public int cardID;
            public int cardWeight;
            public int cardValue;
            public string cardTexturePath;

            public Card(int id, int weight, int value, string texturePath)
            {
                cardID = id;
                cardWeight = weight;
                cardValue = value;
                cardTexturePath = texturePath; // Assuming the texture files are named after the card ID and stored in a folder named "CardTextures"
            }

        };

        /*Need method to randomly select a card based on weight,
        applying the earned value to the user's chips and displaying 
        the cards pulled (5 cards per pack?)*/
        
        public void OpenPack(int packSize) // Need to go back and adjust this method 
        {
            Random rand = new Random();
            List<Card> pulledCards = new List<Card>();
            for (int i = 0; i < packSize; i++)
            {
                int totalWeight = cards.Sum(c => c.cardWeight);
                int randomValue = rand.Next(0, totalWeight);
                int cumulativeWeight = 0;
                foreach (var card in cards)
                {
                    cumulativeWeight += card.cardWeight;
                    if (randomValue < cumulativeWeight)
                    {
                        pulledCards.Add(card);
                        UserChips += card.cardValue; // Add the value of the pulled card to the user's chips
                        break;
                    }
                }
            }
            // Display the pulled cards and their values
            string message = "You pulled the following cards:\n";
            foreach (var card in pulledCards)
            {
                message += $"Card ID: {card.cardID}, Value: {card.cardValue}\n";
            }
            MessageBox.Show(message);
        }


    }
}