using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaApi
{
    public class Pizza
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Ingredients { get; set; }

        public string ImageUrl { get; set; }

        [Column(TypeName = "decimal(4,2)")]
        public decimal Price { get; set; }
    }
}
