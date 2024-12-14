using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico
{
    internal class Exemplo07
    {
        public static void Main(string[] args)
            //Do While - Método Jailson (Bate primeiro, pergunta depois)
        {
            int contadora = 0;
            do
            {
                Console.WriteLine("Jailson");
                contadora++;
            } while (contadora < 10) ; 
        }
    }
}