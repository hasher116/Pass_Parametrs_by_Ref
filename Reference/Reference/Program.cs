using System;

namespace Reference
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;
            int c = 5;
            Console.WriteLine($"Начальное значение переменной a = {a}");
            Method1(a);
            Console.WriteLine($"Конечное значение переменной a = {a}\n");
            Console.WriteLine($"Начальное значение переменной b = {b}");
            b=Method2(b);
            Console.WriteLine($"Конечное значение переменной b = {b}\n");
            Console.WriteLine($"Начальное значение переменной c = {c}");
            Method3(ref c);
            Console.WriteLine($"Конечное значение переменной c = {c}\n");
        }
        static void Method1(int x)
        {
            x++;
            Console.WriteLine($"Method 1: {x}");
        }

        static int Method2(int x)
        {
            x++;
            Console.WriteLine($"Method 2: {x}");
            return x;
        }
        static void Method3(ref int x)
        {
            x++;
            Console.WriteLine($"Method 3: {x}");
        }
    }
}
