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
        //List<Dealer> cards = new List<Dealer>();
        Dealer dealer = new Dealer();
        bool isPlaying = true;
        int score = 0;
        int totalScore = 0;
        string Continue = "y";

        public Director()
        {
                //This whole method should be blank
        }
        

        public void StartGame()
        {
            // gets the game started and runs each turn if the game is still going.
            Console.WriteLine("Welcome to the card game!");
            while (isPlaying == true && Continue == "y") {
                int card = dealer.Draw();
                Console.WriteLine($"The card is {card}");
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
            if(!isPlaying)
            {
                return;
            }
            score = 0;
            int OldCard = card;
            int card = dealer.Draw();
            int points = dealer.CompareCards(OldCard, card, highlow);
            score += points;
            totalScore += score;
        }


        public void DoOutputs()
        {
            //I don't think the following lines are needed. -Damian
            
            //if (!isPlaying)
            //{
            //    return;
            //}
            //string values = "";
            //foreach (Dealer card in cards)
            //{
            //    values += $"{card.value} ";
            //}

            Console.WriteLine($"The card is: {card}");
            Console.WriteLine($"Your score is: {totalScore}\n");
            Console.WriteLine($"Would you like to play again? (y/n)");
            string Continue = Console.ReadLine();
            isPlaying = (totalScore > 0);

        }
    }
}