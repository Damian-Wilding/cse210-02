
using System;


namespace Hilo
{
    /// <summary>
    //this is a card game bro
    /// </summary> 
    public class Dealer
    {

        int value = 0;
        
        //int points = 0;
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

            if (currentCard > previousCard )
            {   
                if (playerChoice == "h")
                {
                    return 100;
                }
                else {
                    return -75;
                }
            }
            

            else 
            {
                if (playerChoice == "h") {
                    return -75;
                }
                else {
                    return 100;
                }
            }

        }

    }
}