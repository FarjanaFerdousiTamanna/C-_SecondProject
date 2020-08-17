using System;

namespace SecondProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 2;

            //Arithmatic Operators 

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
            Console.WriteLine(a++);
            Console.WriteLine(+a);
            Console.WriteLine(b--);
            Console.WriteLine(-b);
            Console.WriteLine(--b);

            // Comparison Operators

            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(a > b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a < b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a !< b);
            Console.WriteLine(a !> b);

            // Assignment Operators

            Console.WriteLine(a = b);
            Console.WriteLine(a += a);   // (a = a+a)
            Console.WriteLine(a -= b);
            Console.WriteLine(a *= b);

            //Logical Operators

            Console.WriteLine(a != b && a==b);
            Console.WriteLine(a != b && a==10);
            Console.WriteLine(a != b || b==2);
            Console.WriteLine(a == b);
            Console.WriteLine (!(a == b));










        }
    }
}
