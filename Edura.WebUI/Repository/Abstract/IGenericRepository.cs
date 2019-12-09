using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Edura.WebUI.Repository.Abstract
{
    public interface IGenericRepository<Tentity>where Tentity:class
    {
        Tentity Get(int id);                                                         //Entity için generic repolar.
        IQueryable<Tentity> GetAll();                                                //Entity için generic repolar.
        IQueryable<Tentity> Find(Expression<Func<Tentity, bool>> predicate);         //Entity için generic repolar.
        void Add(Tentity entity);                                                    //Entity için generic repolar.
        void Delete(Tentity entity);                                                 //Entity için generic repolar.
        void Edit(Tentity entity);                                                   //Entity için generic repolar.
        void Save();                                                                 //Entity için generic repolar.
    }                                                                                //Entity için generic repolar.
}                                                                                    //Entity için generic repolar.
