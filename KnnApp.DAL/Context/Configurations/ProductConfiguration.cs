using KnnApp.Core.Entityes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnnApp.DAL.Context.Configurations;
internal class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(p => p.ProductName)
            .IsRequired()
            .HasMaxLength(20);
        builder.Property(p => p.Description)
            .IsRequired()
            .HasMaxLength(50);

    }
}
