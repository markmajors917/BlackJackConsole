using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TernaryAndLoops
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Teranry()
        {
            int myAge = 55;
            // (condition) ? c# if true : c# if false;
            // bool IsAboveLegalAge = (myAge > 20( true : false
            bool IsAboveLegalAge;

            isAboveLegalAge = (myAge > 20) true : false
            {
                IsAboveLegalAge = true;
            }
            else
            {
                IsAboveLegalAge = false;
            }
        [TestMethod]
        public void Loops()
            {
                // Loop: A statement that allows you to run a block of code mulitple times based on a given condition
                // Comment ctrl+k+c
                // Uncomment ctrl+k+u
                int counter = 0;

                while (counter < 10)
                {
                    Console.WriteLine("Counter: " +  counter);
                    counter++;
                }

                do
                {
                    Console.WriteLine("Counter: " + counter);
                    counter++;
                } while (counter < 10);

                // Iteration varianble | Condition | How you want to change the iteration variable after you go through it once
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                }

                List<string> listOfNames = List<string>() { "Nick", "Nicole", "Oscar", "Olivia", "Patrick", "Penelope"};

                foreach (string name in listOfNames)
                {
                    Console.WriteLine(name);
                }
            }


           

            
            
        }

        private List<T> List<T>()
        {
            throw new NotImplementedException();
        }
    }
}
