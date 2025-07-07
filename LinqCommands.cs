using System;
using System.Diagnostics;

namespace LinqCommandsApp;

public class Program
{
    public static void Main(string[] args)
    {
        List<Movie> movielist = new List<Movie>();

        Movie m1 = new Movie("124", "Inception", "Thriller", "2010", "9.4");
        Movie m2 = new Movie("125", "The Dark Knight", "Action", "2008", "8.9");
        Movie m3 = new Movie("126", "Parasite", "Thriller", "2019", "8.1");
        Movie m4 = new Movie("127", "The Godfather", "Crime", "1992", "7.5");
        Movie m5 = new Movie("128", "Spirited Away", "Crime", "2001", "7");

        movielist.Add(m1);
        movielist.Add(m2);
        movielist.Add(m3);
        movielist.Add(m4);
        movielist.Add(m5);

        // filtering according to genre "crime"
        var crimegenre = movielist.Where(movie => movie.Genre == "Crime");

        foreach (var movie in crimegenre)
        {
            Console.WriteLine(movie.Title);
        }

        // Ascending order of titles
        var sortedlist = movielist.OrderBy(movie => movie.Title);

        foreach (var movie in sortedlist)
        {
            Console.WriteLine(movie.Title);
        }

        // movies released after 2000
        var releasedafter2000 = movielist.Where(movie => Convert.ToInt32(movie.ReleaseYear) > 2000);

        foreach (var movie in releasedafter2000)
        {
            Console.WriteLine(movie.Title + " " + movie.ReleaseYear);
        }

        // A list of all the titles

        var onlytitlelist = movielist.Select(movie => movie.Title);

        foreach (var movie in onlytitlelist)
        {
            Console.WriteLine(movie);
        }

        // movies rated above 8.5

        var moviesabove85 = movielist.Where(movie => Convert.ToDouble(movie.Rating) > 8.5);

        Console.WriteLine(moviesabove85.Count());

        // grouping by genre

        var groupedbygenre = movielist.GroupBy(movie => movie.Genre);

        foreach (var moviegenrelist in groupedbygenre)
        {
            Console.WriteLine(moviegenrelist.Key);

            foreach (var movie in moviegenrelist)
            {
                Console.WriteLine(movie.Title);
            }
        }

        // Movie with the highest rating

        var moviewithhighestrating = movielist.Aggregate((max, current) => Convert.ToDouble(current.Rating) > Convert.ToDouble(max.Rating) ? current : max);

        Console.WriteLine(moviewithhighestrating.Title);

        // average of all movies

        var averagemovies = movielist.Average(movie => Convert.ToDouble(movie.Rating));

        Console.WriteLine(averagemovies);

        // if any movie was released in the 90s

        var ifexists90s = movielist.Any(movie => Convert.ToInt32(movie.ReleaseYear) >= 1990 && Convert.ToInt32(movie.ReleaseYear) <= 1999);

        Console.WriteLine(ifexists90s);

        var startswitht = movielist.Where(movie => movie.Title[0] == 'T' || movie.Title[0] == 't');

        foreach (var movie in startswitht)
        {
            Console.WriteLine(movie.Title);
        }

        var paginate = movielist.Skip(2).Take(2);

        var top3ratedmovies = movielist.OrderByDescending(movie => Convert.ToDouble(movie.Rating)).Take(3);

        foreach (var movie in top3ratedmovies)
        {
            Console.WriteLine(movie.Title + " " + movie.Rating);
        }

        // first movie with genre scifi

        var firstmovwithscifi = movielist.FirstOrDefault(movie => movie.Genre == "Thriller");

        Console.WriteLine(firstmovwithscifi.Title + " " + firstmovwithscifi.Genre);

        var ratabove8 = movielist.All(movie => Convert.ToDouble(movie.Rating) > 8);

        Console.WriteLine(ratabove8);
    }
}
