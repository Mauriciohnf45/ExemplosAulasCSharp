﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico
{
    internal class Exemplo14Array
    {
        public static void Main(string[] args)
        {
            string[] nome = { "Ana", "Bruna", "Carolina", "Daiane" };
            for (int i = 0; i < nome.Length; i++)
            {
                Console.WriteLine(nome[i]);
            }
        }
    }
}
