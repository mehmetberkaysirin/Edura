using Edura.WebUI.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Edura.WebUI.Repository.Concrete.EntityFramework
{
    public class EfGenericRepository<Tentity> : IGenericRepository<Tentity> where Tentity : class
    {

        protected readonly DbContext context;
        public EfGenericRepository(DbContext ctx)
        {
            context = ctx;
        }

        public void Add(Tentity entity)
        {
            context.Set<Tentity>().Add(entity);
        }

        public void Delete(Tentity entity)
        {
            context.Set<Tentity>().Remove(entity);
        }

        public void Edit(Tentity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }

        public IQueryable<Tentity> Find(Expression<Func<Tentity, bool>> predicate)
        {
            return context.Set<Tentity>().Where(predicate);
        }

        public Tentity Get(int id)
        {
            return context.Set<Tentity>().Find(id);
        }

        public IQueryable<Tentity> GetAll()
        {
            return context.Set<Tentity>();
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
