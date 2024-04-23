using System;
using System.Buffers.Text;
class Movie
{
    public string name;
    public string rating;
    public double runninTime; 
    public string director;

    public Movie(string name, string rating, double runninTime, string director)
    {
        this.name = name;
        this.rating = rating;
        this.runninTime = runninTime;
        this.director = director;
    }
    public Movie()
    {
    }

    List<Movie> movies = new List<Movie>();

    public void AddMovie(string name, string rating, double runninTime, string director)
    {
        movies.Add(new Movie(name, rating, runninTime, director));
    }
    
    public void DisplayMovies()
    {
        foreach (Movie movie in movies)
        {
            Console.WriteLine("Movie Name: " + movie.name);
            Console.WriteLine("Movie Rating: " + movie.rating);
            Console.WriteLine("Movie Running Time: " + movie.runninTime);
            Console.WriteLine("Movie Director: " + movie.director);
        }
    }
}

class Program
{
    static void Main()
    {
        Movie movies = new Movie();
        movies.AddMovie("Movie 1", "PG-13", 2.5, "Director 1");
        movies.AddMovie("Movie 2", "PG-13", 2.5, "Director 2");
        movies.AddMovie("Movie 3", "PG-13", 2.5, "Director 3");
        movies.DisplayMovies();
    }
}