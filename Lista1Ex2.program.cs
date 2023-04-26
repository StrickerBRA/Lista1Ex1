using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis:
            int a;
            double h;

            //Entrada dos dados:
            Console.Write("Aresta do quadrado: ");
            a=int.Parse(Console.ReadLine());
            
            //Calculos referentes:
            h = Math.Pow (a,2);
            Console.WriteLine("A área do quadrado de aresta {0} é {1}", a, h);
        }
    }
}
