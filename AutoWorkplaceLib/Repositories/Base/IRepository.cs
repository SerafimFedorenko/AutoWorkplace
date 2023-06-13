using AutoWorkplaceLib.Models.Base;

namespace AutoWorkplaceLib.Repositories.Base
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Update(T entity);
        void Delete(int id);
        int Insert(T entity);
        List<T> SelectAll();
        T SelectById(int id);
    }
}
