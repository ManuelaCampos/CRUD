using ContasRosen.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContasRosen.Controllers
{
    public class InstituicaoController : Controller
    {
        private static IList<Instituicao> instituicoes = new List<Instituicao>() // é static pois sem ele seria criada uma nova e não guardaria as informações armazanadas na memoria anteriormente,
                                                                                // está sendo criada uma lista de instituições com ID, nome e endereço
                                                                                // o que vem entre <> é o tipo de dados e a lista é a instituicoes 
        {
            new Instituicao()// objetos anônimos sendo criados e instanciados e faz parte da lista de instituicoes
            {
                InstituicaoID = 1,
                Nome = "Hogwarts",
                Endereco = "Escócia"
        },
        new Instituicao()
        {
            InstituicaoID = 2,
            Nome = "Mansao X",
            Endereco = "Nova York"
        }
        };
        public IActionResult Index()
        {
            return View(instituicoes); // passando a lista com os objetos
        }
        public IActionResult Create()
        {
            return View(); 

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Instituicao instituicao)
        {
            instituicao.InstituicaoID = instituicoes.Select(i => i.InstituicaoID).Max() + 1;
            instituicoes.Add(instituicao);
            return RedirectToAction("Index");  
        }
    }
}

