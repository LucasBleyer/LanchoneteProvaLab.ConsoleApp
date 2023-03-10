using LanchoneteProvaLab.ConsoleApp.Model;
using System;
using System.Threading;

namespace LanchoneteProvaLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Cria um produto e adiciona um fornecedor
            //Produto produto = new Produto(1, "Caneta", 2.5, 50);
            //Fornecedor fornecedor = new Fornecedor("Fornecedor 1", "Rua 1, nº 1");
            //produto.AdicionarFornecedor(fornecedor);

            //// Cria uma venda com dois itens
            //Venda venda = new Venda("Cartão de crédito", "123.456.789-00");
            //venda.AdicionarProduto(produto, 2);

            //Produto outroProduto = new Produto(2, "Lápis", 1.0, 100);
            //venda.AdicionarProduto(outroProduto, 1);

            //// Exibe os dados da venda e o valor total
            //Console.WriteLine("Venda realizada em {0} para o CPF {1}:", venda.FormaPagamento, venda.CpfCliente);
            //foreach (var item in venda.ProdutosVendidos)
            //{
            //    Console.WriteLine("- {0} x {1}: R$ {2}", item.Quantidade, item.Produto.Titulo, item.Produto.ValorUnitario * item.Quantidade);
            //}
            //Console.WriteLine("Total da venda: R$ {0}", venda.CalcularValorTotal());

            //// Remove um produto da venda e exibe o valor total atualizado
            //venda.RemoverProduto(produto);
            //Console.WriteLine("Total da venda atualizado: R$ {0}", venda.CalcularValorTotal());

            //Console.ReadLine();

            Idiomas idioma = new Idiomas(args[0]);
            Console.WriteLine(idioma.GetMensagem("Welcome"));
            Console.ReadKey();

            GerenciadorGenerico manager = new GerenciadorGenerico();

            int choice = 0;
            while (choice != 5)
            {
                Console.WriteLine(idioma.GetMensagem("Escolha uma opção:"));
                Console.WriteLine("1 - Adicionar objeto");
                Console.WriteLine("2 - Remover objeto");
                Console.WriteLine("3 - Listar objetos");
                Console.WriteLine("4 - Gerar PDF");
                Console.WriteLine("5 - Sair");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Digite o ID: ");
                            int id = int.Parse(Console.ReadLine());
                            Console.Write("Digite o nome: ");
                            string name = Console.ReadLine();
                            manager.AddGenericClass(id, name);
                            Console.WriteLine("Objeto adicionado com sucesso!");
                            break;
                        case 2:
                            Console.Write("Digite o ID do objeto a ser removido: ");
                            int idToRemove = int.Parse(Console.ReadLine());
                            if (manager.RemoveGenericClass(idToRemove))
                            {
                                Console.WriteLine("Objeto removido com sucesso!");
                            }
                            else
                            {
                                Console.WriteLine("Objeto não encontrado.");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Lista de objetos:");
                            foreach (GenericClass obj in manager.AllInstances())
                            {
                                Console.WriteLine($"ID: {obj.id}, Nome: {obj.name}");
                            }
                            break;
                        case 4:
                            PdfGenerator pdf = new PdfGenerator();
                            Console.Write("Digite o nome do arquivo PDF a ser gerado: ");
                            string filename = Console.ReadLine();
                            pdf.GeneratePdf(manager.AllInstances(), filename);
                            Console.WriteLine($"PDF gerado com sucesso: {filename}");
                            break;
                        case 5:
                            Console.WriteLine("Saindo...");
                            break;
                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida.");
                }


                Console.WriteLine();
            }
        }
    }
}