using ECommerceApp.Models;
using ECommerceApp.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace ECommerceApp.Repository.Concrete
{
    public class CategoryBusiness : IDatabaseBusiness<Categories>
    {
        public void Add(Categories entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Categories entity)
        {
            throw new NotImplementedException();
        }

        public Categories Get(int id)
        {
            throw new NotImplementedException();
        }

        public Categories Get(Expression<Func<Categories, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public List<Categories> GetAll()
        {
            throw new NotImplementedException();
            //using(var db = new NorthwindEntities()) 
            //{
            //    return db.Categories.ToList();
            //}
        }

        public List<Categories> GetAll(Expression<Func<Categories, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Categories entity)
        {
            throw new NotImplementedException();
        }
    }
}