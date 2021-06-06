using CleanArchMvc.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Infra.Data.EntitiesConfiguration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //Define as primary key
            builder.HasKey(t => t.Id);

            //Define max length and mandatory, because default is nvarchar(max) and nullable is true
            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();

            //Populate initial data
            builder.HasData(
                new Category(1, "School Accessories"),
                new Category(2, "Eletronics"),
                new Category(3, "Office Paper")
            );

        }
    }
}
