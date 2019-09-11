﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace WebTemplate.Service.Interface
{
    public interface IService<T> where T : class
    {
        List<T> GetList(Expression<Func<T, bool>> wherePredicate);

        T GetInfo(Expression<Func<T, bool>> wherePredicate);

        void Create(T entity);

        void Delete(Expression<Func<T, bool>> wherePredicate);

        void Update(T entity);

        void SaveChange();
    }
}
