using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWorkShop
{
    public class Pessoa
    {
        private int Idade { get; set; }

        private string Nome { get; set; }

        public Pessoa(string nome, int idade)
        {
            Idade = idade;
            Nome = nome;
        }

        public void Aniversario()
        {
            Idade++;
        }

        public int InformaIdade()
        {
            return Idade;
        }

        public string InformaNome()
        {
            return Nome;
        }

        public string Apresentar()
        {
            return $"Olá! Me chamo {InformaNome()} e tenho {InformaIdade()} anos.";
        }
    }
}
