using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    class Suma
    {
        public double N1;
        public double N2;


        public Suma()
        {
            N1 = 0;
            N2 = 0;
        }
        public Suma(double N)
        {
            N1 = N;
            N2 = 0;

        }
        public Suma(double n1, double n2)
        {
            N1 = n1;
            N2 = n2;

        }

        public double Sumar()
        {
            return (N1 + N2);

        }
 
    }
}
