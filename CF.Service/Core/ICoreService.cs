using CF.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CF.Service.Core
{
    public interface ICoreService<T> where T : BaseEntity
    {
        void Add(T item);
        void AddList(List<T> item);
        void Update(T item);
        void Remove(T item);
        T GetById(Guid Id);
        T GetByDefault(Expression<Func<T, bool>> exp);
        List<T> GetDeleted();
        List<T> GetActive();
        List<T> GetAll();
        bool Any(Expression<Func<T, bool>> exp);
        int Save();
    }
}
