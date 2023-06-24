using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ShoplateAPP.Models
{
    // Class for any user 
    public class User
    {
        public User(int id, string name, string surname, string phone, string email, string password, string isAdmin, string username)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Phone = phone;
            Email = email;
            Password = password;
            IsAdmin = isAdmin;
            Username = username;
        }

        [Required]
        [MaxLength(100)]
        public string Username { get; set; }

        public string IsAdmin { get; set; }

        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Numer telefonu jest wymagany")]
        [Phone(ErrorMessage = "Niepoprawny numer telefonu")]
        [Display(Name = "Numer telefonu")]
        public string Phone { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Niepoprawny adres e-mail")]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}