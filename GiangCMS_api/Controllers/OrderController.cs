using CMS.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GiangCMS_api.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            var orders = new List<Order>
            {
                new Order
                {
                    Id = 1,
                    CustomerName = "Nguyen Van A",
                    Phone = "0123456789",
                    TotalPrice = 2500000,
                    OrderDate = DateTime.Now
                },

                new Order
                {
                    Id = 2,
                    CustomerName = "Tran Thi B",
                    Phone = "0987654321",
                    TotalPrice = 1800000,
                    OrderDate = DateTime.Now
                }
            };

            return View(orders);
        }
    }
}