using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogcha.DataAccess.Configurations;
public class ClassInfoTypeConfiguration : IEntityTypeConfiguration<ClassInfo>
{
    public void Configure(EntityTypeBuilder<ClassInfo> builder)
    {
        builder.HasKey(x => x.ClassId);
    }
}
