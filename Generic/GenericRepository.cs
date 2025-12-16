using Microsoft.EntityFrameworkCore;
using SchoolS4.Data;
using SchoolS4.Specifications;

namespace SchoolS4.Generic
{
    public class GenericRepository<T> : IgenericRepository<T> where T : class
    {
        private readonly StoreDbContext storeDbContext;

        public GenericRepository( StoreDbContext storeDbContext)
        {
            this.storeDbContext = storeDbContext;
        }

        public async Task AddItemd(T item)
        {
          await storeDbContext.AddAsync(item);
            await storeDbContext.SaveChangesAsync();
        }

        public async Task DeleteItemd(T item)
        {
           storeDbContext.Set<T>().Remove(item);
            await storeDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllWithspec(Ispecifications<T> spec)
        {
            return await SpecEvalator<T>.GetQuery(storeDbContext.Set<T>(), spec).ToListAsync();
        }

        public async Task<T> getbyid(Ispecifications<T> spec)
        {
            return    await SpecEvalator<T>.GetQuery(storeDbContext.Set<T>(), spec).FirstOrDefaultAsync();
        }

        public async Task updateitem(T item)
        {
          storeDbContext.Set<T>().Update(item); 
            await storeDbContext.SaveChangesAsync();
        }
    }
}
