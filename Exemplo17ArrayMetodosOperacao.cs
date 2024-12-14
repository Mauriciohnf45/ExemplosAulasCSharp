using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico
{
    internal class Exemplo17ArrayMetodosOperacao
    {
        public static void Main(string[] args)
        {
            int[] numeros = { 7, 10, 2, 5 };
            Console.WriteLine(numeros.Max());
            Console.WriteLine(numeros.Min());
            Console.WriteLine(numeros.Sum());
        }
    }
}
