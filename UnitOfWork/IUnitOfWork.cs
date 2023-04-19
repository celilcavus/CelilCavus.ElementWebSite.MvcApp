using CelilCavus.ElementWebSite.Models.Database.Entity;
using CelilCavus.ElementWebSite.Repository;

namespace CelilCavus.ElementWebSite.UnitOfWork
{
    public interface IUnitOfWork
    {
        IBaseRepository<T> GetRepository<T>() where T : BaseEntity;
        void SaveChanges();
    }
}
