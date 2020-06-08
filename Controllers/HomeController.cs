using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    public class HomeController:Controller
    {
        [HttpGet]
        public IActionResult Index(int? id) //id alabilir de, almaya da bilir
        {

          var movies = MovieRepository.Movies;

          if(id != null)
          {
            movies = movies.Where(i => i.Id == id).ToList();

          }

          //MovieRepository.Movies
          //CategoryRepository.Categories

          // MovieCategoryModel model = new MovieCategoryModel();
          // model.Movies = MovieRepository.Movies;
          // model.Categories = CategoryRepository.Categories;

           return View(movies);
        }
          public IActionResult Details(int id) //view _movies da belirttiğim id beklenen id olacak
        {
          // MovieCategoryModel model = new MovieCategoryModel();
          // model.Movie = MovieRepository.GetById(id);
          // model.Categories = CategoryRepository.Categories;

           return View(MovieRepository.GetById(id));
        }

        public IActionResult Contact()
        {
          return View();
        }


    }
}