using Entity.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DataAccess.Abstract
{
    public interface IBaseRepository <T> where T : class , IEntity , new()
    {
        void Add(Phone phone);
        void Update(Phone phone);
        void Delete(Phone phone);
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T,bool>>filter);
    }
}
