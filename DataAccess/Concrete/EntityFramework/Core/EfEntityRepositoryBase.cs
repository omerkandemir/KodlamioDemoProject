using DataAccess.Abstract.Core;
using Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Core
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        
        public void Add(TEntity entity)
        {
            try
            {
                Crud(entity, EntityState.Added);
            }
            catch
            {
                throw new Exception("Ekleme gerçekleşemedi");
            }
        }
        public void Update(TEntity entity)
        {
            try
            {
                Crud(entity, EntityState.Modified);
            }
            catch
            {
                throw new Exception("Güncelleme gerçekleşemedi");
            }
        }
        public void Delete(TEntity entity)
        {
            try
            {
                Crud(entity, EntityState.Deleted);
            }
            catch
            {
                throw new Exception("Silme gerçekleşemedi");
            }

        }

        private static void Crud(TEntity entity, EntityState entityState)
        {
            using (TContext context = new TContext())
            {
                var crudEntity = context.Entry(entity);
                crudEntity.State = entityState;
                context.SaveChanges();
            }
        }
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAllInclude(Expression<Func<TEntity, bool>> filter = null, params Expression<Func<TEntity, object>>[] include)
        {
            using (TContext context = new TContext())
            {
                if (filter == null)
                {
                    return include == null || include.Count() == 0 ? context.Set<TEntity>().ToList() : context.Set<TEntity>().GetIncludes(include).ToList();
                }
                else
                {
                    return include == null || include.Count() == 0 ? context.Set<TEntity>().Where(filter).ToList() : context.Set<TEntity>().Where(filter).GetIncludes(include).ToList();

                }
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }
    }
}
