using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please provide your name and we'll get started");

            string enterName;

            enterName = Console.ReadLine();

            Console.WriteLine(enterName + "Please enter an integer between 1 and 100");

            int enterNum;
            enterNum = int.Parse(Console.ReadLine());
            int remainder = 10 % 2;
            bool keepGoing = true;

            while(keepGoing)

            if ((remainder == 1) && (enterNum >= 1) && (enterNum <= 100))
            {
                Console.WriteLine("Hello " + enterName + "you entered " + enterNum + "Odd");
            }
           else if ((remainder == 0) && (enterNum >= 2) && (enterNum <= 25))
            {
                Console.WriteLine("Guess what, " + enterName + "the number is even and less than 25.");
            }
            else if ((remainder == 0) && (enterNum >= 26) && (enterNum <= 60))
            {
                Console.WriteLine(enterName + "you've entered an even number.");
            }
           else if ((remainder == 0) && (enterNum > 60))
            {
                Console.WriteLine(enterNum + "Even.");
            } 
            else if((remainder == 1) && (enterNum > 60))
            {
                Console.WriteLine(enterNum + "Odd.");
            }
            Console.WriteLine("Would you like to quit? (y/n)");
            string result = Console.ReadLine();
            if(result == "y")
            {
                keepGoing = true;
            }
            else { }
        }
    }
}
