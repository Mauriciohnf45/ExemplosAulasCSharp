using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico
{
    internal class ExibirVendaCarros
    {
        public static void Main(string[] args)
        {
            VendaCarros CarroLambo = new VendaCarros();
            Console.WriteLine("O Id do carro é: " + CarroLambo.IdCarros);
            Console.WriteLine("O modelo do carro é: " + CarroLambo.modeloCarro);
            Console.WriteLine("A cor do carro é: " + CarroLambo.corCarro);
            Console.WriteLine("O ano do carro é: " + CarroLambo.anoCarro);
            
        }
    }
}
