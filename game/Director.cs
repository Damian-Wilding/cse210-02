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

        string highlow;

        int previousCard;
        int card;
        
        int currentCard;


        public Director()
        {
                //This whole method should be blank
        }
        

        public void StartGame()
        {
            // gets the game started and runs each turn if the game is still going.
            Console.WriteLine("Welcome to the card game!");
            int card = dealer.Draw();
            while (isPlaying == true && Continue == "y") 
            {
                Console.WriteLine($"The card is {card}");
                GetInputs();
                DoUpdates(card, highlow);
                DoOutputs(previousCard, currentCard);
            }
            Console.WriteLine("You are done, the game is over.");
        }

        public string GetInputs()
        {
            // gets input from the user (asks them if they want to guess higher or lower.)
            Console.Write("Higher or Lower? [h/l] ");
            string highlow = Console.ReadLine();

            return highlow;
            
        }


        public void DoUpdates(int card, string highlow)
        {
            if(!isPlaying)
            {
                return;
            }
            score = 0;
            int previousCard = card;
            card = dealer.Draw();
            int currentCard = card;
            int points = dealer.CompareCards(previousCard, card, highlow);
            score += points;
            totalScore += score;
        }


        public void DoOutputs(int previousCard, int currentCard)
        {
            Console.WriteLine($"The card is : {previousCard}");

            Console.WriteLine($"The next card was: {currentCard}");
            Console.WriteLine($"Your score is: {totalScore}");
            Console.WriteLine($"Would you like to play again? (y/n)");
            string Continue = Console.ReadLine();
            isPlaying = (totalScore > 0);


        }
    }
}