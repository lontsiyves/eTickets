
using System.ComponentModel.DataAnnotations;



namespace eTickets.Models
{
    public class Actor
    {

        [Key]

        public int Id { get; set; }

        [Display(Name = "Profil Picture")]
        [Required(ErrorMessage ="Profil Picture is required")]
        public string profilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        public string FullName { get; set; }

        public string Bio { get; set;}

        [Display(Name = "Biographie")]
        [Required(ErrorMessage = "Biography is required")]
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
