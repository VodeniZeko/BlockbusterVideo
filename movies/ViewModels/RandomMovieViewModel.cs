using movies.Models;

namespace movies.ViewModels
{
    public class RandomMovieViewModel
    {
        public required Movie Movie { get; set; }
        public required List<Customer> Customers { get; set; }
    }
}
