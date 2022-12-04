using CadastroProdutosWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadastroProdutosWeb.Controllers
{
    public class ProdutoController : Controller
    {
        public static List<Produto> ListaProdutos { get; set; } = new List<Produto>();

        // GET, POST, PUT, DELETE
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet] // get - carregar tela/dados
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost] // cadastrar/salvar
        public IActionResult Create(Produto model)
        {
            ListaProdutos.Add(model);
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public IActionResult List()
        {
            return View(ListaProdutos);
        }
    }
}
