using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoplateAPP.Models
{
    public class Order
    {
        
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        public ICollection<Item> Items { get; set; }

        public int UserId { get; set; }

        public User User { get; set; } 

        public string City { get; set; }

        public string Address { get; set; }
    }
}

