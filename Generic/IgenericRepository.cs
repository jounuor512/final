using SchoolS4.Specifications;

namespace SchoolS4.Generic
{
    public interface IgenericRepository<T>where T : class

    {

         Task<IEnumerable<T>> GetAllWithspec(Ispecifications<T> spec);
        Task<T> getbyid(Ispecifications<T> spec);
        Task AddItemd(T item);
        Task DeleteItemd(T item);
        Task updateitem(T item);    

    }
}
