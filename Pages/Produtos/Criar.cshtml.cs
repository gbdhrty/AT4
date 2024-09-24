using AT4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AT4.Pages.Produtos
{
    public class CriarModel : PageModel
    {
        [BindProperty]
        public Produto produto { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                using(var writer = new StreamWriter("produtos.txt", true))
                {
                    writer.WriteLine(produto.Nome + ";" + produto.Preco);
                    return RedirectToPage("/Produtos/Index");
                }             
            }
        }
    }
}
