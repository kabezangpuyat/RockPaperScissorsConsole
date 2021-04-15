using System;
using System.Collections.Generic;
using System.Linq;

namespace MNV.MiniGame_Console
{
    class Program : MiniGameConfiguration
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("***********************\n * Welcome to Rock, Paper, Scissor Text base Game \n***********************\n\n");
            Console.ForegroundColor = ConsoleColor.Blue;

            string exit = "";
            int userHP = 3;
            int computerHP = 3;
            int userPotion = 1;


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Input 'q' for ROCK");
            Console.WriteLine("Input 'w' for PAPER");
            Console.WriteLine("Input 'e' for SCISSORS");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Input 'x' to Exit \n\n\n");
            Console.ForegroundColor = ConsoleColor.Green;

            while (exit != "Y")
            {
                if (userHP == 1 && userPotion == 1)
                {
                    Console.WriteLine("Do you want to use your potion?(y/n)");
                    var useit = Console.ReadLine();
                    if(useit.ToLower()=="y")
                    {
                        userHP += 1;
                        userPotion = 0;
                        exit = "N";
                    }
                }

                string[] choices = new string[3] { "ROCK", "PAPER", "SCISSOR" };

                var rand = new Random();
                string[] computerChoices = { "q", "w", "e" };
                int index = rand.Next(computerChoices.Length);

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Enter your choice:");

                string user = Console.ReadLine().ToUpper();
                string computer = computerChoices[index];

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"You [{GameService.ChoiceConvert(user.ToLower())}]");
                Console.WriteLine($"Computer [{GameService.ChoiceConvert(computer.ToLower())}]");
                var result = GameService.Play(user, computer);
                Console.WriteLine($"{GameService.ResultMessage(result)} \n");

                if (result == 1)
                    computerHP = computerHP - 1;
                if (result == 2)
                    userHP = userHP - 1;


                //Console.WriteLine("Do u want to continue(Y/N):");
                //exit = Console.ReadLine().ToUpper();             

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"Your HP: {userHP} \nComputer HP: {computerHP}");
                Console.ForegroundColor = ConsoleColor.Green;

                if (computerHP <= 0 || userHP <= 0)
                {
                    Console.WriteLine("\n\n***********************");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    if (userHP == 0)
                        Console.WriteLine("You LOST the game.");
                    if (computerHP == 0)
                        Console.Write("You WON the game.");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("***********************\n\n");

                    Console.ForegroundColor = ConsoleColor.Green;
                    exit = "Y";
                }
                    

                Console.WriteLine("\n\n\n\n---------------------------------------");
            }
        }
    }
}
