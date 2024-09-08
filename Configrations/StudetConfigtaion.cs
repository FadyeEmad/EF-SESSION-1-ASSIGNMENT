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
    internal class StudetConfigtaion : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnType("integer").UseIdentityColumn(1, 1);
            builder.Property(x => x.Fname).HasColumnType("varchar");
            builder.Property(x => x.Lname).HasColumnType("varchar");
            builder.Property(x => x.Address).HasColumnType("varchar");
            builder.Property(x => x.Age).HasColumnType("integer");
            builder.Property(x => x.Dep_id).HasColumnType("integer");

        }
    }
}
