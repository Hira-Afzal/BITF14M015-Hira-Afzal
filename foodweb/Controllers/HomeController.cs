using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using foodweb.Models;
using System.Data.SqlClient;
namespace foodweb.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        
        Cart ct = new Cart();
      
      
        Entities1 et = new Entities1();
        public ActionResult Index2()
        {
            return View(et.Foods.ToList());
        }
        public ActionResult Index()
        {
            
            Cart ct = et.Carts.Find(1);
            ct.Item1 = 25;
            ct.Item2 = 25;
            ct.Item3 = 25;
            ct.Item4 = 25;
            ct.Item5 = 25;
            ct.Item6 = 25;
            et.SaveChanges();
            return View();
        }

        public ActionResult Menu1()
        {
            return View(et.Foods.ToList());
        }

        public ActionResult Menu2()
        {
            return View(et.Foods.ToList());
        }

        public ActionResult Menu3()
        {
            return View(et.Foods.ToList());
        }

        public ActionResult Menu4()
        {
            return View(et.Foods.ToList());
        }

        public ActionResult Checkout()
        {
            Cart ct1 = et.Carts.Find(1);
            return View(ct1);
        }

        public ActionResult Food()
        {
            return View(et.Foods.ToList());
        }

        public ActionResult Add(int id)
        {

            Entities1 et = new Entities1();
            Cart ct = et.Carts.Find(1);
            
            
            if (ct.Item1 == 25)
            {
                ct.Item1 = id;
                
            }
            else if (ct.Item2 == 25)
            {
                ct.Item2 = id;
                
            }
            else if (ct.Item3 == 25)
            {
                ct.Item3 = id;
                
            }
            else if (ct.Item4 == 25)
            {
                ct.Item4 = id;
                
            }
            else if (ct.Item5 == 25)
            {
                ct.Item5 = id;
                
            }
            else if (ct.Item6 == 25)
            {
                ct.Item6 = id;
                
            }
            else
            {
                return RedirectToAction("Checkout");
            }

            et.SaveChanges();

            // Food fd = db.Foods.Find(id);  
            return View();
        }

        public ActionResult AdminPanel()
        {
            return View();
        }

        public ActionResult ManageUsers()
        {
            return View(et.AspNetUsers.ToList());
        }

        public ActionResult Delete(string id)
        {
            AspNetUser us = new AspNetUser();
            us=et.AspNetUsers.Find(id);
            et.AspNetUsers.Remove(us);
            et.SaveChanges();
            return RedirectToAction("ManageUsers");
        }

        public ActionResult ManageMenu()
        {
            return View(et.Foods.ToList());
        }

        
        public ActionResult Update(int id)
        {
            Food fd= et.Foods.Find(id);
            return View(fd);
        }
        
        [HttpPost]
        public ActionResult UpdateConfirm(int id)
        {
            Food fd = new Food();
            fd=et.Foods.Find(id);
            fd.DishName = Request["tfn"];
            fd.Price = Convert.ToInt32(Request["tfp"]);
            et.SaveChanges();
            return RedirectToAction("ManageMenu");
        }

        public ActionResult RemoveItem(int id)
        {
            Cart ct = et.Carts.Find(1);
            if(id==1)
            {
                ct.Item1 = 25;
            }
            if (id == 2)
            {
                ct.Item2 = 25;
            }
            if (id == 3)
            {
                ct.Item3 = 25;
            }
            if (id == 4)
            {
                ct.Item4 = 25;
            }
            if (id == 5)
            {
                ct.Item5 = 25;
            }
            if (id == 6)
            {
                ct.Item6 = 25;
            }
            et.SaveChanges();
            return RedirectToAction("Checkout");
        }

   
    }
}
