using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico
{
    internal class Exemplo09
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("Item: " + i);

                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine("SubItem: " + j);
                }
             
            }
        }
    }
}
