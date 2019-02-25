using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test2.Models;

namespace test2.Controllers
{
    public class HomeController : Controller
    {

        //Создание контекста данных
        PriceContext db = new PriceContext();


        public ActionResult Index()
        {
            //получение из бд все объекты Tarif
            IEnumerable<Tarif> tarifs = db.Tarif;
            //получение из бд все объекты Tarif_atribute
            IEnumerable<Tarif_atribute> Tarif_atributes = db.Tarif_atribute;
            //получение из бд все объекты Price_tarif
            IEnumerable<Price_tarif> Price_tarifs = db.Price_tarif;
            //получение из бд все объекты Tarif
            IEnumerable<Price_trend> Price_trend = db.Price_trend;



            return View();
        }

        
    }
}