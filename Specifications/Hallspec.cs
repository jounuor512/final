using SchoolS4.Model;

namespace SchoolS4.Specifications
{
    public class Hallspec:BaseSpecifications<Hall>
    {

        public Hallspec():base()
        {
            Include.Add(H => H.movies);
        }
        public Hallspec(int id ) : base(H=>H.Id==id)
        {
            Include.Add(H => H.movies);
        }

    }
}
