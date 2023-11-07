using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogcha.Infrastructure.Services.BlackListServices.BlackListDTOs;
public class ViewBlackListDTO
{
    public string CHId { get; set; }
    public string ChFName { get; set; }
    public string ChLName { get; set; }
    public string? UnauthFName { get; set; }
    public string? UnauthLName { get; set; }
    public string? gender { get; set; }
    public string? Passport { get; set; }
    public string? strAddress { get; set; }
    public string? city { get; set; }
    public string? state { get; set; }
    public string? zipCode { get; set; }
    public string? phoneNo { get; set; }
}
