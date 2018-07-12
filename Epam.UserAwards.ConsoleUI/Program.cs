using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.UsersAwards.Containers;

namespace Epam.UsersAwards.ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var logic = AwardsContainer.AwardLogic;

            //logic.Add()
        }

        private void LaunchApp()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Welcome to Users-Awards application!");
                Console.WriteLine("Press:");

                Console.WriteLine("1. Show all users.");
                Console.WriteLine("2. Add user.");
                Console.WriteLine("3. Delete user.");
                Console.WriteLine("0. Exit.");

                var userChoice = Console.ReadKey();

                switch (userChoice.Key)
                {
                    case ConsoleKey.D1:
                        foreach (var user in )
                        {
                            Console.WriteLine(user);
                        }
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        break;
                    case ConsoleKey.D0:
                        break;
                    default:
                        Console.WriteLine("Unknown command. Try again.");
                        break;
                }
            }
        }
    }
}
