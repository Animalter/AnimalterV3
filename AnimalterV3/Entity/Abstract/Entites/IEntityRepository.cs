using System.Linq.Expressions;

namespace AnimalterV3.Entity.Abstract.Entites
{
    public interface IEntityRepository<T> where T : class,IEntity
    {
        //CRUD
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        T GetValue(Expression<Func<T, bool>> filter);//şartlı listleme
        List<T> GetAll(Expression<Func<T,bool>>filter=null);

        

    
    
    }
}