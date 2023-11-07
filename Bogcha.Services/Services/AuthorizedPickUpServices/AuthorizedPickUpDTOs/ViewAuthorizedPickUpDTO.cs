using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogcha.Infrastructure.Services.AuthorizedPickUpServices.AuthorizedPickUpDTOs;
public class ViewAuthorizedPickUpDTO
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
}
