using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task2
{
    static void Main()
    {
        int numberOfCabins = int.Parse(Console.ReadLine());

        string nextCommand = Console.ReadLine();
        while (nextCommand != "Found a free one!")
        {
            int stepsCount = int.Parse(nextCommand);
            nextCommand = Console.ReadLine();
            break;
        }
    }
}