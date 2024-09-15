using AutocompleteFilter.Models;

namespace AutocompleteFilter.Repository
{
    public interface ICarModelRepository
    {
        Task<List<CarModel>> SearchCarModelAsync(string searchTerm);
    }
}
