using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolS4.Model
{
    public class Customer
    {

        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public ICollection<Movie> movies { get; set; } = new List<Movie>();

        [ForeignKey("Ticket")]
        public int? TicketId { get; set; }

        public  Ticket Ticket { get; set; }



    }
}
