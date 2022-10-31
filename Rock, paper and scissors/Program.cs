using System;
using System.Threading;
namespace rps
{
    class program
    {
        static void Main(string[] args)
        {
            
            Random random = new Random();

            int playerScore=0, aiScore=0;
            
            System.Console.WriteLine("Welcome to rock, paper and scirssors!");
            Thread.Sleep(500);
            
            System.Console.WriteLine("Best of 3!");
            Thread.Sleep(500);
            
            System.Console.WriteLine("______________________________________");
            Thread.Sleep(500);

            while(playerScore!=3 && aiScore!=3)
            {
                System.Console.WriteLine("\nRock, paper or scissors...");
                Thread.Sleep(500);
                System.Console.WriteLine("Enter 'r' for rock, 'p' for paper and 's' for scissorcs.");
                char playersChoice = char.Parse(Console.ReadLine());
                
                int aisNumChoice = random.Next(0, 3);
                
                if(playersChoice=='r')
                {
                    switch(aisNumChoice)
                    {
                        case 0:
                            Thread.Sleep(500);
                            System.Console.WriteLine("AI chose rock.\nIt's a draw!");
                            break;
                        case 1:
                            Thread.Sleep(500);
                            System.Console.WriteLine("AI chose paper.\nYou lost.");
                            aiScore++;
                            break;
                        case 2:
                            Thread.Sleep(500);
                            System.Console.WriteLine("AI chose scissors.\nYou won!");
                            playerScore++;
                            break;
                        default:
                            break;
                    }
                }
                else if(playersChoice=='p')
                {
                    switch(aisNumChoice)
                    {
                        case 0:
                            Thread.Sleep(500);
                            System.Console.WriteLine("AI chose rock.\nYou won!");
                            playerScore++;
                            break;
                        case 1:
                            Thread.Sleep(500);
                            System.Console.WriteLine("AI chose paper.\nIt's a draw!");
                            break;
                        case 2:
                            Thread.Sleep(500);
                            System.Console.WriteLine("AI chose scissors.\nYou lost.");
                            aiScore++;
                            break;
                        default:
                            break;
                    }
                }
                else if(playersChoice=='s')
                {
                    switch(aisNumChoice)
                    {
                        case 0:
                            Thread.Sleep(500);
                            System.Console.WriteLine("AI chose rock.\nYou lost!");
                            aiScore++;
                            break;
                        case 1:
                            Thread.Sleep(500);
                            System.Console.WriteLine("AI chose paper.\nYou won!");
                            playerScore++;
                            break;
                        case 2:
                            Thread.Sleep(500);
                            System.Console.WriteLine("AI chose scissors.\nIt's a draw!");
                            break;
                        default:
                            break;
                }
            }
            else
            {
                System.Console.WriteLine("Invalid option.");
            }
            }
            if(aiScore>playerScore)
            {
                System.Console.WriteLine("You lost.");
            }
            else
            {
                System.Console.WriteLine("\nYou won!");
            }
            System.Console.WriteLine($"_______________\nYou scored {playerScore} points. AI socred {aiScore} points.");
            Console.ReadKey();
        }
    }
}
