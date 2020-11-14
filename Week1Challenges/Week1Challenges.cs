using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week1Challenges
{
    [TestClass]
    public class Week1Challenges
    {
        [TestMethod]
        public void TypesChallenges()
        {
            //1
            string firstName = "Lindsey";
            string lastName = "Robertson";
            int age = 37;

            //2
            string[] movies = { "Sense and Sensibility;", "Meet Me in St. Louis", "Harry Potter", "Fantastic Beasts" };

            //3
            List<DateTime> dates = new List<DateTime>();
            dates.Add(DateTime.Today);
            dates.Add(new DateTime (1982, 02, 25));
            dates.Add(new DateTime (1984, 08, 21));
            dates.Add(DateTime.Now);
            Console.WriteLine(dates [2]);

            //4
            int sum = age + 7;
            Console.WriteLine(sum);
            int diff = age - 7;
            Console.WriteLine(diff);
            int prod = age * 7;
            Console.WriteLine(prod);
            int quot = age / 7;
            Console.WriteLine(quot);
            int remainder = age % 7;
            Console.WriteLine(remainder);

            //5
            int sleepHours = 9;
            //per assignment instructions, 8 is not covered and will result in "Oh, man, get some sleep!"
            if (sleepHours >= 10)
            {
                Console.WriteLine("Wow, that's a lot of sleep!");
            }
            else if (sleepHours > 8 && sleepHours < 10)
            {
                Console.WriteLine("You should be pretty rested.");
            }
            else if (sleepHours > 4 && sleepHours < 8)
            {
                Console.WriteLine("Bummer.");
            }
            else
            {
                Console.WriteLine("Oh, man, get some sleep!");
            }


        }

        [TestMethod]
        public void SwitchCase()
        {
            //6
            Console.WriteLine("How's your day?");
            string dayRating = Console.ReadLine().ToLower();

            switch (dayRating)
            {
                case "great":
                    Console.WriteLine("Awesome!");
                    break;
                case "good":
                    Console.WriteLine("Glad your day is going well.");
                    break;
                case "okay":
                    Console.WriteLine("Hang in there.");
                    break;
                case "bad":
                    Console.WriteLine("Yikes! I'm sorry.");
                    break;
                default:
                    Console.WriteLine("That good, huh?");
                    break;
            }
        }
    }
}
