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
    internal class Stud_coureConfigration : IEntityTypeConfiguration<Stud_course>
    {
        public void Configure(EntityTypeBuilder<Stud_course> builder)
        {
            builder.Property(s=>s.stud_id).HasColumnType("int");
            builder.Property(s => s.Course_id).HasColumnType("int");
            builder.Property(s => s.Grade).HasColumnType("int");

        }
    }
}
