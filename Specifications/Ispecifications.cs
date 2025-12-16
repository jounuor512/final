using System.Linq.Expressions;

namespace SchoolS4.Specifications
{
    public interface Ispecifications<T>where T : class
    {
        public Expression<Func<T,bool>> condition { get; set; }
        public List<Expression<Func<T,object>>> Include { get; set; }
    }
}
