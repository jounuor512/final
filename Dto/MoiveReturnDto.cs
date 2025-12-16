using System.ComponentModel.DataAnnotations;

namespace SchoolS4.Dto
{
    public class MoiveReturnDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]

        public string Title { get; set; }

        public int Duration { get; set; }

        public string Hallname { get; set; }
    }
}
