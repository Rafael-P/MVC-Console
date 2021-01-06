using System.Collections.Generic;
using MVC_Console.Models;
using MVC_Console.Views;

namespace MVC_Console.Controllers
{
    public class ProdutoController
    {
        
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();
        
        public void MostrarProdutos()
        {

            List<Produto> todos = produto.Ler();
            produtoView.ListarTodos(todos);

        }

        public void Buscar(int cod)
        {

            List<Produto> lista = produto.Ler().FindAll(x => x.Codigo == cod);
            produtoView.ListarTodos(lista);

        }

        public void Cadastrar()
        {
            produto.Inserir( produtoView.CadastrarProduto() );
        }


    }
}