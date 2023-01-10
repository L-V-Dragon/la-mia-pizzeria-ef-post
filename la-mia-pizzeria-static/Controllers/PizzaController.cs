using Microsoft.AspNetCore.Mvc;
using la_mia_pizzeria_static.Models;
using Microsoft.Extensions.Hosting;
using la_mia_pizzeria_static.Database;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
			using PizzaContext db = new PizzaContext();
			List<Pizza> listaDellePizze = db.Pizze.ToList();
			return View("Index", listaDellePizze);
        }

		public IActionResult Details(int id)
		{
			using (PizzaContext db = new PizzaContext())
			{
				
				Pizza postTrovato = db.Pizze
					.Where(SingolaPizzaNelDb => SingolaPizzaNelDb.ID == id)
					.FirstOrDefault();

				
				if (postTrovato != null)
				{
					return View(postTrovato);
				}

				return NotFound("Il post con l'id cercato non esiste!");

			}
		}
	}
}
