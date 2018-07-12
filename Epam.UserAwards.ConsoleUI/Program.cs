using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.UsersAwards.Containers;
using Epam.UsersAwards.BLL.Contracts;

namespace Epam.UsersAwards.ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            IUserLogic userLogic; // = ???;
            IAwardLogic awardLogic; // = ???;

            // Консольный UI
            LaunchApp(userLogic, awardLogic);
        }

        private static void LaunchApp(IUserLogic userLogic, IAwardLogic awardLogic)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Welcome to Users-Awards application!");
                Console.WriteLine("Press:");

                Console.WriteLine("1. Show all users.");
                Console.WriteLine("2. Add user.");
                Console.WriteLine("3. Edit user");
                Console.WriteLine("4. Delete user.");
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
                        Console.Clear();

                        Console.Write("Surname: ");
                        string surname = Console.ReadLine();

                        Console.Write("Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Birthdate: ");
                        string birthdate = Console.ReadLine();

                        userLogic.Add(surname, name, birthdate);
                        break;

                    case ConsoleKey.D3:
                        Console.Clear();
                        Console.WriteLine("User id: ");
                        int userId = int.Parse(Console.ReadLine());

                        Console.WriteLine("What would you like to edit?");
                        Console.WriteLine("1. Name");
                        Console.WriteLine("2. Birth date");

                        var userEditChoice = Console.ReadKey(false);

                        switch (userEditChoice.Key)
                        {
                            case ConsoleKey.D1:
                                Console.WriteLine("Enter new name: ");
                                string newName = Console.ReadLine();
                                userLogic.EditName(userId, newName);
                                break;

                            case ConsoleKey.D2:
                                break;

                            default:
                                Console.WriteLine("Unknown command!");
                                break;
                        }

                        break;

                    case ConsoleKey.D4:
                        Console.Clear();
                        Console.WriteLine("Enter user id: ");

                        int toDeletUserId = int.Parse(Console.ReadLine());
                        userLogic.DeleteUser(toDeletUserId);
                        break;

                    case ConsoleKey.D0:
                        return;

                    default:
                        Console.WriteLine("Unknown command. Try again.");
                        break;
                }
            }
        }
    }
}
