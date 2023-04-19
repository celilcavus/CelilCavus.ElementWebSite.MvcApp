using CelilCavus.ElementWebSite.Models.Database.Context;
using CelilCavus.ElementWebSite.Models.Database.Entity;
using System.Collections.Generic;
using System.Linq;

namespace CelilCavus.ElementWebSite.Repository
{
    public class Repository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly ElementContext _context;

        public Repository(ElementContext context)
        {
            _context = context;
        }

        public void Add(T item)
        {
            _context.Set<T>().Add(item);
        }

        public void Delete(T item)
        {
            _context.Set<T>().Remove(item);
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public IEnumerable<T> GetList()
        {
            return _context.Set<T>().AsNoTracking().ToList();
        }

        public IEnumerable<T> SqlQuery(string query)
        {
            return _context.Set<T>().SqlQuery(query).AsNoTracking().ToList();
        }
        public IEnumerable<T> SqlQueryAsc(string query)
        {
            return _context.Set<T>().SqlQuery(query).AsNoTracking().OrderBy(x => x.Id).ToList();
        }
        public IEnumerable<T> SqlQueryDesc(string query)
        {
            return _context.Set<T>().SqlQuery(query).AsNoTracking().OrderByDescending(x => x.Id).ToList();
        }
    }
}