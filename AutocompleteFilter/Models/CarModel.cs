using System.ComponentModel.DataAnnotations;

namespace AutocompleteFilter.Models
{
    public class CarModel
    {
        [Key]
        public int CarModelId { get; set; }
        public required string ModelName { get; set; }

        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}
