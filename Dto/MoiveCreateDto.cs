using SchoolS4.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SchoolS4.Dto
{
    public class MoiveCreateDto
    {
        [Required]
        [MaxLength(100)]

        public string Title { get; set; }

        public int Duration { get; set; }
     
     
        public int HallId { get; set; }
    }
}
