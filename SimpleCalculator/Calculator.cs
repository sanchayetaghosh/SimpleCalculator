using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    internal static class Calculator
    {
        static int input1 = 0;
        static int input2 = 0;

        public static void Input(ref int input1, ref int input2)
        {
            Console.WriteLine("Please provide two numbers to continue :");
            input1 = Convert.ToInt32(Console.ReadLine());
            input2 = Convert.ToInt32(Console.ReadLine());
        }
        public static int Addition()
        {
            Input(ref input1, ref input2);
            return input1 + input2;
        }
        public static int Subtraction()
        {
            Input(ref input1, ref input2);
            return input1 - input2;
        }
        public static int Division()
        {
            Input(ref input1, ref input2);
            return input1 / input2;
        }
        public static int Multiplication()
        {
            Input(ref input1, ref input2);
            return input1 * input2;
        }
        
    }
}
