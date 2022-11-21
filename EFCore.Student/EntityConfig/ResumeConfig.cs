using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Student
{
    public class ResumeConfig : IEntityTypeConfiguration<Resume>
    {
        public void Configure(EntityTypeBuilder<Resume> builder)
        {
            _ = builder.HasKey(m => m.ID);

            _ = builder.HasOne(m => m.Player).WithOne().HasForeignKey<Resume>(m => m.PlayerId);
        }
    }
}
