using Microsoft.AspNetCore.Mvc;

namespace ContasRosen.Controllers
{
    public class TesteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
