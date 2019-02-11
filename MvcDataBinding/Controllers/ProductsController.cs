using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDataBinding.Models;
using System.Net;

namespace MvcDataBinding.Controllers
{
    public class ProductsController : Controller
    {
        ProductsContext db = new ProductsContext();
        public ViewResult Index()
        {
            return View(db.ProductsTable.ToList());
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Product ID required");
            }
            Product product = db.ProductsTable.Find(id);
            if (product == null) {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound, "Product not found");
            }
            return View(product);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection formCollection)
        {
            Product product = new Product();
            product.Name = formCollection["Name"];
            product.Price = Convert.ToDecimal(formCollection["Price"]);
            db.ProductsTable.Add(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}