using System;

namespace Open_Lab_02._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers");
            string firstnumber = Console.ReadLine();
            string secondnumber = Console.ReadLine();
            double a = Convert.ToInt32(firstnumber);
            double b = Convert.ToInt32(secondnumber);
            double c = a % b;
            Console.WriteLine(c);

        }
    }
}
