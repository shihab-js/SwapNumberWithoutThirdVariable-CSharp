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

            //1. using by * and /
            int a = 10, b = 15;

            //print message to show the user
            Console.WriteLine("Before swap a = " + a + " and b = " + b);

            a = a * b; // a = 150
            b = a / b; // b = 10
            a = a / b; // a = 15

            //print result
            Console.WriteLine("After swap a = " + a + " and b = " + b);

            //2. using by + and -
            int c = 5, d = 10;

            //print message to show the user
            Console.WriteLine("Before swap c = " + c + " and d = " + d);

            c = c + d; // c = 15
            d = c - d; // d = 5
            c = c - d; // c = 10

            //print result
            Console.Write("After swap c = " + c + " and d = " + d);
        }
    }
}
