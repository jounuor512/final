using System.Linq.Expressions;

namespace SchoolS4.Specifications
{
    public class BaseSpecifications<T> : Ispecifications<T> where T : class
    {
        public Expression<Func<T, bool>> condition { get; set; }
        public List<Expression<Func<T, object>>> Include { get; set; } = new List<Expression<Func<T, object>>>();

        public BaseSpecifications()
        {
            
        }
        public BaseSpecifications(Expression<Func<T,bool>>expression)
        {
            condition = expression; 
        }

    }
}
