using AtividadeEstrutura.Web.Models;
using AtividadeEstruturas.Data;
using Microsoft.AspNetCore.Mvc;

namespace AtividadeEstrutura.Web.Controllers
{
    public class PessoaController : Controller
    {
        static PessoaRepository repository = new PessoaRepository();

        public IActionResult Index()
        {
            return View();
        }

        //Create - Crud
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Pessoa model)
        {
            repository.Cadastrar(model);
            ModelState.Clear();
            return View();
        }
        //Read - cRud
        public IActionResult List()
        {
            List<Pessoa> pessoas = repository.Listar();            
            return View(pessoas);
        }
        //Update - crUd
        public IActionResult Edit(int id)
        {
            Pessoa pessoa = repository.ListarPorId(id);
            return View(pessoa);
        }
        [HttpPost]
        public IActionResult Edit(Pessoa model)
        {
            repository.Alterar(model);
            return RedirectToAction("List");
        }
        //Delete - cruD
        public IActionResult Delete(int id)
        {
            repository.Deletar(id);
            return RedirectToAction("List");
        }
    }
}
