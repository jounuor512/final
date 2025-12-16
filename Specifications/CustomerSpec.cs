using SchoolS4.Model;

namespace SchoolS4.Specifications
{
    public class CustomerSpec:BaseSpecifications<Customer>
    {
        public CustomerSpec():base()
        {
            Include.Add(c => c.Ticket);

            Include.Add(c => c.movies);
        }


        public CustomerSpec(int id ) : base(c=>c.Id==id)
        {
            Include.Add(c => c.Ticket);

            Include.Add(c => c.movies);
        }
    }
}
