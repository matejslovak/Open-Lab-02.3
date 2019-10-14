using System;

namespace open_lab_01._3
{
    class Program
    {
        public static int Addition(int a)
        {
            return (++a);
        }
        static void Main(string[] args)
        {
            string line1 = Console.ReadLine();
            int a = int.Parse(line1);
            
            Console.WriteLine(Addition(a));
        }
    }
}
