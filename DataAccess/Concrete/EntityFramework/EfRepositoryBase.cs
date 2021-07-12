using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRepositoryBase<TEntity, TContext> : 
        IEntityRepository<TEntity> where 
        TEntity:class,IEntity,new()
        where TContext:SchoolDBContext,new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public bool Login(string username, string password)
        {

            using (TContext context = new TContext())
            {
                
                //try
                //{
                    var user = (from p in context.Persons
                            join u in context.Users
                            on p.Id equals u.PersonId
                            where p.IsActive == false &&
                                u.UserName == username &&
                                u.Password == password &&
                                u.IsActive == true
                            select p).FirstOrDefault();
                    if (user != null)
                    {
                        return true;
                    }
                //}
                //catch
                //{

                    
                //}
                
                return false;
            }
                
        }
    }
}
