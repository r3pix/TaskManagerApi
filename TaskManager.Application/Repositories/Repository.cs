using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Domain.Entities;
using TaskManagerPersistance;

namespace TaskManager.Application.Repositories
{
    public class Repository<TEntity> where TEntity : BaseEntity
    {
        private readonly TaskManagerDbContext _dbContext;
        private DbSet<TEntity> _entities;

        public Repository(TaskManagerDbContext dbContext)
        {
            _dbContext = dbContext;
            _entities = dbContext.Set<TEntity>();
        }

        public async Task<TEntity> Add(TEntity entity)
        {
            await _entities.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<int> Commit() =>
            await _dbContext.SaveChangesAsync();

        //edit action is not necessary but


    }
}
