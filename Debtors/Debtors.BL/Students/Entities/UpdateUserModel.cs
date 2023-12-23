using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debtors.BL.Students.Entities;

public class UpdateUserModel
{
    
    public string? Name { get; set; }
    public int? Course { get; set; }

    public string? Email { get; set; }
    public string? PasswordHash { get; set; }
    
}
