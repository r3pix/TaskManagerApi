using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Domain.Entities;
using TaskManager.Persistance.Configuration;

namespace TaskManagerPersistance
{
    public class TaskManagerDbContext : DbContext
    {
        public DbSet<Identity> Identities { get; set; } 
        public DbSet<Category> Categories { get; set; }
        public DbSet<TaskManager.Domain.Entities.Task> Tasks { get; set; }
        public DbSet<User> Users { get; set; }

        public TaskManagerDbContext(DbContextOptions<TaskManagerDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BaseEntityCongiration<,>).Assembly);
        }
    }
}
