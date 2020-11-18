using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Conditionals
{
    [TestClass]
    public class ConditionalExamples
    {
        [TestMethod]
        public void Booleans()
        {
            bool isTrue = 17 > 5;
            bool isFalse = 17 == 4;
        }

        [TestMethod]
        public void IfElseStatements()
        {
            bool isTrue = true;
            if (isTrue)
            {
                //--Do something here
            }

            int age = 16;

            if ( age > 17)
            {
                Console.WriteLine("You're an adult");
            }
            else if (age > 6)
            {
                Console.WriteLine("You're still a kid");
            }
        }
        [TestMethod]
        public void SwitchCases()
        {
            int age = 42;

            switch (age)
            {
                case 18:
                    //--Code for if age is 18
                    break;
                //--Code for if age is 19
                case 19:
                    break;
                    //--Code for if age is 20
                case 20:
                    break;
                case 21:
                case 22:
                case 23:
                    //--Code here for 21-23
                    break;
                default:
                    //--Catch all code
                    Console.WriteLine("You are not 18-23");
                    break;

                    }
        }
        [TestMethod]
        public void Ternaries()
        {
            int age = 37;

            //--variable = (boolean statement) ? trueValue : falseValue;

            bool isAge = (age == 24) ? true : false;
        }
    }
}
