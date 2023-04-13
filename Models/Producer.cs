
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer
    {


        [Key]
        public int Id { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Biographie")]
        public string Bio { get; set; }


        [Display(Name = "Profil Picture")]

        public string ProfilePictureURL { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
