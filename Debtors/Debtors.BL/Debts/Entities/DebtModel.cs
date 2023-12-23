using Debtors.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debtors.BL.Debts.Entities;

public class DebtModel
{
    public required DateTime DebtDay { get; set; }

    public required Guid StudentId { get; set; }

    public required Guid SubjectId { get; set; }
}
