using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Aula
{
    public class Program
    {
        public class Produto
        {
            public string NomeProduto { get; set; } = "";
            public double PrecoProduto { get; set; } 
            public int EstoqueProduto { get; set; } 
            public int CodigoProduto { get; set; }
        }
        public class ProdutoResponse
        {
            public List <Produto> produtos { get; set; } = new();
        }

        public static void Main()
        {
            string json = File.ReadAllText("Produtos.json");
        
            ProdutoResponse? dados = 
                JsonSerializer.Deserialize<ProdutoResponse>(json);

            foreach(Produto produto in dados.produtos)
            {
                Console.WriteLine("Nome Produto: " + produto.NomeProduto);
                Console.WriteLine("Preço: R$" + produto.PrecoProduto);
                Console.WriteLine("Estoque: " + produto.EstoqueProduto);
                Console.WriteLine("Codigo: " + produto.CodigoProduto);
                Console.WriteLine("---------------------------------");
            }
        }
    }
}