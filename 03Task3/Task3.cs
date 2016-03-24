using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task3
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}^{0}",
            new string('\'', n));//PART 1

        for (int i = 0; i < (n / 2); i++)//PART2
        {
            Console.WriteLine("{0}{1}{0}",
                new string('\'', ((n - 1) - i)),
                new string('^', (((n * 2) + 1) - (((n - 1) - i) * 2))));
        }

        for (int i = 0; i < ((n / 2) + 1); i++)//PART3
        {
            Console.WriteLine("{0}{1}{0}",
                new string('\'', ((n - 1) - i)),
                new string('^', (((n * 2) + 1) - (((n - 1) - i) * 2))));
        }

        for (int i = 0; i < ((n / 2) + 1); i++)//PART 4
        {
            Console.WriteLine("{0}{1} {1}{0}", 
                new string('\'',(n-1)),
                new string('|',1));
        }
        Console.WriteLine("{0}", 
            new string('-',((n*2)+1)));//PART 5
    }
}