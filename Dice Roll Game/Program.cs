using System;
using System.Threading;

namespace RollTheDice
{
    class program
    {
        static void Main(string[] args)
        {
            dynamic playerRandomNum=0, aiRandomNum=0;
            int playerScore=0,aiScore=0;
            
            Random random = new Random();
            
            Console.WriteLine("ROLL THE DICE GAME!");
            Thread.Sleep(500);
            
            Console.WriteLine("___________________");
            Thread.Sleep(1000);
            
            Console.WriteLine("\nBest of 5!");
            
            while(playerScore!=5 && aiScore!=5)
            {
                Console.WriteLine("\nPress any key to roll the dice");
                Console.ReadKey();
                
                playerRandomNum = random.Next(1, 7);
                Console.WriteLine($"You rolled a {playerRandomNum}!");
                Thread.Sleep(1000);

                aiRandomNum = random.Next(1, 7);
                Console.WriteLine($"\nAI rolled a {aiRandomNum}");

                if(playerRandomNum>aiRandomNum)
                {
                    Console.WriteLine("You won the round!");
                    playerScore++;
                }
                else if(aiRandomNum>playerRandomNum)
                {
                    Console.WriteLine("You lost the round");
                    aiScore++;
                }
                else if(aiRandomNum==playerRandomNum)
                {
                    Console.WriteLine("It's a draw!");
                }

            }
            if(aiScore>playerScore)
            {
                Console.WriteLine("You lost.");
            }
            else
            {
                Console.WriteLine("You won!");
            }
            Console.WriteLine("Scores");
            Console.WriteLine($"AI score: {aiScore}. Your score: {playerScore}.");
            Console.ReadKey();
        }
    }
}
    