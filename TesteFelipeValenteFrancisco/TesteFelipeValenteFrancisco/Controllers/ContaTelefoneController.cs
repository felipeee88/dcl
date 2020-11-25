using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using TesteFelipeValenteFrancisco.Models;

namespace TesteFelipeValenteFrancisco.Controllers
{
    public class ContaTelefoneController : Controller
    {
        [HttpGet]
        public IActionResult Calcular()
        {
            ViewData["Message"] = string.Empty;
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(ContaTelefoneViewModel viewModel)
        {
            viewModel.CalcularValorChamada();
            ViewData["Message"] = "Valor da Conta " + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", viewModel.ValorChamada);
            return View(viewModel);
        }
    }
}