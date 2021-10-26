using System;

namespace Testing_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b1 = 1 < 0;
            Console.WriteLine(b1);

            int i = 9;
            double j = 0.2;
            Console.WriteLine(++i/j-i++);
            Console.WriteLine(i);
        }
    }
}
