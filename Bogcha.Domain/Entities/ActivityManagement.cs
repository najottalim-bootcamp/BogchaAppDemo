using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogcha.Domain.Entities
{
    public class ActivityManagement
    {
        
        public int Id { get; set; }
        public string Time { get; set; }
        public string Task { get; set; }
        public string Led_by { get; set; }
    }
}
