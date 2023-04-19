using CelilCavus.ElementWebSite.Models.Database.Entity;
using System.Collections.Generic;

namespace CelilCavus.ElementWebSite.Repository
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        void Add(T item);
        void Delete(T item);
        T GetById(int id);
        IEnumerable<T> GetList();

        IEnumerable<T> SqlQuery(string query);
        IEnumerable<T> SqlQueryAsc(string query);

        IEnumerable<T> SqlQueryDesc(string query);
    }
}