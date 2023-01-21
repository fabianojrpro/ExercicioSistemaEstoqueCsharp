// See https://aka.ms/new-console-template for more information
using EstoqueProdutosCsharp.Produto;
using System.Globalization;

Console.WriteLine("Entre os dados do produto:");
Console.Write("Nome:");
string nomeProduto = Console.ReadLine();
Console.Write("Preço:");
double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantidade no estoque:");
int quantidadeNoEstoque = int.Parse(Console.ReadLine());

Produto produtos = new Produto(nomeProduto, precoProduto);
produtos.AumentaEstoqueEValorTotal(quantidadeNoEstoque);
Console.WriteLine();
Console.WriteLine(produtos);
Console.WriteLine();

Console.Write("Digite o número de produtos a ser adicionado ao estoque:");
int quantidadeParaAcrescentar = int.Parse(Console.ReadLine());
produtos.AumentaEstoqueEValorTotal(quantidadeParaAcrescentar);
Console.WriteLine(produtos);
Console.WriteLine();

Console.Write("Digite o número de produtos a ser removido do estoque:");
int quantidadeParaRemover = int.Parse(Console.ReadLine());
produtos.RemoveProduto(quantidadeParaRemover);
Console.WriteLine(produtos);
