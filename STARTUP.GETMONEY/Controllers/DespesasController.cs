using Microsoft.AspNetCore.Mvc;
using GETMONEY.Models;

namespace GETMONEY.Controllers
{
    public class DespesasController : Controller
    {
        public IActionResult Index()
        {
            List<Despesa> despesas = Repositorio.Despesas;
            return View(despesas);
        }

        [HttpGet]
        public IActionResult NovaDespesa()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NovaDespesa(Despesa novaDespesa)
        {

            Repositorio.AdicionarDespesa(novaDespesa);
            return View("DespesaConfirmada", novaDespesa);
            

        }
    }
}

