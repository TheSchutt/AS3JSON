using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityRepository;
using ServiceIO;

namespace AS3JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassBIZ CB = new ClassBIZ();
            ClassDollar cd = new ClassDollar();
            DollarRates DR = CB.useJSON(cd.GetValutaFromOpenExchangeRates());

            Console.WriteLine(DR.Rates["DKK"].ToString());

            foreach (var item in DR.Rates)
            {
                Console.WriteLine("{0} {1}", item.Key, item.Value);
            }
            Console.WriteLine();

            foreach (var item in DR.RatesList)
            {
                Console.WriteLine("{0} {1}", item.Country, item.Value);
            }
            Console.ReadLine();

        }
    }
}
