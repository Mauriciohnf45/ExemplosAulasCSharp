using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico
{
    internal class Exemplo01POO
    {
        string cor = "Vermelho";

        public static void Main(string[] args)
        {
            Exemplo01POO hulk = new Exemplo01POO();
            Console.WriteLine("A cor do super herói Hulk é: " + hulk.cor);
        }
    }
}
