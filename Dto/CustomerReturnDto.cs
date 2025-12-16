using SchoolS4.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SchoolS4.Dto
{
    public class CustomerReturnDto
    {

        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public ICollection<MoivereturnDtoforcustomer> moviesdto { get; set; } = new List<MoivereturnDtoforcustomer>();

      
    

        public ticketCreateDto Ticket { get; set; }
    }
}
