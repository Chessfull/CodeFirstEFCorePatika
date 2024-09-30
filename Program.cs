using CodeFirstEFCorePatika.Data;
using CodeFirstEFCorePatika.Entities;

namespace WebApiPatikaBootcampTask
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var database = new PatikaFirstDbContext())
            {
                var game = new Game { Name = "TrailGame", Platform = "TrailPlatform", Rating = 8 };
                var movie = new Movie { Title = "TrailTitle", Genre = "TrailGenre", ReleaseYear = 1950 };

                database.Add(game);

                database.Add(movie);

                database.SaveChanges();

                Console.WriteLine("Datas added ...");
            }
        }
    }
}