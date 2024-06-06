namespace Fanush.DAL.Interfaces
{
    public interface IGenericRepository<TEnttity> where TEnttity : class
    {
        Task<IEnumerable<TEnttity>> Get();
        Task<TEnttity> Get(int id);
        Task<object> Post(TEnttity entity);
        Task<object> Put(int id, TEnttity entity);
        Task<object> Delete(int id);
    }
}
