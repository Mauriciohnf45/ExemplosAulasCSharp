using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico
{
    internal class Exemplo15Array
    {
        public static void Main(string[] args)
        {
            string[] nome = { "Ana", "Bruna", "Carolina", "Daiane" };
            foreach (string i in nome)
            {
                Console.WriteLine(i);
            }

        }
    }
}
