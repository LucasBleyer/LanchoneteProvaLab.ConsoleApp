using LanchoneteProvaLab.ConsoleApp;
using LanchoneteProvaLab.ConsoleApp.Model;
using System;
using System.Threading;

namespace LanchoneteProvaLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linguagemSelecionada = "en";

            if (args.Length > 0)
            {
                linguagemSelecionada = args[0];
            }

            Idioma linguagem = new Idioma(linguagemSelecionada);

            //var repositorioProduto = new RepositorioProduto();
            //var repositorioFornecedor = new RepositorioFornecedor();
            //var repositorioVenda = new RepositorioVenda();

            while (true)
            {
                Console.WriteLine(linguagem.GetMensagem("SelecioneOpcaoMenu"));
                Console.WriteLine("1 - " + linguagem.GetMensagem("Produtos"));
                Console.WriteLine("2 - " + linguagem.GetMensagem("Fornecedores"));
                Console.WriteLine("3 -  " + linguagem.GetMensagem("Vendas"));
                Console.WriteLine("0 - " + linguagem.GetMensagem("Sair"));

                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        MenuProdutos(linguagem);
                        break;
                    case "2":
                        MenuFornecedores(linguagem);
                        break;
                    case "3":
                        MenuVendas(linguagem);
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine(linguagem.GetMensagem("OpcaoInvalida"));
                        break;
                }

                Console.WriteLine();
            }

        }

        static void MenuProdutos(Idioma linguagem)
        {
            while (true)
            {
                Console.WriteLine(linguagem.GetMensagem("SelecioneOpcaoMenu"));
                Console.WriteLine("1 - " + linguagem.GetMensagem("ListarProdutos"));
                Console.WriteLine("2 - " + linguagem.GetMensagem("CadastrarProduto"));
                Console.WriteLine("3 - " + linguagem.GetMensagem("EditarProduto"));
                Console.WriteLine("4 - " + linguagem.GetMensagem("ExcluirProduto"));
                Console.WriteLine("0 - " + linguagem.GetMensagem("Voltar"));

                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        //ListarProdutos(repositorioProduto);
                        break;
                    case "2":
                        // CadastrarProduto(repositorioProduto, repositorioFornecedor);
                        break;
                    case "3":
                        // EditarProduto(repositorioProduto);
                        break;
                    case "4":
                        // ExcluirProduto(repositorioProduto);
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine(linguagem.GetMensagem("OpcaoInvalida"));
                        break;
                }

                Console.WriteLine();
            }
        }

        static void MenuFornecedores(Idioma linguagem)
        {
            while (true)
            {
                Console.WriteLine(linguagem.GetMensagem("SelecioneOpcaoMenu"));
                Console.WriteLine("1 - " + linguagem.GetMensagem("ListarFornecedores"));
                Console.WriteLine("2 - " + linguagem.GetMensagem("CadastrarFornecedor"));
                Console.WriteLine("3 - " + linguagem.GetMensagem("EditarFornecedor"));
                Console.WriteLine("4 - " + linguagem.GetMensagem("ExcluirFornecedor"));
                Console.WriteLine("0 - " + linguagem.GetMensagem("Voltar"));

                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        // ListarFornecedores(repositorioFornecedor);
                        break;
                    case "2":
                        //  CadastrarFornecedor(repositorioFornecedor);
                        break;
                    case "3":
                        // EditarFornecedor(repositorioFornecedor);
                        break;
                    case "4":
                        //ExcluirFornecedor(repositorioFornecedor);
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine(linguagem.GetMensagem("OpcaoInvalida"));
                        break;
                }

                Console.WriteLine();
            }
        }
        static void MenuVendas(Idioma linguagem)
        {
            while (true)
            {
                Console.WriteLine("Selecione a opção desejada:");
                Console.WriteLine("1 - " + linguagem.GetMensagem("ListarVendas"));
                Console.WriteLine("2 - " + linguagem.GetMensagem("CadastrarVenda"));
                Console.WriteLine("3 - " + linguagem.GetMensagem("EditarVenda"));
                Console.WriteLine("4 - " + linguagem.GetMensagem("ExcluirVenda"));
                Console.WriteLine("0 - " + linguagem.GetMensagem("Voltar"));

                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        // ListarVendas(repositorioVenda);
                        break;
                    case "2":
                        // CadastrarVenda(repositorioVenda, repositorioVenda);
                        break;
                    case "3":
                        // EditarVenda(repositorioVenda);
                        break;
                    case "4":
                        //ExcluirVenda(repositorioVenda);
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine(linguagem.GetMensagem("OpcaoInvalida"));
                        break;
                }

                Console.WriteLine();
            }


            //Idiomas idioma = new Idiomas(args[0]);
            //Console.WriteLine(idioma.GetMensagem("Welcome"));
            //Console.ReadKey();

            //GerenciadorGenerico manager = new GerenciadorGenerico();

            //int opcaoMenu = 0;
            //while (opcaoMenu != 5)
            //{
            //    //Console.WriteLine(idioma.GetMensagem("Escolha uma opção:"));
            //    Console.WriteLine(("Escolha uma opção:"));
            //    Console.WriteLine("1 - Gerenciar Produtos");
            //    Console.WriteLine("3 - Gerenciar Vendas");
            //    Console.WriteLine("4 - Gerar PDF");
            //    Console.WriteLine("5 - Sair");

            //    if (int.TryParse(Console.ReadLine(), out opcaoMenu))
            //    {
            //        switch (opcaoMenu)
            //        {
            //            case 1:
            //                Produto produto;

            //                Console.WriteLine(("\nGerenciamento de Produtos"));
            //                Console.Write("Digite o ID: ");
            //                int id = Convert.ToInt32(Console.ReadLine());
            //                Console.Write("Digite o Título: ");
            //                string titulo = Console.ReadLine();
            //                Console.Write("Digite o Valor Unitário: ");
            //                double valorUnitario = Convert.ToDouble(Console.ReadLine());
            //                Console.Write("Digite a Quantidade em estoque: ");
            //                int quantEstoque = Convert.ToInt32(Console.ReadLine());

            //                produto = new Produto(id, titulo, valorUnitario, quantEstoque);

            //                Console.WriteLine("\nGerenciamento Fornecedor do Produto {0}", titulo);
            //                Console.WriteLine("1 - Adicionar Fornecedor");
            //                Console.WriteLine("2 - Remover Fornecedor");
            //                Fornecedor fornecedor;
            //                char opcaoFornecedor = Convert.ToChar(Console.ReadLine());
            //                if (opcaoFornecedor == '1')
            //                {
            //                    Console.WriteLine("Adicionar Fornecedor");
            //                    Console.Write("Digite o Nome do Fornecedor: ");
            //                    string nome = Console.ReadLine();
            //                    Console.Write("Digite o Endereço do Fornecedor: ");
            //                    string endereco = Console.ReadLine();
            //                    fornecedor = new Fornecedor(nome, endereco);
            //                    produto.AdicionarFornecedor(fornecedor);
            //                    return;
            //                }
            //                else
            //                {
            //                    if (opcaoFornecedor == '2')
            //                    {
            //                        Console.Write("Remover Fornecedor");
            //                        foreach (var item in produto.Fornecedores)
            //                        {
            //                            produto.RemoverFornecedor(item);
            //                        }
            //                        return;
            //                    }
            //                }   

            //                Console.WriteLine("Produto adicionado com sucesso!");
            //                break;
            //            case 2:
            //    Console.Write("Digite o ID do objeto a ser removido: ");
            //    int idToRemove = int.Parse(Console.ReadLine());
            //    if (manager.RemoveGenericClass(idToRemove))
            //    {
            //        Console.WriteLine("Objeto removido com sucesso!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Objeto não encontrado.");
            //    }
            //    break;
            //case 3:
            //    Console.WriteLine("Lista de objetos:");
            //    foreach (GenericClass obj in manager.AllInstances())
            //    {
            //        Console.WriteLine($"ID: {obj.id}, Nome: {obj.name}");
            //    }
            //    break;
            //case 4:
            //    PdfGenerator pdf = new PdfGenerator();
            //    Console.Write("Digite o nome do arquivo PDF a ser gerado: ");
            //    string filename = Console.ReadLine();
            //    pdf.GeneratePdf(manager.AllInstances(), filename);
            //    Console.WriteLine($"PDF gerado com sucesso: {filename}");
            //    break;
            //        case 5:
            //            Console.WriteLine("Saindo...");
            //            break;
            //        default:
            //            Console.WriteLine("Opção inválida.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Opção inválida.");
            //}


            //Console.WriteLine();
        
    
        }
    }
}