using System;

namespace SFUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Store");
                string userChoice;
                Console.WriteLine("[1] - Do you want to clear the screen");
                Console.WriteLine("[2] - Do you want to exit out of the program?");
                userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("User has chosen to clear the screen");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("You have exited the program!");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadLine();
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice: Press enter to try again");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
