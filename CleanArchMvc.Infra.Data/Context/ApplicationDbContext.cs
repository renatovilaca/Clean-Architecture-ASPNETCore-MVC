using CleanArchMvc.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchMvc.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        //Define string connection EF Core
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }


        //Code-First ORM mapping
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        //Entity configurations for Fluent API 
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
