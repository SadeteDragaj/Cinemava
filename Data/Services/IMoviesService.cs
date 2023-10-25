using Cinemava.Models;
using Cinemava.Data.Base;
using System.Threading.Tasks;
using Cinemava.Data.ViewModels;

namespace Cinemava.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);

        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();

        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);
    }
}
