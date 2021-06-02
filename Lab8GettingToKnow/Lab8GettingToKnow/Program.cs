using System;
using System.Collections.Generic;

namespace Lab8GettingToKnow
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>(){"Mark", "James", "Andrew", "Tommy", "Maggie",
            "Jerome", "Trent", "Troy", "Kevin", "Joshua", "Sean", "Kate"};
            List<string> foods = new List<string>() { "Cilantro", "Sushi", "Sushi", "Chicken Curry",
                "Movie Theatre Popcorn", "Italian Cuisine", "Tacos", "Broccoli", "Asian Cuisine", "Nalesniki", "MEAT", "Pizza"};
            List<string> hometown = new List<string>() {"Grand Rapids","Toledo","Grayslake", "Raleigh",
                "Montrose", "Milwaukee","Rochester", "Indian River", "Detroit","Northville", "Zeeland"};
            for (int i = 0; i < 12; i++)
            {
                PrintWhole(names);
                string input = GetUserInput("Which person would you like to learn about?");
                int index = int.Parse(input);
                Console.WriteLine(index);
                string name = names[index];
                Console.WriteLine(name);
                string input2 = UserInput($"What would you like to learn about " + name + "? Hometown or favorite food?");

                if (input2 == "hometown")
                {
                    string ht = hometown[index];
                    Console.WriteLine(ht);
                    Console.WriteLine("Would you like to learn about another student? Y/N");
                    string userResponse = Console.ReadLine();
                }
                else if (input2 != "hometown")
                {
                    Console.WriteLine("Invalid entry, please try again.");
                    Console.WriteLine(i);
                }
                else if (input2 == "favorite food")
                {
                    string food = foods[index];
                    Console.WriteLine(food);
                    Console.WriteLine("Would you like to learn about another student? Y/N");
                }
                string userResponse2 = Console.ReadLine();

                    if (userResponse2 == "Y")
                {
                    Console.WriteLine(i);
                }
                else
                {
                    System.Environment.Exit(0);
                }

            }

        }

        public static void PrintWhole(List<string> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i}: {items[i]}");
            }
        }
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine().ToLower().Trim();
            return input;
        }
        public static string UserInput(string message)
        {
            Console.WriteLine(message);
            string input2 = Console.ReadLine().ToLower().Trim();
            return input2;
        }



    }
}
