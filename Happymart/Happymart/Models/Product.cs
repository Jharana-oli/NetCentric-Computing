using System.ComponentModel.DataAnnotations;

namespace Happymart.Models
{
    public class Product
    {
        public int id { get; set; }

        [Required(ErrorMessage = "name is must")]
        public string name { get; set; }
        public int price { get; set; }
        public string category { get; set; }
    }
}
