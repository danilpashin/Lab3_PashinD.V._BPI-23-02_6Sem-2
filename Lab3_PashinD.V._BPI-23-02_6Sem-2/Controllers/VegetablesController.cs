using System;
using System.Collections.Generic;
using System.Linq;
using Lab3_PashinD.V._BPI_23_02_6Sem_2.Models;
using System.Web;
using System.Web.Mvc;

namespace Lab3_PashinD.V._BPI_23_02_6Sem_2.Controllers
{
    public class VegetablesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FirstViewMethod()
        {
            // Создаем список овощей
            List<Vegetable> veggies = new List<Vegetable>
             {
                 new Vegetable { Id = 1, Name = "Картофель" },
                 new Vegetable { Id = 2, Name = "Морковь" },
                 new Vegetable { Id = 3, Name = "Лук" },
                 new Vegetable { Id = 4, Name = "Капуста" },
                 new Vegetable { Id = 5, Name = "Свекла" }
             };
            return PartialView("_FirstViewMethod", veggies);
        }
        public ActionResult SecondViewMethod()
        {
            // Создаем список овощей
            List<Vegetable> veggies = new List<Vegetable>
             {
                 new Vegetable { Id = 1, Name = "Кабачок" },
                 new Vegetable { Id = 2, Name = "Огурец" },
                 new Vegetable { Id = 3, Name = "Картофель" },
                 new Vegetable { Id = 4, Name = "Капуста" },
                 new Vegetable { Id = 5, Name = "Брокколи" },
                 new Vegetable { Id = 6, Name = "Томат" },
                 new Vegetable { Id = 7, Name = "Баклажан" }
             };
            var sorted = veggies.OrderBy(v => v.Name).ToList();

            return PartialView("_SecondViewMethod", sorted);
        }
    }
}