using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogcha.Domain.Entities
{
    public class Attendance
    {
        public int Id { get; set; }
        public string ChId { get; set; }
        public DateTime? SignIn_Time { get; set; }
        public DateTime? SignOut_Time { get; set; }
        [ForeignKey(nameof(ChId))]
        public Student Studnet { get; set; }

    }
}
