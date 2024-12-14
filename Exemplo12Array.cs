using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace DotNetBasico

{

    internal class Exemplo12Array

    {

        public static void Main(string[] args)
        {
            //Criação do Vetor - Array unidimensional
            string[] carro = { "uno", "passat", "veloster", "gol" };
            //impressão do segundo elemento
            Console.WriteLine(carro[1]);
            //Alteração do segundo elemento
            carro[1] = "Corolla";
            //Impressão da alteração do segundo elemento
            Console.WriteLine(carro[1]);
            //Impressão da quantidade de elementos de um vetor
            Console.WriteLine(carro.Length);


        }

    }

}

