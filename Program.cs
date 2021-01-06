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
            
            //Cadastra um produto
            produtoController.Cadastrar();

            //Mostrar os produtos
            produtoController.MostrarProdutos();
            
            //Busca um produto
            Console.WriteLine("Digite o código do produto que deseja buscar:");
            produtoController.Buscar(int.Parse(Console.ReadLine()));

        }

        
    }
}
