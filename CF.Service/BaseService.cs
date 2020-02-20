using CF.Dal.Context;
using CF.Model;
using CF.Model.Enums;
using CF.Service.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CF.Service
{
    public class BaseService<T> : ICoreService<T> where T : BaseEntity
    {
        private static CFContext _db;

        public static CFContext db
        {
            get
            {
                if (_db == null)
                {
                    _db = new CFContext();
                }
                return _db;
            }
        }

        public void Add(T item)
        {
            db.Set<T>().Add(item);
        }

        public void AddList(List<T> item)
        {
            db.Set<T>().AddRange(item);
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().Any(exp);
        }

        public List<T> GetDeleted()
        {
            return db.Set<T>().Where(x => x.Status == Status.Deleted).ToList();
        }

        public List<T> GetActive()
        {
            return db.Set<T>().Where(x => x.Status != Status.Deleted).ToList();
        }

        public List<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public T GetByDefault(Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().Where(exp).FirstOrDefault();
        }

        public T GetById(Guid Id)
        {
            return db.Set<T>().Find(Id);
        }

        public void Remove(T item)
        {
            item.Status = Status.Deleted;
            Update(item);
        }

        public int Save()
        {
            if (db.SaveChanges() > 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public void Update(T item)
        {
            db.Entry(db.Set<T>().Find(item.Id)).CurrentValues.SetValues(item);
            Save();
        }
    }
}
