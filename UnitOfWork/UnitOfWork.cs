using CelilCavus.ElementWebSite.Models.Database.Context;
using CelilCavus.ElementWebSite.Models.Database.Entity;
using CelilCavus.ElementWebSite.Repository;

namespace CelilCavus.ElementWebSite.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ElementContext context;

        public UnitOfWork(ElementContext context)
        {
            this.context = context;
        }

        public IBaseRepository<T> GetRepository<T>() where T : BaseEntity
        {
            return new Repository<T>(context);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}