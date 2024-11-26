﻿using C_Bootcamp_301.DataAccessLayer.Abstract;
using C_Bootcamp_301.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Bootcamp_301.DataAccessLayer.Repositeries
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        BootcampContext context = new BootcampContext();
        private readonly DbSet<T> _object;

        public GenericRepository()
        {
            _object=context.Set<T>();
        }
        public void Delete(T entity) 
        {
            
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
           return _object.ToList();
        }

        public T GetById(int id)
        {
           return _object.Find(id);
        }

        public void Insert(T entity)
        {
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
