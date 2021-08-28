using System;
    class Program
{
    static void Main(string[] args)
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());

            if (x == 1 & x == 2)
            {
                Console.WriteLine(2 * x);
            }
            else if (x <= 5 && x <= 8)
            {
                Console.WriteLine(3 * x + 2);
            }
            else if (x == 3 || (x >= 9 && x <= 12))
            {
                Console.WriteLine(Math.Sqrt(x));
            }
            else if (x == 4)
            {
                Console.WriteLine(Math.Pow(x, 2) - 5);
            }
            else
            {
                Console.WriteLine(x);
            }
        }
    }
}

