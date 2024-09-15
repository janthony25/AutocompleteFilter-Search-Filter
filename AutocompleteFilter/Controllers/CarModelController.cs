using AutocompleteFilter.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AutocompleteFilter.Controllers
{
    public class CarModelController : Controller
    {
        private readonly ICarModelRepository _carModelRepository;

        public CarModelController(ICarModelRepository carModelRepository)
        {
            _carModelRepository = carModelRepository;
        }

        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> Search(string searchTerm)
        {
            // Check if search term is empty
            if (string.IsNullOrEmpty(searchTerm))
            {
                return Json(new { success = false, message = "CarModel not available" });
            }

            // Fetch matching car models from the repository
            var carModels = await _carModelRepository.SearchCarModelAsync(searchTerm);

            // Return the result as JSON
            return Json(carModels);
        }
    }
}
