using Api.Data.Mapping;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context
{
    public class SqlContext : DbContext
    {
        public DbSet<SchoolTask> Users { get; set; }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)  {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SchoolTask>(new SchoolTaskMap().Configure);
        }
    }
}
