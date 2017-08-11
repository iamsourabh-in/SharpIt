using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackToSuccess.Basics
{

    public class GuessGame
    {
        int prev_guess = 0;
        private const int SECRET = 354;
        private int noOfTries = 0;

        public void TryThis(int guess)
        {
            if (guess > SECRET)
                TryAgain("Greater");
            else if (guess < SECRET)
                TryAgain("Less");
            else if (guess == SECRET)
                DeclareWinner();
        }

        private void TryAgain(string status)
        {
            Console.WriteLine("Guess the SECRET, Your previous guess was {0}", status);
            int userguess = Convert.ToInt32(Console.ReadLine());
            if (prev_guess != userguess)
                noOfTries++;
            prev_guess = userguess;
            TryThis(userguess);
        }

        private void DeclareWinner()
        {
            Console.WriteLine("You won after {0} tries", noOfTries);
            Console.ReadLine();
        }

        public void StartGame()
        {
            TryAgain("Nothing");
        }

        public static void Execute()
        {
            GuessGame game = new GuessGame();
            game.StartGame();
        }

    }
}
