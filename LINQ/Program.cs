namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> favoriteMovies = new List<string>() { "How to lose a guy in ten days", "Just go with it", "The proposal" };

            favoriteMovies.Add("My best friend wedding");
            favoriteMovies.Add("Grown up");

            var orderedMovies = favoriteMovies.OrderBy(name => name.Length);

            foreach (var movie in orderedMovies)
            {
                Console.WriteLine(movie);
            }
        }
    }
}
