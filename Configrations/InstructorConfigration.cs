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
    internal class InstructorConfigration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasColumnType("string");
        builder.Property(x => x.bouns).HasColumnType("int");
            builder.Property(x => x.address).HasColumnType("string");
            builder.Property(x => x.salary).HasColumnType("float");
            builder.Property(x => x.HourRate).HasColumnType("int");
            builder.Property(x => x.Dept_id).HasColumnType("int");



        }
    }
}
