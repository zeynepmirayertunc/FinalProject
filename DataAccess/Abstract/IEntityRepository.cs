using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{

    //Generic constraint
    //class : referans tip olabilir demek.
    // IEntity : IEntitiy olabilir veya IEntitiy implemente eden bir nesne de olabilir.
    // new() : new'lenebilir olmalı.
    public interface IEntityRepository<T> where T:class,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);

        T Get(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
