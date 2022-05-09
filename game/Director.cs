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
            // gets the game started and runs each turn if the game is still going.
            Console.WriteLine("Welcome to the card game!");
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
            
        }

        public void GetInputs()
        {
            // gets input from the user (asks them if they want to guess higher or lower.)
            Console.Write("Higher or Lower? [h/l] ");
            string highlow = Console.ReadLine();
            
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