using System.Web.Mvc;
using MVC5.Models;

namespace MVC5.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var pessoa = new Pessoa
            {
                PessoaId = 1,
                Nome = "Pessoa Teste",
                Idade = 22
            };

            return View(pessoa);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contatos()
        {
            return View();
        }

        // [HttpPost]

        /*
        O método abaixo utiliza "post" do HTML para coletar dados e exibi-los em uma nova View.
        public ActionResult Lista(int PessoaId, string Nome, int Idade)
        {
            ViewData["PessoaId"] = PessoaId;
            ViewData["Nome"] = Nome;
            ViewData["Idade"] = Idade;
            return View();
        }
        */

        // Recebendo dados com View Tipada

        /* 
        [HttpPost]
        public ActionResult Lista(FormCollection form)
        {
            ViewData["PessoaId"] = form["PessoaId"]; 
            ViewData["Nome"] = form["Nome"];
            ViewData["Idade"] = form["Idade"]; 

            OU PODERÁ DEFINIR OS PROCEDIMENTOS ASSIM...

            ViewData["PessoaId"] = p.PessoaId;
            ViewData["Nome"] = p.Nome;
            ViewData["Idade"] = p.Idade;

            return View();
        }
        */

        // Recebendo dados com View Tipada e a Classe Pessoa

        [HttpPost]
        public ActionResult Lista(Pessoa p)
        {
            return View(p);
        }
    }
}