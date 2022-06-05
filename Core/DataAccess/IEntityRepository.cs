using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class,IEntity, new()
    {
        public List<T> GetAll(Expression<Func<T, bool>> filter = null);

        public T Get(Expression<Func<T, bool>> filter = null);

        public void Add(T Entity);
        public void Update(T Entity);
        public void Delete(T Entity);

    }
}
