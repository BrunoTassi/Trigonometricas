using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_potencia
{
    class Calculo
    {
        public void Potencia(int x , int y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {pot}");
        }

        public void seno (double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);

            Console.WriteLine($"Seno de {angulo} é igual {Math.Round(seno,4)}");
        }
        public void cosseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);

            Console.WriteLine($"cosseno de {angulo} é igual {Math.Round(coseno,4)}");
        }
        public void tangente (double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);

            Console.WriteLine($"tangente de {angulo} é igual {Math.Round(tangente,4)}");
        }
    }
}
