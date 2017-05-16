using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechElevator.Web.Models;

namespace TechElevator.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home/
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/MovieList
        public ActionResult MovieList()
        {
            List<Movie> model = GetMovieList();
            return View("MovieList", model);
        }

        // GET: Home/MovieDetail/{id}
        public ActionResult MovieDetail(string id)
        {
            List<Movie> movies = GetMovieList();

            Movie model = null;

            foreach (var movie in movies)
            {
                if (movie.Id.ToLower() == id.ToLower())
                {
                    model = movie;
                    break;
                }
            }

            return View("MovieDetail", model);
        }



        // DONT MODIFY THESE
        private List<Movie> GetMovieList()
        {
            List<Movie> movies = new List<Movie>();
            Movie m = new Movie();
            m.Id = "interstellar";
            m.Name = "Interstellar";
            m.Description = "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.";
            m.RunningTime = 179;
            m.YearReleased = 2014;
            m.Genre = "Space";
            m.Cast.Add("Matthew McConaughey");
            m.Cast.Add("Anne Hathaway");
            m.Cast.Add("Matt Damon");
            m.ShowTimes.Add(new ShowTime() { StartTime = new DateTime(2016, 06, 15, 12, 0, 0), Theatre = "Regal Cinemas" });
            m.ShowTimes.Add(new ShowTime() { StartTime = new DateTime(2016, 06, 15, 15, 0, 0), Theatre = "Valley View" });
            m.ShowTimes.Add(new ShowTime() { StartTime = new DateTime(2016, 06, 15, 18, 0, 0), Theatre = "Strongsville" });
            m.ShowTimes.Add(new ShowTime() { StartTime = new DateTime(2016, 06, 15, 21, 0, 0), Theatre = "Regal Cinemas" });
            movies.Add(m);

            m = new Movie();
            m.Id = "batman-begins";
            m.Name = "Batman Begins";
            m.Description = "After training with his mentor, Batman begins his war on crime to free the crime-ridden Gotham City from corruption that the Scarecrow and the League of Shadows have cast upon it.";
            m.RunningTime = 140;
            m.YearReleased = 2005;
            m.Genre = "Action";
            m.Cast.Add("Christian Bale");
            m.Cast.Add("Michael Caine");
            m.Cast.Add("Ken Watanabe");
            m.ShowTimes.Add(new ShowTime() { StartTime = new DateTime(2015, 06, 10, 12, 0, 0), Theatre = "Regal Cinemas" });
            m.ShowTimes.Add(new ShowTime() { StartTime = new DateTime(2015, 06, 12, 12, 0, 0), Theatre = "Regal Cinemas" });
            m.ShowTimes.Add(new ShowTime() { StartTime = new DateTime(2015, 06, 13, 12, 0, 0), Theatre = "Regal Cinemas" });
            m.ShowTimes.Add(new ShowTime() { StartTime = new DateTime(2015, 06, 13, 15, 0, 0), Theatre = "Regal Cinemas" });
            movies.Add(m);

            m = new Movie();
            m.Id = "inception";
            m.Name = "Inception";
            m.Description = "A thief, who steals corporate secrets through use of dream-sharing technology, is given the inverse task of planting an idea into the mind of a CEO.";
            m.RunningTime = 148;
            m.YearReleased = 2010;
            m.Genre = "Action";
            m.Cast.Add("Leonardo DiCaprio");
            m.Cast.Add("Michael Caine");
            m.Cast.Add("Joseph Gordon-Levitt");
            m.Cast.Add("Ellen Page");
            m.ShowTimes.Add(new ShowTime() { StartTime = new DateTime(2010, 06, 10, 12, 0, 0), Theatre = "Strongsville" });
            m.ShowTimes.Add(new ShowTime() { StartTime = new DateTime(2010, 06, 12, 12, 0, 0), Theatre = "Strongsville" });
            m.ShowTimes.Add(new ShowTime() { StartTime = new DateTime(2010, 06, 13, 12, 0, 0), Theatre = "Strongsville" });
            m.ShowTimes.Add(new ShowTime() { StartTime = new DateTime(2010, 06, 13, 15, 0, 0), Theatre = "Strongsville" });
            movies.Add(m);

            m = new Movie();
            m.Id = "the-dark-knight";
            m.Name = "The Dark Knight";
            m.Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, the caped crusader must come to terms with one of the greatest psychological tests of his ability to fight injustice.";
            m.RunningTime = 152;
            m.YearReleased = 2008;
            m.Genre = "Action";
            m.Cast.Add("Christian Bale");
            m.Cast.Add("Michael Caine");
            m.Cast.Add("Heath Ledger");
            m.Cast.Add("Aaron Eckhart");
            m.ShowTimes.Add(new ShowTime() { StartTime = new DateTime(2016, 06, 10, 12, 0, 0), Theatre = "Drive-In" });
            m.ShowTimes.Add(new ShowTime() { StartTime = new DateTime(2016, 06, 10, 15, 0, 0), Theatre = "Drive-In" });
            m.ShowTimes.Add(new ShowTime() { StartTime = new DateTime(2016, 06, 10, 18, 0, 0), Theatre = "Drive-In" });
            m.ShowTimes.Add(new ShowTime() { StartTime = new DateTime(2016, 06, 10, 21, 0, 0), Theatre = "Drive-In" });
            movies.Add(m);

            return movies;
        }
    }
}