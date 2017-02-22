//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.Entity;
//using System.Linq.Expressions;
//using CrowdfundingPlatform.Models;
//using CrowdfundingPlatform.DAL;
//using CrowdfundingPlatform.BAL;

//namespace CrowdfundingPlatform.BAL.GenericRepository
//{
//    public class GenericRepository<TEntity>  where TEntity : class
//    {
//        //  internal DbSet dbSet;
//        // internal CrowdfundingPlatformEntities context;

//        /* public GenericRepository(CrowdfundingPlatformEntities _context = null)
//         {
//             this.context = _context ?? new VivaWalletEntities();
//             this.dbSet = context.Set<TEntity>();
             
            
//         }
//         */
//        public IEnumerable<TEntity> All()
//        {
//            try
//            {
//                return context.Set<TEntity>().ToList();
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }

//        public async Task<IEnumerable<TEntity>> AllAsync()
//        {
//            try
//            {
//                return await context.Set<TEntity>().ToListAsync();
//            }
//            catch (Exception ex)
//            {

//                throw ex;
//            }

//        }

//        public void Delete(TEntity entity, bool save = true)
//        {
//            try
//            {
//                context.Set<TEntity>().Remove(entity);

//                if (save)
//                    context.SaveChanges();
//            }
//            catch (Exception)
//            {
//                throw;
//            }

//        }

//        public async Task DeleteAsync(TEntity entity, bool save = true)
//        {
//            context.Set<TEntity>().Remove(entity);

//            if (save)
//                await context.SaveChangesAsync();
//        }

//        public void Dispose()
//        {
//            context.Dispose();
//        }

//        public TEntity FindById(long id)
//        {
//            try
//            {
//                return context.Set<TEntity>().Find(id);
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//        }

//        public async Task<TEntity> FindByIdAsync(long id)
//        {
//            try
//            {
//                return await context.Set<TEntity>().FindAsync(id);
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//        }

//        public void Insert(TEntity entity, bool save = true)
//        {
//            try
//            {
//                context.Set<TEntity>().Add(entity);

//                if (save)
//                    context.SaveChanges();
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }

//        }

//        public async Task InsertAsync(TEntity entity, bool save = true)
//        {
//            try
//            {
//                context.Set<TEntity>().Add(entity);

//                if (save)
//                    await context.SaveChangesAsync();
//            }
//            catch (Exception)
//            {
//                throw;
//            }

//        }

//        public IEnumerable<TEntity> SearchFor(Expression<Func<TEntity, bool>> predicate)
//        {
//            try
//            {
//                return context.Set<TEntity>().Where(predicate).ToList();
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }

//        }

//        public async Task<IEnumerable<TEntity>> SearchForAsync(Expression<Func<TEntity, bool>> predicate)
//        {
//            try
//            {
//                return await context.Set<TEntity>().Where(predicate).ToListAsync();
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//        }

//        public void Update(TEntity entity, bool save = true)
//        {
//            dbSet.Attach(entity);

//            context.Entry<TEntity>(entity).State = EntityState.Modified;

//            if (save)
//                context.SaveChanges();
//        }
//    }
//}

    

