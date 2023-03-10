using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteProvaLab.ConsoleApp.Model
{
    internal class Fornecedor
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public Fornecedor(string nome, string endereco)
        {
            Nome = nome;
            Endereco = endereco;
        }
    }
}
