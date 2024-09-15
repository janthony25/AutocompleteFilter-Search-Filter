using AutocompleteFilter.Data;
using AutocompleteFilter.Models;
using Microsoft.EntityFrameworkCore;

namespace AutocompleteFilter.Repository
{
    public class CarModelRepository : ICarModelRepository
    {
        private readonly DataContext _data;

        public CarModelRepository(DataContext data)
        {
            _data = data;
        }
        public async Task<List<CarModel>> SearchCarModelAsync(string searchTerm)
        {
            return await _data.CarModels
                .Where(cm => cm.ModelName.Contains(searchTerm))
                .ToListAsync();
        }
    }
}
