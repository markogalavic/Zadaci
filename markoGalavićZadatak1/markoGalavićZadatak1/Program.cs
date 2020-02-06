using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markoGalavićZadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;
            float b; 
            float c;
            float d;
            float prosjek = 0;
            Console.WriteLine("Unesi tri broja");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = a + b + c;
            prosjek = d / 3;
            Console.WriteLine("Prosjek je:" + prosjek);
            Console.ReadKey();
                

        }
    }
}
