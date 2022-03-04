using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Armstrong
    {
        public void Arm(int num)
        {
            int r, sum = 0, temp;
            temp = num;
            while (num > 0)
            {
                r = num % 10;
                sum= sum+ (r*r*r);
                num=num/10;
            }
            if (temp == sum)
            {
                Console.WriteLine("The number is Armstrong Number");
            }
            else
            {
                Console.WriteLine("The number is not Armstrong Number");
            }
        }
       
    }
}
