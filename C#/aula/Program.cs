using System;
using System.Collections.Generic;

namespace aula
{
    public class Program
    {
        public static void Main()
        {
            Console.Clear();

            List<Produto> produto = new List<Produto>
            {
                new Produto
                {
                    NomeProduto = "Teclado",
                    PrecoProduto = 120.50m,
                    Estoque = 36,
                    Vendidos = 12
                },
                new Produto
                {
                    NomeProduto = "Mouse",
                    PrecoProduto = 50.25m,
                    Estoque = 19,
                    Vendidos = 6
                }
            };

            Console.WriteLine("----------------Venda----------------");

            Console.WriteLine("1 - Teclado \n2 - Mouse \nInforme qual Produto foi vendidos: ");
            int ProdutoVendido = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Quantidade de itens vendidos: ");
            int QuantidadeItensVendidos = Convert.ToInt32(Console.ReadLine());
            
            Console.Clear();
            
            if (ProdutoVendido == 1)
            {
                decimal ValorTotal = QuantidadeItensVendidos * produto[0].PrecoProduto;
                Console.WriteLine($"{produto[0].NomeProduto} \n{QuantidadeItensVendidos} X R${produto[0].PrecoProduto} = R${ValorTotal}");
                produto[0].Estoque = produto[0].Estoque - QuantidadeItensVendidos;
                produto[0].Vendidos = produto[0].Vendidos + QuantidadeItensVendidos;
                Console.WriteLine($"\nProduto: {produto[0].NomeProduto} \nEstoque: {produto[0].Estoque} \nVendidos: {produto[0].Vendidos}");
            }
            else if (ProdutoVendido == 2)
            {   
                decimal ValorTotal = QuantidadeItensVendidos * produto[1].PrecoProduto;
                Console.WriteLine($"{produto[1].NomeProduto} \n{QuantidadeItensVendidos} X R${produto[1].PrecoProduto} = R${ValorTotal}");
                produto[1].Estoque = produto[1].Estoque - QuantidadeItensVendidos;
                produto[1].Vendidos = produto[1].Vendidos + QuantidadeItensVendidos;
                Console.WriteLine($"\nProduto: {produto[1].NomeProduto} \nEstoque: {produto[1].Estoque} \nVendidos: {produto[1].Vendidos}");
            }
            
        }
    }
    public class Produto
    {
        public string NomeProduto { get; set; }
        public decimal PrecoProduto { get; set; }
        public int Estoque { get; set; }
        public int Vendidos { get; set; }
    }
}