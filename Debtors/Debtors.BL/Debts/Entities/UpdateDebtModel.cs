using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debtors.BL.Debts.Entities;

internal class UpdateDebtModel
{
    public  DateTime? DebtDay { get; set; }
    public required Guid? StudentId { get; set; }
    public required Guid? SubjectId { get; set; }
}
