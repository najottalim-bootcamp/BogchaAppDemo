using Bogcha.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogcha.DataAccess.Repositories.AssessmentRecNurseryRepositories
{
    public interface IAssessmentRecNurseryRepository
    {
        public ValueTask<bool> CreateAsync(AssessmentRecNursery assessmentRecKnursery);
        public ValueTask<bool> UpdateAsync(int id, AssessmentRecNursery assessmentRecnursery);
        public ValueTask<bool> DeleteAsync(int id);
        public ValueTask<bool> GetByIdAsync(int id);
        public ValueTask<IEnumerable<AssessmentRecNursery>> GetAllAsync();
    }
}
