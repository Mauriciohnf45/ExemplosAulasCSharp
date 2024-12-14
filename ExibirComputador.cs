using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico
{
    internal class ExibirComputador
    {
        public static void Main(string[] args)
        {
            Computador computadorMau = new Computador();
            Console.WriteLine("O Id do computador é: " + computadorMau.IdComputador);
            Console.WriteLine("A marca do computador é: " + computadorMau.marcaComputador);
            Console.WriteLine("O fabricante do computador é: " + computadorMau.fabricanteComputador);
            Console.WriteLine("O processador do computador é: " + computadorMau.processadorComputador);
            Console.WriteLine("A memória RAM do computador é: " + computadorMau.memoriaRamComputador);
            Console.WriteLine("O armazenamento do computador é: " + computadorMau.armazenamentoComputador);
            Console.WriteLine("O Sistema Operacional do computador é: " + computadorMau.sistemaOperacionalComputador);
            Console.WriteLine("O preço do computador é: " + computadorMau.precoComputador);
        }
    }
}
