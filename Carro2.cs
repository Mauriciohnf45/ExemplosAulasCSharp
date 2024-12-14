using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico
{
    internal class Carro2
    {
        string cor = "vermelho";

        public static void Main(string[] args)
        {

            Carro2 carroSenac = new Carro2();
            Console.WriteLine("A cor do carro é : " + carroSenac.cor);

        }
    }
}
