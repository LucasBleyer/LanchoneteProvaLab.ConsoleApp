# Lanchonete Prova Lab.ConsoleApp

# Introdução
Este projeto consiste em um sistema de gerenciamento de vendas, que permite o cadastro de produtos, fornecedores e vendas, além de gerar um relatório em PDF com as informações de vendas.

# Funcionalidades
## Cadastro de produtos
O sistema permite o cadastro de produtos com as seguintes informações:

ID
Título
Valor unitário
Quantidade em estoque
Lista de fornecedores (nome e endereço)
Também é possível adicionar e remover fornecedores de um produto já cadastrado.

Cadastro de fornecedores
O sistema permite o cadastro de fornecedores com as seguintes informações:

Nome
Endereço
Cadastro de vendas
O sistema permite o cadastro de vendas com as seguintes informações:

Lista de itens vendidos (produto e quantidade)
Forma de pagamento
CPF do cliente
Também é possível adicionar e remover itens de uma venda já cadastrada.

Geração de relatório em PDF
O sistema permite a geração de um relatório em PDF com as informações de vendas cadastradas. O relatório contém as seguintes informações:

Data e hora da geração do relatório
Lista de vendas (CPF do cliente, forma de pagamento e valor total da venda)
Tradução de textos
O sistema permite a tradução de textos para diversos idiomas, incluindo inglês, espanhol e francês. As traduções são feitas utilizando a API gratuita do Google Translate e são salvas em um arquivo de recursos para cada idioma. O idioma padrão do sistema é o português.

Tecnologias utilizadas
C# .NET 6.0
ASP.NET Core
Entity Framework Core
Razor Pages
iTextSharp (para a geração de PDF)
Google Translate API
Como rodar o projeto
Clone o repositório para o seu computador
Abra o projeto no Visual Studio ou no VS Code
Compile e rode o projeto
Acesse a aplicação no navegador através do endereço https://localhost:5001
Considerações finais
Este projeto é uma implementação simples de um sistema de gerenciamento de vendas e pode ser utilizado como base para projetos mais complexos. As funcionalidades de cadastro de produtos, fornecedores e vendas podem ser expandidas de acordo com as necessidades do projeto. A geração de PDF e a tradução de textos são exemplos de funcionalidades adicionais que podem ser implementadas em um sistema de gerenciamento de vendas.
