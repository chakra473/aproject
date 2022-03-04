using System;

namespace palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            palindrom pa =new palindrom();
            Console.WriteLine("enter a number to check whether it is palindrom or not");
            int num=Convert.ToInt32(Console.ReadLine());
            pa.pal(num);
        }
    }
}
