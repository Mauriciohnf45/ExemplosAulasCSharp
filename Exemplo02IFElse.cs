﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico
{
    internal class Exemplo02IFElse
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Digite uma idade: ");
            int idade = Convert.ToInt16(Console.ReadLine());
            if (idade < 18)
            {
                Console.WriteLine("Não pode iniciar o processo de habilitação");
            }
            else
            {
                Console.WriteLine("Pode iniciar o processo de habilitação");
            }
        }
    }
}