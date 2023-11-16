using System.ComponentModel.DataAnnotations.Schema;

namespace Bogcha.Domain.Entities
{
    public class AuthorizedPickUp
    {
        public string ChId { get; set; }
        public string AuthFName { get; set; }
        public string AuthLName { get; set; }
        public string gender { get; set; }
        public string Passport { get; set; }
        public string strAddress { get; set; }
        public string city { get; set; }
        public string region { get; set; }
        public string zipCode { get; set; }
        public string phoneNo { get; set; }

        public virtual Student Studnet { get; set; }
    }
}
