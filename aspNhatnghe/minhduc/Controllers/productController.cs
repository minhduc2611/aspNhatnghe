﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using minhduc.Models;
namespace minhduc.Controllers
{
    public class productController : Controller
    {
        // moi lan chay cai listy nafy se luu lai ==> gan static vao !
        static List<Product> ProductsList = new List<Product>();

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult showAll2()
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
        public IActionResult create() {

            return View();
        }
        [HttpPost]
        public IActionResult create(Product product)
        {
            //gia su du lieu hop 
            //them vao list 

            ProductsList.Add(product);
            return View("showAll2", ProductsList);
        }

        public IActionResult Edit(int id)
        {
            //linq
            Product sp = ProductsList.SingleOrDefault( product => product.ID == id  );
            if (sp != null) {
                return View(sp);
            }
            return RedirectToAction("showAll2");
        }
    }
}