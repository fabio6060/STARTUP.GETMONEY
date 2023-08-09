using GETMONEY.Models;
using Microsoft.AspNetCore.Mvc;

namespace GETMONEY.Controllers
{
    public class ContaBancariaController : Controller
    {
        public IActionResult Index()
        {
            List<ContaBancaria> contasBancaria = Repositorio.ContasBancarias;
            return View(contasBancaria);
        }

        [HttpGet]
        public IActionResult NovaContaBancaria()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RemoverContasBancarias()
        {
            return View();
        }



        [HttpPost]
        public IActionResult NovaContaBancaria(ContaBancaria novaContaBancaria)
        {
                Repositorio.AdicionarContaBancaria(novaContaBancaria);
                return View("ContaBancariaConfirmada", novaContaBancaria);
        }

        [HttpPost]
        public IActionResult ApagarContasBancarias()
        {
            Repositorio.RemoverContasBancarias();
            return View("SemContas");

        }
    }
}
