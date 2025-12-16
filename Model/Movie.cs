using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolS4.Model
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]

        public string Title { get; set; }

        public int Duration { get; set; }
        public ICollection<Customer> customers { get; set; } = new List<Customer>();
        [ForeignKey("Hall")]
        public int HallId { get; set; }
        public  Hall Hall { get; set; }


    }
}
