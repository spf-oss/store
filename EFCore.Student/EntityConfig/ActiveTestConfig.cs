using EFCore.Student.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Student.EntityConfig
{
    internal class ActiveTestConfig : IEntityTypeConfiguration<ActiveTest>
    {
        public void Configure(EntityTypeBuilder<ActiveTest> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(p => p.IsActive).HasDefaultValue(true);
        }
    }
}
