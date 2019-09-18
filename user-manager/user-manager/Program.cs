using System;

namespace user_manager
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMainMenu();
        }

        /// <summary>
        /// Shows the main menu to the user
        /// </summary>
        /// <returns>Selected menu option</returns>
        static int ShowMainMenu()
        {
            Console.Clear();

            Console.WriteLine("### Welcome to user manager ###");
            Console.WriteLine("1. Create a user");
            Console.WriteLine("2. Show all users");
            Console.WriteLine("3. Mail a user");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");

            string input = Console.ReadLine();
            int selectedOption = int.Parse(input);

            return selectedOption;
        }
    }
}
