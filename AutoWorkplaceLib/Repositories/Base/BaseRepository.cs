using AutoWorkplaceLib.Data;
using AutoWorkplaceLib.Models.Base;
using AutoWorkplaceLib.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Persistence.Repositories.Base;
public class BaseRepository<T> : IRepository<T> where T : BaseEntity, new()
{
    protected readonly AutoWorkplaceContext _context;
    protected readonly DbSet<T> _set;

    protected BaseRepository()
    {
        _context =  new AutoWorkplaceContext();

        _set = _context.Set<T>();
    }

    public virtual IQueryable<T> AllItems => _set;
    public virtual IQueryable<T> ItemsForDetails => _set;

    public virtual void Delete(int id)
    {
        _context.Remove(new T { Id = id });
        _context.SaveChanges();
    }

    public virtual int Insert(T entity)
    {
        ArgumentNullException.ThrowIfNull(entity, nameof(entity));

        _context.Entry(entity).State = EntityState.Added;
        _context.SaveChanges();
        return entity.Id;
    }

    public List<T> SelectAll() => AllItems.ToList();

    public T SelectById(int id)
    {
        var entity = ItemsForDetails.FirstOrDefault(x => x.Id.Equals(id));

        return entity;
    }

    public virtual void Update(T entity)
    {
        ArgumentNullException.ThrowIfNull(entity, nameof(entity));

        _context.Entry(entity).State = EntityState.Modified;
        _context.SaveChanges();
    }
}