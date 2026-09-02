using System;
using System.Collections.Generic;

namespace cliente
{
    public class Program
    {
        public static void Main()
        {
            async Task<string>Cliente()
            {
                await Task.Delay(1000);
                return "Cliente";
            }
            async Task<string>Pedido()
            {
                await Task.Delay(1000);
                return "Pedidos";
            }
            async Task<string>Endereco()
            {
                await Task.Delay(1000);
                return "Endereço";
            }
            var tarefas = new[]
            {
                Cliente(),
                Pedidos(),
                Endereco()
            };
            var resultados = await Task.WhenAll(tarefas);

            foreach(var resultado in resultados)
            {
                Console.WriteLine(resultado);
            }
        }
    }
}