using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico
{
    internal class ExibirCarro
    {
        public static void Main(string[] args)
        {
            Carro palio = new Carro();
            Console.WriteLine("O Id do carro é: " + palio.id);
            Console.WriteLine("O nome do carro é: " + palio.nome);
            Console.WriteLine("A montadora do carro é: " + palio.montadora);
            Console.WriteLine("A cor do carro é: " + palio.cor);
            Console.WriteLine("O ano do carro é: " + palio.ano);

        }
    }
}
