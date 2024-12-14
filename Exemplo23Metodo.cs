using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico
{
    internal class Exemplo23Metodo
    {
        public static void Main(string[] args)
        {
            Nome();
            Idade();
        }

        static void Nome()
        {
            Console.WriteLine("Mauricio Henrique Nobre Farias");
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        static void Idade()
        {
            Console.WriteLine("Minha idade é 19");
        }
    }
}
