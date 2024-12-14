using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasico
{
    internal class ExibirMetodoCar
    {
      public static void Main(string[] args)
        {
            MetodoCar Ford = new MetodoCar();
            Console.WriteLine(Ford.model);
        }

    }
}
