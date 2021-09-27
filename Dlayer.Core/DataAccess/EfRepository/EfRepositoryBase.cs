﻿
using Dlayer.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dlayer.Core.DataAccess.EfRepository
{
    public class EfRepositoryBase<T> : IEntityRepository<T>
         where T : class, new()
     {
        private readonly FakeStoreContext _context;
        public EfRepositoryBase(FakeStoreContext context)
        {
            _context = context;
        }
        public async Task Add(T entity)
        {
             
                var addedEntity = _context.Entry(entity);
                addedEntity.State = EntityState.Added;
                await _context.SaveChangesAsync();

        }

        public async Task Delete(T entity)
        {
         
                var deletedEntity= _context.Entry(entity);
                deletedEntity.State = EntityState.Added;
                await _context.SaveChangesAsync();
           
        }

        public  async Task<T> Get(Expression<Func<T, bool>> filter)
        {
           
                return await _context.Set<T>().FirstOrDefaultAsync(filter);    
        }

        public async Task<List<T>> GetList(Expression<Func<T, bool>> filter = null)
        {
            return filter == null ? await _context.Set<T>().ToListAsync() :
                                 await _context.Set<T>().Where(filter).ToListAsync();
        }

        public async Task Update(T entity)
        {

                var modifiedEntity = _context.Entry(entity);
                modifiedEntity.State = EntityState.Modified;
                await _context.SaveChangesAsync();
            
        }
    }
}
