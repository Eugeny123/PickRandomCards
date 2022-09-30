using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    internal class CardPicker
    {
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
            return;
        }

        private static string RandomValue()
        {
            return;
        }
    }
}
