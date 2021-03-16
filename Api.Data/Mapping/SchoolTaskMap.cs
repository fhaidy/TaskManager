using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Data.Mapping
{
    public class SchoolTaskMap : IEntityTypeConfiguration<SchoolTask>
    {
        public void Configure(EntityTypeBuilder<SchoolTask> builder)
        {
            builder.ToTable("SchoolTask");
            builder.HasKey(task => task.Id);
            builder.Property(task => task.Name)
                .IsRequired()
                .HasMaxLength(60);
            builder.Property(task => task.Description)
                .IsRequired();
            builder.Property(task => task.Students)
                .IsRequired();
            builder.Property(task => task.Subject)
                .IsRequired();
            builder.Property(task => task.DeliveryDate)
                .IsRequired();
        }
    }
}
