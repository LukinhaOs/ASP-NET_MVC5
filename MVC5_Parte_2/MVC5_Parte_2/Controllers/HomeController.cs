using MVC5_Parte_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5_Parte_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEnumerable<Noticia> todasAsNoticias;


        public HomeController()
        {
            todasAsNoticias = new Noticia().TodasAsMaterias().OrderByDescending(x => x.Data);
        }

        public ActionResult Index()
        {
            var lastNoticias = todasAsNoticias.Take(3);
            var categoriaNoticias = todasAsNoticias.Select(x => x.Categoria).Distinct().ToList();

            ViewBag.Categoria = categoriaNoticias;
            return View(lastNoticias);
        }

        public ActionResult TodasAsNoticias()
        {
            return View(todasAsNoticias);
        }

        public ActionResult MostraNoticia(int noticiaId, string titulo, string categoria)
        {
            return View(todasAsNoticias.FirstOrDefault(x => x.NoticiasID == noticiaId));
        }

        public ActionResult MostraCategoria(string categoria)
        {    
            var categoriaEspecifica = todasAsNoticias.Where(x => x.Categoria.ToLower() == categoria.ToLower()).ToList();
            ViewBag.Categoria = categoria;
            return View(categoriaEspecifica);
        }
    }
}