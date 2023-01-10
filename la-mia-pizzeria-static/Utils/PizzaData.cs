using la_mia_pizzeria_static.Models;
using Microsoft.Extensions.Hosting;

namespace la_mia_pizzeria_static.Utils
{
    public class PizzaData
    {
        private static List<Pizza> pizze;

        
        public static List<Pizza> GetPizze()
        {
            string[] PizzeNome = { "Margherita", "Diavola" , "Kebab", "Anelli di Cipolla Fritta" };

            string[] PizzeFoto = { "/img/pizza1.jpg", "/img/pizza2.jpg", "/img/pizza3.jpg", "/img/fritto1.jpg" };

            string[] PizzeDescrizione = { "Pizza con pomodoro e mozzarella.", "Pizza con pomodoro, mozzarella e salame piccante.", "Pizza con pomodoro, mozzarella, cipolla, Kebab, salsa bianca, salsa piccante, pomodori tagliati, mais, insalata e verza.", "Anelli di cipolla fritti nella pastella." };

            string[] PizzePrezzo = { "6,50 €", "7,00 €", "9,50 €", "5,50 €" };

            if (pizze != null)
            {
                return pizze;
            }

            pizze = new List<Pizza>();

            for (int i = 0; i < PizzeNome.Length; i++)
            {
                Pizza pizzaGenerata = new Pizza(i, PizzeNome[i], PizzeFoto[i], PizzeDescrizione[i] , PizzePrezzo[i]);
                pizze.Add(pizzaGenerata);
            }
            return pizze;

        }
    }
}
