using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdminListEF.Models;

namespace AdminListEF.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult ItemAdmin()
        {
            Item ORM = new Item();
            ViewBag.Items = ORM.Items.ToList(); 
            return View();
        }
        public ActionResult ItemDetails(string name)
        {
            if (name == null || name == "")
                return View("Index");
            Item ORM = new Item();
            Item found = ORM.Items.Where(i => i.Name == name).ToList()[0];
            if (found != null)
            {
                ViewBag.Item = found;
                return View();
            }
            else
            {
                return View("Index");
            }

        }
        public ActionResult SaveItemChanges(Item NewItem)
        {
            Item ORM = new Item();
            Item oldItem = ORM.Items.Find(NewItem.ID);
            oldItem.Name = NewItem.Name;
            oldItem.Description = NewItem.Description;
            oldItem.Price = NewItem.Price;
            oldItem.Quantity = NewItem.Quantity;
            ORM.Entry(oldItem).State = System.Data.Entity.EntityState.Modified;
            ORM.SaveChanges();
            return RedirectToAction("ItemAdmin");


        }
    }
}