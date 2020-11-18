using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Week1ThursdayChallenge
{
    [TestClass]
    public class Week1Thursday
    {
        
        [TestMethod]
        public void SuperCaliFrag()
        {
            string name = "Supercalifragilisticeexpialidocious";

            //foreach //3  //2  //4  //1
            foreach (char letter in name)
            {
                if (letter == 'i')
                {
                    Console.WriteLine(letter);
                } 
                else
                {
                    Console.WriteLine("Not an I");
                }
                
                
            }
            
        }
        [TestMethod]
        public void ArrayChallenge()
        {
            string name = "Favorite Movies:";
            Console.WriteLine(name);
            string[] favoriteMovies = { "Back to the Future ", "Back to the Future 2 ", "Saving Private Ryan" };
            foreach (string i in favoriteMovies)
            {
                Console.WriteLine(i);
            }

        }
        [TestMethod]
        public void NameAndAge()
        {
            string firstName = "Jason";
            string lastName = "Bagwill";
            int age = 45;
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(age);
        }

        [TestMethod]
        public void Dates()
        {
            DateTime today = DateTime.Now;
            DateTime newDate2 = today.AddDays(30);
            DateTime newDate3 = today.AddDays(60);
            Console.WriteLine(today);
            Console.WriteLine(newDate2);
            Console.WriteLine(newDate3);
        }

        [TestMethod]
        public void AgePlusSeven()
        {
            int numOne = 45;
            int numTwo = 7;

            int sum = numOne + numTwo;
            Console.WriteLine(sum);
            int diff = numOne - numTwo;
            Console.WriteLine(diff);
            int prod = numOne * numTwo;
            Console.WriteLine(prod);
            int quot = numOne / numTwo;
            Console.WriteLine(quot);
            int remainder = numOne % numTwo;
            Console.WriteLine(remainder);
        }

        [TestMethod]
        public void HoursOfSleep()
        {
            int hours = 4;

            if (hours > 10)
            {
                Console.WriteLine("Wow! That's a lot of sleep!");
            }
            else if (hours > 8)
            {
                Console.WriteLine("You should be pretty rested!");
            }
            else if (hours > 4)
            {
                Console.WriteLine("Bummer");
            }
            else if (hours > 0)
            {
                Console.WriteLine("OH MAN! GET SOME SLEEP");
            }
        }
        [TestMethod]
        public void Switcheroo()
        {
            int mood = 4;
            switch (mood)
            {
                case 10:
                    Console.WriteLine("Great");
                    break;
                case 9:
                    Console.WriteLine("Good");
                    break;
                case 8:
                    Console.WriteLine("Okay");
                    break;
                case 7:
                    Console.WriteLine("Bad");
                    break;
                default:
                    Console.WriteLine(":( Hopefully improving");
                    break;

            }
         }
    }
}

