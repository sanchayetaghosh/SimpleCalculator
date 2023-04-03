using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator !");
            Console.WriteLine("Please provide two numbers to continue :");

            int input1 = Convert.ToInt32(Console.ReadLine());
            int input2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please provide the operator to procceed :\n1. Addition\n2. Subtraction\n3. Division\n4. Multiplication");

            string operatorAction = Console.ReadLine();

            int result = 0;

            
            switch (operatorAction)
            {
                case "Addition":
                    result = Calculator.Addition(input1, input2);
                    break;
                case "Subtraction":
                    result = Calculator.Subtraction(input1, input2);
                    break;
                case "Division":
                    result = Calculator.Division(input1, input2);
                    break;
                case "Multiplication":
                    result = Calculator.Multiplication(input1, input2);
                    break;
                default:
                    Console.WriteLine("Kindly insert a valid input");
                    break;
            }

            Console.WriteLine("The " + operatorAction + " of " + input1 + " and " + input2 + " is = " + result);
        }
    }
}
