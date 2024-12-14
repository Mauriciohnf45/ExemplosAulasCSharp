using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico
{
    internal class Exemplo26Metodo
    {
        public static void Main(string[] args)
        {
            static void PaisOrigem(string pais = "Brasil")
            {
                Console.WriteLine("Meu país de origem é : " + pais);
                
            }

            PaisOrigem("Argentina");
            PaisOrigem("Chile");
            PaisOrigem();
            PaisOrigem("Guatemala");
            
        }
    }
}
