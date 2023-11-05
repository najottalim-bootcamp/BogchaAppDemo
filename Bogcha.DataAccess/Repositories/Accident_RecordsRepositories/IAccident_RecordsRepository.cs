using Bogcha.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogcha.DataAccess.Repositories.Accident_RecordsRepositories
{
    public interface IAccident_RecordsRepository
    {
        public ValueTask<bool> CreateAsync(Accident_Records)
    }
}
