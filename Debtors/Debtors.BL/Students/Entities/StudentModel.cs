using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debtors.BL.Students.Entities;


public class StudentModel
{
    
    public required int StudentId { get; set; }
    public required int Name { get; set; }
    public required int Course { get; set; }

    public  required int Email { get; set; }
    public required int PasswordHash { get; set; }
    public virtual ICollection<DebtEntity> Debts { get; set; }
}
