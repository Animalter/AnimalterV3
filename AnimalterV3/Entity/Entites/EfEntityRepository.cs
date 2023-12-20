using AnimalterV3.Entity.Abstract.Entites;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AnimalterV3.Entity.Entites
{
    public class EfEntityRepository<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (var context = new TContext()) 
            {
                var addedEntity=context.Entry(entity); 
                addedEntity.State= EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext()) 
            {
                // boş isse bütün değerileri getirsin.yoksa sadece filtreleneni 
                //üçlü öperatör kullanımı
                return filter == null ? context.Set<TEntity>().ToList():context.Set<TEntity>().Where(filter).ToList();
                //şartı sağlarsa 1. koşuk ,sağlamazsa 2. koşul geçerli. Aşşağıdaki gibi

                //if (filter == null)
                //{
                //    return context.Set<TEntity>().ToList();
                //}
                //else
                //{
                //    return context.Set<TEntity>().Where(filter).ToList();
                //}
            }

        }

        public TEntity GetValue(Expression<Func<TEntity, bool>> filter)
        {
            
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
