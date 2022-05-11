
using System;


namespace Hilo
{
    /// <summary>
    //this is a card game bro
    /// </summary> 
    public class Dealer
    {

        int value = 0;
        
        int points = 0;
        /// <summary>
        // I don't think anything goes here
        /// </summary>
        public Dealer()
        {
        }

        /// <summary>
        // 
        /// </summary>
        public int Draw()
        {
            Random random = new Random();
            value = random.Next(1, 14);

            return value;
        }

        public int CompareCards(int previousCard, int currentCard, string playerChoice)
        {

            if (currentCard > previousCard && playerChoice == "h")
            {
                points = 100;
            }
            else if (currentCard > previousCard && playerChoice == "l")
            {
                points = -75;
            }

            if (currentCard < previousCard && playerChoice == "h")
            {
                points = -75;
            }
            else if (currentCard < previousCard && playerChoice == "l")
            {
                points = 100;
            }

            return points;

        }

    }
}