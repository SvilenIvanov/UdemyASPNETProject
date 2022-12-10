using Microsoft.AspNetCore.Mvc;

namespace BookWebProject.Controllers {
    public class CategoryController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}
