using MVC5.Models;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web.Mvc;

namespace MVC5.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Usuario()
        {
            var usuario = new Usuario();
            return View(usuario);
        }

        [HttpPost]
        public ActionResult Usuario(Usuario user)
        {
            if (string.IsNullOrEmpty(user.Nome))
            {
                ModelState.AddModelError("Nome", "é obrigatório preencher o campo!");
            }
            if (user.Senha != user.ConfirmaSenha)
            {
                ModelState.AddModelError("", "As senhas são diferentes. Tente novamente!");
            }

            if (ModelState.IsValid)
            {
                return View("Resultado", user);
            }
            return View(user);
        }

        public ActionResult Resultado(Usuario user)
        {
            return View(user);
        }

        public ActionResult LoginUnico(string login)
        {
            var bancoDadosUsuarios = new Collection<string>
            {
                "Lucas",
                "Jéssica",
                "Juan"
            };

            return Json(bancoDadosUsuarios.All(x => x.ToLower() != login.ToLower()), JsonRequestBehavior.AllowGet);
        }
    }
}