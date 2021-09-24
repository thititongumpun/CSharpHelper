using System;
using System.Text.Json;
using System.Threading;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Clue whatAmI = new Clue("โง่", "You can drive me.", "I might make you sick.", "Don't put a hole in me.", "Tie me up when you're done.");
            whatAmI.Answer = "ควาย";
            var ans = whatAmI.Answer.Trim().ToLower();
                       
            string guess = string.Empty;
            int[] guessLimitPerClue = { 3, 5, 7, 9, 11};
            int attempCount = 0;
            bool endGame = false;

            for (int i = 10; i >= 0; --i)
            {
                Console.WriteLine("Game Start In {0}", i);
                Thread.Sleep(1000);
            }

            while (guess != ans && !endGame)
            {   if (attempCount < guessLimitPerClue[0])
                {
                    Console.WriteLine("First Clue is: {0}", whatAmI.Clue1);
                    Console.Write("Guess The Answer - ");
                    guess = Console.ReadLine();
                    attempCount++;
                }
                else if (attempCount < guessLimitPerClue[1])
                {
                    Console.WriteLine("Second Clue is: {0}", whatAmI.Clue2);
                    Console.Write("Guess The Answer - ");
                    guess = Console.ReadLine();
                    attempCount++;
                }
                else if (attempCount < guessLimitPerClue[2])
                {
                    Console.WriteLine("Third Clue is: {0}", whatAmI.Clue3);
                    Console.Write("Guess The Answer - ");
                    guess = Console.ReadLine();
                    attempCount++;
                }
                else if (attempCount < guessLimitPerClue[3])
                {
                    Console.WriteLine("Fourth Clue is: {0}", whatAmI.Clue4);
                    Console.Write("Guess The Answer - ");
                    guess = Console.ReadLine();
                    attempCount++;
                }
                else if (attempCount < guessLimitPerClue[4])
                {
                    Console.WriteLine("Fifth Clue is: {0}", whatAmI.Clue5);
                    Console.Write("Guess The Answer - ");
                    guess = Console.ReadLine();
                    attempCount++;
                }
                else
                {                    
                    endGame = true;
                }                
            }
            if (endGame)
            {
                Console.WriteLine("You Lose");
                Console.WriteLine("The Answer is {0}", whatAmI.Answer);
            }
            else
            {
                Console.WriteLine("You Win!");
                Console.WriteLine("The Answer is {0}", whatAmI.Answer);
            }
            
            Console.ReadLine();
        }
    }
}
