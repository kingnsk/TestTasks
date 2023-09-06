using Microsoft.AspNetCore.Mvc;
using TestWebApplication.Data;

namespace TestWebApplication.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var categories = _dbContext.Categories.ToList();

            return View(categories);
        }

        public IActionResult GetProductsByCategory(int categoryId)
        {
            var products = _dbContext.Products.Where(p => p.CategoryId == categoryId).ToList();
            return PartialView(products);
        }
    }
}
