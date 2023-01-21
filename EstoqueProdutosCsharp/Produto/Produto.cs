using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueProdutosCsharp.Produto
{
    public class Produto
    {
        public string nome { get; private set; }
        public double preco { get; private set; }
        public int quantidadeEstoque { get; private set; }
        public double valorTotal { get; private set; }


        public Produto(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
        }

        public void AumentaEstoqueEValorTotal(int quantidade)
        {
            this.quantidadeEstoque += quantidade;
            this.valorTotal += this.preco * quantidade;
        }

        public void RemoveProduto(int quantidade)
        {
            this.quantidadeEstoque -= quantidade;
            this.valorTotal -= this.preco * quantidade;
        }

        public override string ToString()
        {
            return $"Dados do produto: {nome}, R$ {preco}, {quantidadeEstoque} unidades, Total: R$ {valorTotal.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
