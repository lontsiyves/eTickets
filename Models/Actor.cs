
using System.ComponentModel.DataAnnotations;



namespace eTickets.Models
{
    public class Actor
    {

        [Key]

        public int Id { get; set; }

        [Display(Name = "Profil picture Url")]
        public string profilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        public string Bio { get; set;}


        [Display(Name = "Biographie")]
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
