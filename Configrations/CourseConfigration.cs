using EF_SESSION_1_ASSIGNMENT.entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_SESSION_1_ASSIGNMENT.Configrations
{
    internal class CourseConfigration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Duration).HasColumnType("int");
            builder.Property(c=>c.Name).HasColumnType("string");
            builder.Property(c=>c.Description).HasColumnType("string");
            builder.Property(c => c.Top_id).HasColumnType("int");
        }
    }
}
