﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Bootcamp_301.DataAccessLayer.Abstract
{
    public interface IGenericDal <T> where T : class
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(int entity);
        List<T> GetAll();
        T GetById(int id);
    }
}
