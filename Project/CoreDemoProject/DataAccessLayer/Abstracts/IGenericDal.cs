﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstracts
{
    public interface IGenericDal<T> where T : class
    {
        ICollection<T> GetAll();
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);
    }
}
