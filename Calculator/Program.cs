using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int? number1 = null;
            int? number2 = null;
            do
            {
                Console.WriteLine("Please type in number.");
                var input1 = Console.ReadLine();
                try
                {
                number1 = Int16.Parse(input1);
                }
                catch (Exception e)
                {
                Console.WriteLine("Incorrect output. Please type in a NUMBER");
                }
            }
             while (number1 == null);

            do
            {
                Console.WriteLine("Please type in second number.");
                var input2 = Console.ReadLine();
                try
                {
                    number2 = Int16.Parse(input2);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Incorrect output. Please type in a NUMBER");
                }
            } while (number2 == null);



            Console.WriteLine("This is the sum: " + (number1 + number2));

            Console.WriteLine("Press Any Key to quit");
            Console.ReadKey();
        }
    }
}
