using System.ComponentModel.DataAnnotations;

namespace SchoolS4.Model
{
    public class Hall
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public int capacity { get; set; }

        public ICollection<Movie>movies { get; set; }   =new List<Movie>();

        



    }
}
