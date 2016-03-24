using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task1
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        decimal moneyHas = decimal.Parse(Console.ReadLine());
        decimal litresWants = decimal.Parse(Console.ReadLine());
        decimal litresHas = 0;

        switch (day)
        {
            case 0: litresHas = (moneyHas / 25.0m);
                break;//Monday – 25.0 leva;
            case 1: litresHas = (moneyHas / 21.0m);
                break;//Tuesday – 21.0 leva;
            case 2: litresHas = (moneyHas / 14.0m);
                break;//Wednesday – 14.0 leva;     
            case 3: litresHas = (moneyHas / 17.0m);
                break;//Thursday – 17.0 leva;
            case 4: litresHas = (moneyHas / 45.0m);
                break;//Friday – 45.0 leva;
            case 5: litresHas = (moneyHas / 59.0m);
                break;//Saturday – 59.0 leva;
            case 6: litresHas = (moneyHas / 42.0m);
                break;//Sunday – 42.0 leva;
            default: Console.WriteLine("Write a number between 0 and 6!");
                break;
        }

        
        string condition = "0";
        if (litresHas > 1.5m)
        {
            condition = "very drunk";
        }

        else if (litresHas >= 1.0m && litresHas < 1.5m)
        {
            condition = "drunk";
        }

        else if (litresHas < 1.0m)
        {
            condition = "sober";
        }

        if (litresHas > litresWants)
        {
            Console.WriteLine("Bai Ivan is {0} and very happy and he shared {1:F2} l. of alcohol with his friends", condition, (litresHas - litresWants));
        }

        else if (litresHas == litresWants)
        {
            Console.WriteLine("Bai Ivan is {0} and happy. He is as drunk as he wanted", condition);
        }

        else if (litresHas < litresWants)
        {
            Console.WriteLine("Bai Ivan is {0} and quite sad. He wanted to drink another {1:F2} l. of alcohol", condition, (litresWants - litresHas));
        }
    }
}