using System.Linq;
using Microsoft.AspNetCore.Mvc;
using GlobalSolution02.Models;
using GlobalSolution02.Data;

public class PesquisaController : Controller
{
    private readonly GlobalSolution02Context _context;

    public PesquisaController(GlobalSolution02Context context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Pesquisar(string nome)
    {
        var pessoa = _context.Calculadora.FirstOrDefault(c => c.Nome == nome);

        if (pessoa == null)
        {
            ViewBag.Mensagem = "Pessoa não encontrada.";
            return View("Index");
        }

        return View("Detalhes", pessoa);
    }
}
