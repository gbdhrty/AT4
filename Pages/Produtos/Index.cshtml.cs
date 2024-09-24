using AT4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AT4.Pages.Produtos
{
    public class IndexModel : PageModel
    {
        public List<Produto> Produtos { get; set; }

        public void OnGet()
        {
            Produtos = new List<Produto>();

            if (System.IO.File.Exists("produtos.txt"))
            {
                var linhas = System.IO.File.ReadAllLines("produtos.txt");

                foreach (var linha in linhas)
                {
                    var dados = linha.Split(";");

                    var produto = new Produto()
                    {
                        Nome = dados[0],
                        Preco = double.Parse(dados[1])
                    };
                    Produtos.Add(produto);
                }
            }

        }
    }
}
