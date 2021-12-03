using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using ECommerceApp.Models;
using ECommerceApp.Repository.Abstract;

namespace ECommerceApp.Repository.Concrete
{
    public class SupplierBusiness : IDatabaseBusiness<Supplier>
    {
        public void Add(Supplier entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Supplier entity)
        {
            throw new NotImplementedException();
        }

        public Supplier Get(int id)
        {
            throw new NotImplementedException();
        }

        public Supplier Get(Expression<Func<Supplier, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public List<Supplier> GetAll()
        {
            using (var db = new NorthwindEntities())
            {
                return db.Suppliers.ToList();
            }
        }

        public List<Supplier> GetAll(Expression<Func<Supplier, bool>> expression)
        {
            using (var db = new NorthwindEntities())
            {
                return db.Suppliers.Where(expression).ToList();
            }
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Supplier entity)
        {
            throw new NotImplementedException();
        }
    }
}
