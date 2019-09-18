using System;
using System.Collections.Generic;
using System.Text;

namespace user_manager
{
    public class User
    {
        public string Name;
        public int Age;


        public void OutputInformation()
        {
            Console.Clear();

            Console.WriteLine($"The users name is {Name}");
            Console.WriteLine($"{Name} is {Age} years old");
        }
    }
}
