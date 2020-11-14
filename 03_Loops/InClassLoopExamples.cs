using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Loops
{
    [TestClass]
    public class InClassLoopExamples
    {
        [TestMethod]
        public void Loops()
        {
            int studentCount = 10;

            //For loop
            for (int i = 0; i <= studentCount; i++)
            {
                Console.WriteLine(i);
            }

            //For Each loop
            string[] names = { "Michael", "Simon", "Peyton", "Casey" };
            Console.WriteLine(names);//gives "System.String[]" and not a list of names
            foreach (string name in names)
            {
                Console.WriteLine(name);//this foreach loop results in a list of names
            }

            Console.WriteLine(names.Length);//gives the number of strings in the array

            //While Loop
            while (studentCount > 0)
            {
                Console.WriteLine(studentCount);
                studentCount --;
            }
        }
    }
}
