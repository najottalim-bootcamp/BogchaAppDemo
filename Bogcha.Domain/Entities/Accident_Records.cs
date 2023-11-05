using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogcha.Domain.Entities
{
    public class Accident_Records
    {
        
        public int AccNo { get; set; }
        public string ChId { get; set; }
        public DateTime? AccidentDate { get; set; }
        public string? TypeOfAccident { get; set; }
        public string? Location { get; set; }
        public string? FirstAid { get; set; }
    }
}
