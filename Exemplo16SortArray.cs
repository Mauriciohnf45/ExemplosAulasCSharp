using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico
{
    internal class Exemplo16SortArray
    {
        public static void Main(string[] args)
        {
            string[] produto = { "Livros", "Canetas", "Cadernos", "Agendas" };
            Array.Sort(produto);
            foreach (string i in produto)
            {
                Console.WriteLine(i);
            }
        }
        float[] preco = { 100, 32, 44, 65, 56, 1, 23, 3, 12, 45, 4, 67, 45 };
       // Array.Sort(preco);
       // foreach(float i in preco)
            
}
   // Console.WriteLine(i)
}
