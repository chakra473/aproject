using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aproject
{
    internal class palindrom
    {
        public void pal(int num)
        {
            int temp, rem, rev = 0;
            temp = num;
            while (num > 0)
            {
                rem = num % 10;
                rev = ((rev * 10) + rem);
                num = num / 10;
            }
            if (temp == rev)
            {
                Console.WriteLine(temp + " is palindrom number");
            }
            else
            {
                Console.WriteLine(temp + " is not palindrom number");
            }
        }
    }
}
