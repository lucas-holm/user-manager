using System;
using System.Collections.Generic;

namespace user_manager
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> userList = new List<User>();

            while (true)
            {
                int selectedOption = ShowMainMenu();

                switch (selectedOption)
                {
                    case 1:
                        userList.Add(CreateUser());
                        break;
                    case 2:
                        ShowUsers(userList);
                        break;
                }

            }

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

        static User CreateUser()
        {
            Console.Clear();
            User user = new User();

            Console.Write("Enter the users name: ");
            string input = Console.ReadLine();
            user.Name = input;

            Console.Write("Enter the users age: ");
            int age = int.Parse(Console.ReadLine());
            user.Age = age;

            return user;

        }

        static void ShowUsers(List<User> user)
        {
            Console.Clear();

            for (int i = 0; i < user.Count; i++)
            {
                user[i].OutputInformation();
            }

            Console.Write("Press enter to return to main menu");
            Console.ReadLine();
        }

        static void MailUser()
        {

        }
    }
}
