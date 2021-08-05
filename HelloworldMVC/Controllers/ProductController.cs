using HelloworldMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloworldMVC.Controllers
{
    public class ProductController : Controller
    {
        static List<Product> productList = new List<Product>()
        {
            new Product()
            {
                Id=1,Name="Panaldo",Price=2220,isOnsale=true, pictureUrl = ""
            },
            new Product() {Id=1,Name="Soi Beo",Price=2220,isOnsale=true, pictureUrl="" }
        };
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult doCreate(Product product)
        {
            bool isValid = true;
            ModelState.Clear();
            if (product.Name == null || product.Name.Length < 3)
            {
                isValid = true;
                ModelState.AddModelError("Name", "Sorry");
            }
            if (isValid == false)
            {
                return View("Create");
            }
            else
            {
                productList.Add(product);
                return RedirectToAction("ViewAll");
            }
        }
        public IActionResult ViewAll()
        {
            return View(productList);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
