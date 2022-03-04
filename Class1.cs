using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aproject
{
    internal class Class1
    {
        public void class1(int num)
        {
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("Is a prime number");
            }
            else
            {
                Console.WriteLine("Is not a prime number");
            }
            Console.ReadLine();
        }

    }
}