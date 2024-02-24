using Movies.Core.Entities.Base;

namespace Movies.Core.Entities
{
    public class Movie: Entity
    {
        public string MovieName { get; set; }
        public string DirectorName { get; set; }
        public string RelaseYear { get; set; }

        public Movie(string movieName, string directorName, string relaseYear)
        {
            MovieName = movieName;
            DirectorName = directorName;
            RelaseYear = relaseYear;
        }
    }
}
