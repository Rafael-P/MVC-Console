using System.Collections.Generic;
using System.IO;

namespace MVC_Console.Models
{
    public class Produto
    {
        
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        private const string PATH = "Database/Produto.csv";

        
        public Produto()
        {

            string pasta = PATH .Split("/")[0];

            //verificamos se a pasta n existe e criamos esta condição
            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            //verificamos se o arquivo Produto.csv existe, caso não exista, vms cria-la
            if(!File.Exists(PATH))
            {
                File.Create(PATH);
            }

        }

        public List<Produto> Ler()
        {
            
            List<Produto> produtos = new List<Produto>();

            //pegar as informações do csv
            string[] linhas = File.ReadAllLines(PATH);
            
            //separar atributos pelo ;
            foreach(string item in linhas)
            {
            
                string[] atributos = item.Split(";");

                //criamos um produto vazio para poder colocar na lista final dos produtos
                Produto prod = new Produto();
                prod.Codigo  = int.Parse(atributos[0]);
                prod.Nome    = atributos[1];
                prod.Preco   = float.Parse(atributos[2]);

                produtos.Add(prod);

            }
            return produtos;
        }
   

    }
}