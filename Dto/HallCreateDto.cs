using System.ComponentModel.DataAnnotations;

namespace SchoolS4.Dto
{
    public class HallCreateDto
    {

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public int capacity { get; set; }
    }
}
