using Microsoft.EntityFrameworkCore;

namespace SchoolS4.Specifications
{
    public static class SpecEvalator<T>where T : class
    {


        public static  IQueryable<T> GetQuery(IQueryable<T>inputquery,Ispecifications<T>spec)
        {

            var query = inputquery;

            if(spec.condition is not null)
            {
                    query=query.Where(spec.condition);
            }

            query = spec.Include.Aggregate(query, (curr, next) => curr.Include(next));
            return query;


        }

    }
}
