using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace ShoplateAPP.Models
{
    public class Item
    {
        public Item(int id, string name, string description, string image, decimal price, int? orderId = null)
        {
            Id = id;
            Name = name;
            Description = description;
            Image = image;
            Price = price;
            OrderId = orderId;
        }

      
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Description { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public decimal Price { get; set; }

        public int? OrderId { get; set; }

        public Order? Order { get; set; }
    }

}
