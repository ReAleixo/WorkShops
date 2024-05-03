using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWorkShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa Joao = new Pessoa("João Pereira Navarro", 35);
            Console.WriteLine(Joao.Apresentar());
            Console.ReadKey();
        }
    }
}
