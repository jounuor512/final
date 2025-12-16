using System.ComponentModel.DataAnnotations;

namespace SchoolS4.Model
{
    public class Ticket
    {
        public int Id { get; set; }
        [Required]
        public string SeatNumber { get; set; }
        public decimal Price { get; set; }

        public string ShowTime { get; set; }
    }
}
