using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_unidad_3
{
    internal class Operaciones
    {
        public int NumeroA { get; set; }
        public int NumeroB { get; set; }

        public int Sumar()
        {
            return NumeroA + NumeroB;
        }

        public int Restar()
        {
            return NumeroA - NumeroB;
        }

        public int Multiplicar()
        {
            return NumeroA * NumeroB;
        }

        public int Dividir()
        {
            if (NumeroB == 0)
            {
                Console.WriteLine("Error: No se puede dividir entre cero.");
                return 0;
            }
            return NumeroA / NumeroB;
        }
    }
}
