using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico
{
    internal class Exemplo18Matriz
    {
        public static void Main(string[] args)
        {
            int[,] numero = { { 1, 2, 3 }, { 7, 8, 9 } };
            Console.WriteLine(numero[0,2]);
            //mudança de valor
            numero[0, 1] = 12;
            Console.WriteLine(numero[0,1]);
        }
    }
}
