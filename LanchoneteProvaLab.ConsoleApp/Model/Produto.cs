using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteProvaLab.ConsoleApp.Model
{
    internal class Produto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public double ValorUnitario { get; set; }
        public int QuantidadeEstoque { get; set; }
        public List<Fornecedor> Fornecedores { get; set; }

        public Produto(int id, string titulo, double valorUnitario, int quantidadeEstoque)
        {
            Id = id;
            Titulo = titulo;
            ValorUnitario = valorUnitario;
            QuantidadeEstoque = quantidadeEstoque;
            Fornecedores = new List<Fornecedor>();
        }

        public void AdicionarFornecedor(Fornecedor fornecedor)
        {
            Fornecedores.Add(fornecedor);
        }

        public void RemoverFornecedor(Fornecedor fornecedor)
        {
            Fornecedores.Remove(fornecedor);
        }
    }
}
