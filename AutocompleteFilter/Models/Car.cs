using System.ComponentModel.DataAnnotations;

namespace AutocompleteFilter.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        public string CarName { get; set; }
        public ICollection<CarModel> CarModel { get; set; }    

    }
}
