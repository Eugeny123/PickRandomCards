using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    internal class CardPicker
    {
        static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickerCards = new string[numberOfCards];

            for (int i=0; i < numberOfCards; i++)
            {
                pickerCards[i] = RandomValue() + "of" + RandomSuit();
            }
            return pickerCards;
        }

        private static string RandomSuit()
        {
            int value = random.Next(1,5);
            if (value == 1) return "Spades";
            if (value == 2) return "Hearts";
            if (value == 3) return "Clubs";
            return "Diamonds";
        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            return;
        }
    }
}
