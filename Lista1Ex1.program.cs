using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis:
            int a, b;
            double c;

            //Entrada dos dados:
            Console.Write("informe a base: ");
            a=int.Parse(Console.ReadLine());
            Console.Write("Informe a altura: ");
            b=int.Parse(Console.ReadLine());

            //Calculos referentes:
            c = (a * b);
            Console.WriteLine($"A área de um retângulo de base {a} e altura {b} é {c}.");
            Console.WriteLine();
        }
    }
