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
    internal class Course_instConfigration : IEntityTypeConfiguration<Course_inst>
    {
        public void Configure(EntityTypeBuilder<Course_inst> builder)
        {
            
            builder.Property(c=>c.inst_id).HasColumnType("integer");
            builder.Property(c => c.Coure_id).HasColumnType("integer");
            builder.Property(c=>c.evaluate).HasColumnType("string");

        }
    }
}
