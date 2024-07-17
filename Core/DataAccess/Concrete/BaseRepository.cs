using Entity.Abstract;
using Entity.Concrete;
using Entity.DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Concrete
{
    public class BaseRepository<TEntity, TContext> : IBaseRepository<TEntity>
    where TEntity : class, IEntity, new()
    where TContext : DbContext, new()
    {
        public void Add(Phone phone)
        {
            using var context = new TContext();//Buni biz gonderecik

            var added = context.Entry(phone);
            added.State = EntityState.Added;
            context.SaveChanges();
            /* context.Add(phone);
             context.SaveChanges();//Yeni formasi budur*/
        }

        public void Delete(Phone phone)
        {
            using var context = new TContext();
            var deleted = context.Entry(phone);
            deleted.State = EntityState.Modified;//Deleted olands database-den silinir,amma modified olanda ise ad olaraq silir amma data qalir
            context.SaveChanges();
            /* context.Remove(phone);
             context.SaveChanges();*/
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using var context = new TContext();//var tipinden context
            return context.Set<TEntity>().SingleOrDefault(filter);
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter)
        {
            using TContext context = new TContext();//TContext tipinden context
            return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
        }

        public void Update(Phone phone)
        {
           using var context = new TContext(); 
           var updated = context.Entry(phone);
           updated.State = EntityState.Modified;
           context.SaveChanges();
        }
    }
}