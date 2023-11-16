using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogcha.DataAccess.Configurations;
internal class ParentsTypeConfiguration : IEntityTypeConfiguration<Parents>
{
    public void Configure(EntityTypeBuilder<Parents> builder)
    {
        builder.HasKey(x => x.ChId);
    }
}
