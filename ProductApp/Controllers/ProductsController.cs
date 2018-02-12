using ProductApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductApp.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product{Id=1,Name="Kebap",Category="Yemek",Price=10},
            new Product{Id=2,Name="Laptop",Category="Teknoloji",Price=2000},
            new Product{Id=3,Name="Kazak",Category="Giyim",Price=30}
        };

        public IEnumerable<Product> getAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id) {
            var product = products.FirstOrDefault(x=>x.Id==id);

            if (product==null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
