using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogcha.DataAccess.Repositories.ClassInfoRepositories
{
    public interface IClassInfoRepository
    {
        public ValueTask<bool> CreateAsync(ClassInfo classInfo);
        public ValueTask<bool> UpdateAsync(int id, ClassInfo classInfo);
        public ValueTask<bool> DeleteAsync(int id);
        public ValueTask<bool> GetByIdAsync(int id);
        public ValueTask<IEnumerable<ClassInfo>> GetAllAsync();
    }
}
