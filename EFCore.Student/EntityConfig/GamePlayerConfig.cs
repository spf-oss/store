using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Student
{
    internal class GamePlayerConfig : IEntityTypeConfiguration<GamePlayer>
    {
        public void Configure(EntityTypeBuilder<GamePlayer> builder)
        {
            _ = builder.HasKey(m => m.ID);

            _ = builder.HasMany(m => m.Players).WithOne();

            _ = builder.HasMany(m => m.Games).WithOne();
        }
    }
}
