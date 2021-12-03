using ECommerceApp.Models;
using ECommerceApp.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace ECommerceApp.Repository.Concrete
{
    public class ProductBusiness : IDatabaseBusiness<Products>
    {
        bool Debug = true;

        public void Add(Products entity)
        {
            //using ile garbage collector yapıyoruz clası otomatik sonlandırıp rami boşaltıyor
            //using (var db = new NorthwindEntities){
            //db.Products.Add(entity);
            //db.Entry(entity).State = EntityState.Added;
            //db.SaveChanges();}
            throw new NotImplementedException();   
        }

        public void Edit(Products entity)
        {
            //using (var db = new NorthwindEntities){db.Products.Add(entity);
            //db.Entry(entity).State = EntityState.Modified;
            //db.SaveChanges();}
            throw new NotImplementedException();
        }

        public Products Get(int id)
        {
            //using (var db = new NorthwindEntities){
            //return db.Products.Find(id);}
            throw new NotImplementedException();
        }

        public Products Get(Expression<Func<Products, bool>> expression)
        {
            //using (var db = new NorthwindEntities){
            //return db.Products.Where(expression).FirstOrderDefault();}
            throw new NotImplementedException();
        }

        public List<Products> GetAll()
        {
            //using (var db = new NorthwindEntities){
            //return db.Products.toList();}
            throw new NotImplementedException();
        }

        public List<Products> GetAll(Expression<Func<Products, bool>> expression)
        {
            //using (var db = new NorthwindEntities){
            //return db.Products.Where(expression).Find(id);}
            throw new NotImplementedException();
            //if (Debug == true)
            //{
            //    using (var db = FakeDataBase.)
            //    {

            //    }
            //}
        }

        public void Remove(int id)
        {
            //using (var db = new NorthwindEntities){
            //var entity = db.Products.Find(id);
            //db.Products.Remove(entity);
            //db.Entry(entity).State = EntityState.Deleted;
            //db.SaveChanges();}
            throw new NotImplementedException();
        }

        public void Remove(Products entity)
        {
            //using (var db = new NorthwindEntities){
            //db.Products.Remove(entity);
            //db.Entry(entity).State = EntityState.Deleted;
            //db.SaveChanges();}
            throw new NotImplementedException();
        }
    }
}