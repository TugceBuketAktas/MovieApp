using System.Collections.Generic;
using System.Linq;
using MovieApp.Models;

namespace MovieApp.Data
{
    public static class MovieRepository
    {
        private static List<Movie> _movies = null;
        
        static MovieRepository()
        {

            _movies = new List<Movie>()
            {
                new Movie()
                { 
                    Id=1,
                    Name = "Invisible Man", 
                    ShortDescription="scream", 
                    Description="The Invisible Man is a 2020 sci-fi horror movie written and directed by Leigh Whannell. The film includes Elisabeth Moss, Aldis Hodge, Storm Reid, Harriet Dyer,Michael Dorman and Oliver Jackson-Cohen. It is an international co-production of the United States and Australia.",
                    ImageUrl="gorunmez.jpg",
                    CategoryId= 4
                },
                new Movie()
                { 
                    Id=2, 
                    Name = "Mulan", 
                    ShortDescription="action", 
                    Description="Mulan is a 2020 American action drama film directed by Niki Caro and directed by Rick Jaffa, Amanda Silver, Lauren Hynek and Elizabeth Martin, shot by Walt Disney Pictures.",
                    ImageUrl="mulan.jpg",
                    CategoryId=1
                },
                new Movie()
                { 
                    Id=3, 
                    Name = "A Quiet Place 2", 
                    ShortDescription="thriller movie",
                    Description= "A Silent Place Episode II is the sequel to the 2020 American horror movie and a Silent Place. The sequel was written and directed by John Krasinski, and Emily Blunt, Millicent Simmonds and Noah Jupe revived their roles in the first movie. Cillian Murphy and Djimon Hounsou also joined the cast.",
                    ImageUrl="sessiz2.jpg",
                    CategoryId = 4
                },
                new Movie()
                { Id=4, 
                Name = "Wonder Woman 2", 
                ShortDescription="adventure / fantasy movie",
                Description= "Wonder Woman 1984 is the ninth film of the DC Cinematic Universe, directed by Patty Jenkins, planned to be released on August 14, 2020, starring Gal Gadot, Chris Pine, Kristen Wiig, Pedro Pascal, Connie Nielsen and Robin Wright.",
                ImageUrl="wonder2.jpg",
                CategoryId = 2
                },
                

            };
        }

        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }

        }

        public static void AddMovie (Movie entity)
        {
            _movies.Add(entity);

        }

        public static Movie GetById (int id)
        {
            return _movies.FirstOrDefault(i => i.Id == id);

        }




    }
}