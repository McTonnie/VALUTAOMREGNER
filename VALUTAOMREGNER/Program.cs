using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VALUTAOMREGNER
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hvor mange Danske kroner vil du omregne");
            double input = double.Parse(Console.ReadLine());


            double USD = 611.98;

            double EUR = 744.04;

            double GBP = 835.58;

            double SEK = 73.80;


            Console.WriteLine(input * USD / 100 + " USD");
            Console.WriteLine(input * EUR / 100 + " EUR");
            Console.WriteLine(input * GBP / 100 + " GBP");
            Console.WriteLine(input * SEK / 100 + " SEK");
            Console.ReadKey();
        }
    }
}
