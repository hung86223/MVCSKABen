using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSKA_Ben.Models;

namespace MVCSKA_Ben.Controllers
{
    public class MoneyController : Controller
    {
        // GET: Money

        public ActionResult MoneyTemplate()
        {

            Random random = new Random();

            var moneylist = new List<MoneyView>();
            for (int i = 0; i < 50; i++)
            {
               
                var pass = new MoneyView();
                var money = random.Next(0, 10000);
                pass.category = "支出";
                pass.money = money;
                DateTime start = new DateTime(2019, 1, 1);
                int range = (DateTime.Today - start).Days;
                string end = start.AddDays(random.Next(range)).ToShortDateString().ToString();
                pass.day = end;
                pass.num = i + 1;
                moneylist.Add(pass);
            }

            return View(moneylist);
        }
    }
}