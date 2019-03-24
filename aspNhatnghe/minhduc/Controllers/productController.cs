using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using minhduc.Models;
namespace minhduc.Controllers
{
    public class ProductController : Controller
    {
        // moi lan chay cai listy nafy se luu lai ==> gan static vao !
        static List<Product> ProductsList = new List<Product>();

        public IActionResult Index()
        {
            return View("showAll2", ProductsList);
        }
        public IActionResult ShowAll2()
        {
            ViewData["Heading"] = " All Products ";

            //var ProductsList = new List<Product>();
            ProductsList.Add(new Product
            {
                ID = 1,
                Name = "Husky A",
                Price = 342
            });
            ProductsList.Add(new Product
            {
                ID = 2,
                Name = "Husky B",
                Price = 241
            });
            ProductsList.Add(new Product
            {
                ID = 3,
                Name = "Husky C",
                Price = 332
            });
            return View(ProductsList);
        }

        public IActionResult Create() {

           return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            //gia su du lieu hop 
            //them vao list 

            ProductsList.Add(product);
            return View("showAll2", ProductsList);
        }

        // edit 

         public IActionResult Edit(int id)
        {
            //LINQ
            Product sp = ProductsList.SingleOrDefault(
                p => p.ID == id);
            if(sp != null)//nếu có
            {
                return View("edit",sp);
            }
            //chuyển về Action Index
            return RedirectToAction("Index");
        }
        
        [HttpPost]
        public IActionResult Edit(int id, Product product)
        {
            //linq
            Product sp = ProductsList.SingleOrDefault( prod => prod.ID == id  );
            if (sp != null) {
                sp.Name = product.Name;
                sp.Price = product.Price;
                sp.Sale = product.Sale;
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            //linq
            Product sp = ProductsList.SingleOrDefault(product => product.ID == id);
            if (sp != null)
            {
                ProductsList.Remove(sp);
            }
            return RedirectToAction("Index");
        }
    }
}