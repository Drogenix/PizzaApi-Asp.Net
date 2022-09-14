using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaApi.Models
{
    public class Order
    {

        public int Id { get; set; }

        public int OrderId { get; set; }

        public int PizzaId { get; set; }

        public string Name { get; set; }

        public string Phonenum { get; set; }

        public string Street { get; set; }

        public int Homenum { get; set; }

        public int? Flatnum { get; set; }

        public string Paykind { get; set; }

        public int Amount { get; set; }

        [Column(TypeName = "decimal(4,2)")]
        public decimal TotalPrice { get; set; }

    }
}
