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
    internal class DepartmentConfigrations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
           builder.HasKey(d=>d.Id);
            builder.Property(d => d.Id).UseIdentityColumn(1, 1);
            builder.Property(d => d.Name).HasColumnType("varchar");
            builder.Property(d => d.ins_id).HasColumnType("integer");
            builder.Property(d=>d.hiringdate).HasColumnType("integer");
        }
    }
}
