using ContasRosen.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContasRosen.Controllers
{
    public class DepartamentoController : Controller
    {
        private static IList<Departamento> departamentos = new List<Departamento>() 
        {
            new Departamento()
            {
                DepartamentoID = 1,
                Nome = "Manulândia"
        },
        new Departamento()
        {
            DepartamentoID = 2,
            Nome = "Bárbalândia"
        }
        };
        public IActionResult Index()
        {
            return View(departamentos); // passando a lista com os objetos
        }
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Departamento departamento) /*sobrecarga */
        {
            departamento.DepartamentoID = departamentos.Select(i => i.DepartamentoID).Max() + 1;
           departamentos.Add(departamento);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(long id)
        {
            return View(departamentos.Where(i => i.DepartamentoID == id).First());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Departamento departamento) /*sobrecarga */
        {
            departamentos.Remove(departamentos.Where(i => i.DepartamentoID == departamento.DepartamentoID).First());
            departamentos.Add(departamento);
            return RedirectToAction("Index");
        }
        public ActionResult Details(long id)
        {
            return View(departamentos.Where(i => i.DepartamentoID == id).First());
        }

        public ActionResult Delete(long id) /*GET */
        {
            return View(departamentos.Where(i => i.DepartamentoID == id).First());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Departamento departamento) /*POST */
        {
            departamentos.Remove(departamentos.Where(i => i.DepartamentoID == departamento.DepartamentoID).First());
            return RedirectToAction("Index");
        }
    }
}
