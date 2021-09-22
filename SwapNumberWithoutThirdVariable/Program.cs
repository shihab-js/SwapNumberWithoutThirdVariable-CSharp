using System;

namespace SwapNumberWithoutThirdVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            //There are two common way to swap two numbers without using third variable
            // 1. using by * and /
            // 2. using by + and -

            //1. using by + and -
            int a = 10, b = 15;

            //print message to show the user
            Console.WriteLine("Before swap a = " + a + " and b = " + b);

            a = a * b; // a = 150
            b = a / b; // b = 10
            a = a / b; // a = 15

            Console.Write("After swap a = " + a + " and b = " + b);

        }
    }
}
