using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteProvaLab.ConsoleApp.Model
{
    internal class Venda
    {
        public List<ItemVenda> ProdutosVendidos { get; set; }
        public string FormaPagamento { get; set; }
        public string CpfCliente { get; set; }

        public Venda(string formaPagamento, string cpfCliente)
        {
            ProdutosVendidos = new List<ItemVenda>();
            FormaPagamento = formaPagamento;
            CpfCliente = cpfCliente;
        }

        public void AdicionarProduto(Produto produto, int quantidade)
        {
            ProdutosVendidos.Add(new ItemVenda(produto, quantidade));
        }

        public void RemoverProduto(Produto produto)
        {
            foreach (var item in ProdutosVendidos)
            {
                if (item.Produto == produto)
                {
                    ProdutosVendidos.Remove(item);
                    break;
                }
            }
        }

        public double CalcularValorTotal()
        {
            double total = 0;
            foreach (var item in ProdutosVendidos)
            {
                total += item.Produto.ValorUnitario * item.Quantidade;
            }
            return total;
        }
    }
}
