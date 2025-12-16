using SchoolS4.Model;

namespace SchoolS4.Specifications
{
    public class MovieSpec:BaseSpecifications<Movie>
    {

        public MovieSpec():base()
        {
            Include.Add(M => M.customers);
            Include.Add(M => M.Hall);

        }

        public MovieSpec(int id) : base(M=>M.Id==id)
        {
            Include.Add(M => M.customers);
            Include.Add(M => M.Hall);

        }

    }
}
