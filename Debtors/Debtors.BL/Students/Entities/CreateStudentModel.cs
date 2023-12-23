using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debtors.BL.Students.Entities;

public class CreateStudentModel
{
    public required int StudentId { get; set; }
    public required string Name { get; set; }
    public required int Course { get; set; }

    public required string Email { get; set; }
    public required string PasswordHash { get; set; }
}
