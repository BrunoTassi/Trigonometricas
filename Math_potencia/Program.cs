using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_potencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculo calc = new Calculo();
            //calc.Potencia(3, 3);

            calc.seno(30);
            calc.cosseno(30);
            calc.tangente(30);

            Console.ReadKey();
        }
    }
}
