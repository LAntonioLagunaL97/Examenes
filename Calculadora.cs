using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    class Calculadora
    {
        static void Main(string[] args)
        {
             double A;
            double B;
            Console.WriteLine("\n Introduce dos numeros \t");
            Console.WriteLine("\t Primer Numero");
            
            A= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\t Segundo numero Numero");
            B = Convert.ToDouble(Console.ReadLine());
            
            Suma S1 = new Suma(A, B);

            Console.WriteLine("La suma es = {0}", S1.Sumar());
            if (B == 0)
            {
                Console.WriteLine("La division es = \n Imagínate que tiene cero galletas y las repartes entre cero amigos. \n ¿Cuántas galletas le tocan a cada amigo ? No tiene sentido. \n ¿Lo ves ? Así que el monstruo de las galletas está triste porque no tiene galletas \n y tú estás triste porque no tienes amigos");
            }
            else
            {
               Division D1 = new Division(A,B);
                Console.WriteLine("La Division es = {0}", D1.Div());
            }

            Console.ReadKey();

        }
            
           
        
    }
}
