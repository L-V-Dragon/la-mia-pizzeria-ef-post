using Microsoft.AspNetCore.Mvc;
using la_mia_pizzeria_static.Models;
using la_mia_pizzeria_static.Utils;
using Microsoft.Extensions.Hosting;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
			List<Pizza> listaDellePizze = PizzaData.GetPizze();
			return View("Index", listaDellePizze);
        }

		public IActionResult Details(int id)
		{
			List<Pizza> listaDellePizze = PizzaData.GetPizze();

			foreach (Pizza pizza in listaDellePizze)
			{
				if (pizza.ID == id)
				{
					return View(pizza);
				}
			}

			return NotFound("La pizza con l'id cercato non esiste!");
		}
	}
}
