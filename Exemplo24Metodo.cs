using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico
{
    internal class Exemplo24Metodo
    {
        public static void NomeCompleto(string nome)
        {

            Console.WriteLine("Meu nome completo é : " + nome + " Nobre Farias");

        }
        public static void Main(String[] args)
        {

            NomeCompleto("Mauricio");
            NomeCompleto("Lucia");

        }
    }
}

