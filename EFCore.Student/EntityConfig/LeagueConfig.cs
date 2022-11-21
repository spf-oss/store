using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Student
{
    public class LeagueConfig : IEntityTypeConfiguration<League>
    {
        public void Configure(EntityTypeBuilder<League> builder)
        {
            _ = builder.HasKey(m => m.ID);

            _ = builder.HasMany(m => m.Clubs).WithOne(m => m.League);
        }
    }
}
