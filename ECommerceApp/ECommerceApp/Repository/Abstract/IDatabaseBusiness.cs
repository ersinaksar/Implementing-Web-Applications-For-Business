using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Repository.Abstract
{
    //<T> ile generic yaptık farlı türde objelerle kullanabilmeke için
    //normalde internal fakat public yapıyoruz başka yerlerden de kullanmak için
    public interface IDatabaseBusiness<T> where T : class
    {
        T Get(int id);
        T Get(Expression<Func<T, bool>> expression); //way of passing queries to method
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void Remove(int id);
        void Remove(T entity);
        void Edit(T entity);
    }
}
