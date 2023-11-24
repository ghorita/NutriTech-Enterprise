using GlobalSolution02.Models;
using Microsoft.AspNetCore.Mvc;

namespace GlobalSolution02.Controllers;

public class IMCCalculadoraController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CalcularIMC(CalculadoraIMC model)
    {
        if (ModelState.IsValid)
        {
            // Cálculo do IMC: IMC = peso / (altura * altura)
            model.Resultado = model.Peso / (model.Altura * model.Altura);

            return View("Resultado", model);
        }

        return View("Index", model);
    }
}
