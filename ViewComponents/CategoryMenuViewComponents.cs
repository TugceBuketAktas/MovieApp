using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;

namespace MovieApp.ViewComponents
{
    [ViewComponent(Name = "CategoryMenu")]
    public class CategoryMenuViewComponents: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.Selected = RouteData?.Values["id"];
            return View(CategoryRepository.Categories);

        }
    }
}