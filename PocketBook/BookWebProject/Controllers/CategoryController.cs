using BookWebProject.Data;
using BookWebProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookWebProject.Controllers {
    public class CategoryController : Controller {

        private readonly ApplicationDbContext _dbContext;
        public CategoryController(ApplicationDbContext dbContext) {
            _dbContext = dbContext;
        }

        public IActionResult Index() {

            IEnumerable<Category> ieCategories = _dbContext.Categories;


            return View(ieCategories);
        }
    }
}
