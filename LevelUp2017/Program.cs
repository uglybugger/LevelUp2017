using System;
using System.Collections.Generic;

namespace LevelUp2017
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var myFriends = new List<string>();
            for (var i = 0; i < 3; i++)
            {
                Console.WriteLine($"Round {i} of {3}");
                Console.WriteLine("What is your name?");
                var personName = Console.ReadLine();
                Console.WriteLine($"Hello, {personName}!");
                Console.WriteLine($"Isn't it a lovely {(DateTime.Now.Hour < 12 ? "morning" : "afternoon")}?");
                Console.WriteLine("Do you like cookies?");
                var likesCookies = bool.Parse(Console.ReadLine());
                if (likesCookies)
                {
                    myFriends.Add(personName);
                    Console.WriteLine("That's great! I like cookies, too!");
                }
                else
                {
                    Console.WriteLine("Get away from me, you sick person.");
                }
                Console.WriteLine();
            }

            foreach (var friend in myFriends)
            {
                Console.WriteLine($"{friend} is my friend");
            }

            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }
    }
}