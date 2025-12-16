using System.ComponentModel.DataAnnotations;

namespace SchoolS4.Dto
{
    public class CustomerCreateDto
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public List<int>? Moiveid { get; set; }

        public ticketCreateDto? Ticket { get; set; }
    }
}
