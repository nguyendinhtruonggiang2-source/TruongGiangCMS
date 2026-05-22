using Microsoft.AspNetCore.Mvc;
using CMS.Data.Entities;
using CMS.Data.Contexts;

namespace GiangCMS_api.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CMSDbContext _context;

        public CategoryController(CMSDbContext context)
        {
            _context = context;
        }

        // HIỂN THỊ DANH SÁCH
        public IActionResult Index()
        {
            var list = _context.Categories.ToList();

            return View(list);
        }

        // HIỂN THỊ FORM
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // LƯU DỮ LIỆU
        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Add(category);

                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(category);
        }
    }
}