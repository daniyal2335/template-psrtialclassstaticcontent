using Microsoft.AspNetCore.Mvc;
using template_partialclass.Models;

namespace template_partialclass.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
			List<Product> products = new List<Product>()
			{
				new Product(){productId=1, productName="Shoes", Price=1100,Image="/images/Shoes.jpeg"},
				new Product(){productId=2, productName="Tshirt", Price=900,Image="/images/Tshirts.jpeg"},
				new Product(){productId=3, productName="Watch", Price=11,Image="/images/Watch.jpeg"}

			};
            return View(products);
        }
        public IActionResult Shop()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
		public IActionResult Services()
		{
			return View();
		}
		public IActionResult Blog()
		{
			return View();
		}
		public IActionResult Contact()
		{
			return View();
		}
		public IActionResult Cart()
		{
			return View();
		}


	}
}
