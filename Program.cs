using System;
using MVC_Console.Controllers;
using MVC_Console.Models;

namespace MVC_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //instaciamos nosso controller
            ProdutoController produtoController = new ProdutoController();
            produtoController.MostrarProdutos();
            
            Console.WriteLine("Digite o código do produto que deseja buscar:");
            produtoController.Buscar(int.Parse(Console.ReadLine()));

        }
    }
}
