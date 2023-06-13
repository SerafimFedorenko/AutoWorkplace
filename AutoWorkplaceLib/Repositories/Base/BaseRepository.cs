using AutoWorkplaceLib.Data;
using AutoWorkplaceLib.Models.Base;
using AutoWorkplaceLib.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories.Base;
public class BaseRepository<T> : IRepository<T> where T : BaseEntity, new()
{
    private readonly AutoWorkplaceContext _context;
    private readonly DbSet<T> _set;

    protected BaseRepository(AutoWorkplaceContext context)
    {
        _context = context;
        _set = _context.Set<T>();
    }

    public virtual IQueryable<T> AllItems => _set;
    public virtual IQueryable<T> ItemsForDetails => _set;

    public void Delete(int id)
    {
        _context.Remove(new T { Id = id });
        _context.SaveChanges();
    }

    public int Insert(T entity)
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

    public void Update(T entity)
    {
        ArgumentNullException.ThrowIfNull(entity, nameof(entity));

        _context.Entry(entity).State = EntityState.Modified;
        _context.SaveChanges();
    }
}