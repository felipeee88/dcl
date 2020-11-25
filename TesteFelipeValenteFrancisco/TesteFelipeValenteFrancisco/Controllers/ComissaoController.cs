using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using TesteFelipeValenteFrancisco.Enum;
using TesteFelipeValenteFrancisco.Models;

namespace TesteFelipeValenteFrancisco.Controllers
{
    public class ComissaoController : Controller
    {
        [HttpGet]
        public IActionResult Calcular()
        {
            ViewData["Message"] = string.Empty;
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(ComissaoViewModel viewModel)
        {
            viewModel.CalculoSalario(eComissao.CincoPorcento);
            
            ViewData["Message"] = "Salário Total: " + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", viewModel.SalarioFinal);
            return View(viewModel);
        }
    }
}