
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer
    {


        [key]
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Bio { get; set; }

        public string ProfilePictureURL { get; set; }
    }
}
