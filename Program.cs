using System;

namespace aproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            palindrom pa = new palindrom();
            Console.WriteLine("enter a number to check whether it is palindrom or not");
            int num = Convert.ToInt32(Console.ReadLine());
            pa.pal(num);
            Armstrong ar = new Armstrong();
            ar.Arm(num);
            Class1 prm = new Class1();
            prm.class1(num);
        }
    }
}