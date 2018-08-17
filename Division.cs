using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    class Division
    {
        public double N1;
        public double N2;


        public Division()
        {
            N1 = 0;
            N2 = 0;
        }
        public Division(double N)
        {
            N1 = N;
            N2 = 0;

        }
        public Division(double n1, double n2)
        {
            N1 = n1;
            N2 = n2;

        }

        public double Div()
        {
            if (N2 == 0)
            {
                Console.WriteLine("Imagínate que tiene cero galletas y las repartes entre cero amigos. /n ¿Cuántas galletas le tocan a cada amigo? No tiene sentido. /n ¿Lo ves? Así que el monstruo de las galletas está triste porque no tiene galletas /n y tú estás triste porque no tienes amigos");
                return 0;
            }
            else {
                return (N1 / N2);
            }
        }

    }

}
