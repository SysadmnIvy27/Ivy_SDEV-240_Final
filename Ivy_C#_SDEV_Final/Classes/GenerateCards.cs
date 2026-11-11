using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivy_C__SDEV_Final.Classes
{
    public class GenerateCards : Object
    {
        Random rnd = new Random();
        List<String> spadeCards = new List<String>() { "A", "2", "3", "4", "5", "6", "7", "8", "9", "0", "J", "Q", "K" };
        List<String> clubCards = new List<String>() { "A", "2", "3", "4", "5", "6", "7", "8", "9", "0", "J", "Q", "K" };
        List<String> heartCards = new List<String>() { "A", "2", "3", "4", "5", "6", "7", "8", "9", "0", "J", "Q", "K" };
        List<String> diamondCards = new List<String>() { "A", "2", "3", "4", "5", "6", "7", "8", "9", "0", "J", "Q", "K" };
        List<String> allCards = new List<String>() { "A", "2", "3", "4", "5", "6", "7", "8", "9", "0", "J", "Q", "K" };
        public string GenerateCard()
        {
            var v = 0;
            var value = "0";
            int suit = rnd.Next(4);
            if (suit == 0)
            {
                if (spadeCards.Count == 0)
                {
                    GenerateCard();
                }
                v = rnd.Next(spadeCards.Count);
                value = spadeCards[v];
                spadeCards.RemoveAt(v);
                return $"{value}♠";
            }
            else if (suit == 1)
            {
                if (clubCards.Count == 0)
                {
                    GenerateCard();
                }
                v = rnd.Next(clubCards.Count);
                value = clubCards[v];
                clubCards.RemoveAt(v);
                return $"{value}♣";
            }
            else if (suit == 2)
            {
                if (heartCards.Count == 0)
                {
                    GenerateCard();
                }
                v = rnd.Next(heartCards.Count);
                value = heartCards[v];
                heartCards.RemoveAt(v);
                return $"{value}♥";
            }
            else if (suit == 3)
            {
                if (diamondCards.Count == 0)
                {
                    GenerateCard();
                }
                v = rnd.Next(diamondCards.Count);
                value = diamondCards[v];
                diamondCards.RemoveAt(v);
                return $"{value}♦";
            }
            else return null;
        }
        public void ResetDeck()
        {
            spadeCards = allCards;
            clubCards = allCards;
            heartCards = allCards;
            diamondCards = allCards;
        }
    }
}
