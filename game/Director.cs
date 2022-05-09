using System;
using System.Collections.Generic;


namespace Hilo
{
    /// <summary>
    /// A person who directs the game. 
    ///
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Director
    {
        List<Dealer> cards = new List<Dealer>();
        bool isPlaying = true;
        public Director()
        {
           
        }

        public void StartGame()
        {

        }

        public void GetInputs()
        {

        }


        public void DoUpdates()
        {

        }


        public void DoOutputs()
        {
            if (!isPlaying)
            {
                return;
            }

            string values = "";
            foreach (Dealer card in cards)
            {
                values += $"{card.value} ";
            }

            Console.WriteLine($"The card is: {card}");
            Console.WriteLine($"Your score is: {totalScore}\n");
            isPlaying = (score > 0);
        }
    }
}