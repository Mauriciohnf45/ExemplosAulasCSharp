using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico
{
    internal class Exemplo25Metodo
    {
        public static void Dados(string nome, string sobrenome, int idade)
        {
            Console.WriteLine("Meus Dados são: Nome Completo " + nome + " " + sobrenome +
               ". Minha idade é : " + idade );
        }
        
        public static void Main(string[] args)
        {
            Dados("Mauricio", "Henrique Nobre Farias", 19);

        }
    }
}
