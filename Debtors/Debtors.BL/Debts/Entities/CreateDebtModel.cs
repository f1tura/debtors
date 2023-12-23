using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debtors.BL.Debts.Entities;

internal class CreateDebtModel
{
    public required DateTime DebtDay { get; set; }
    public required Guid UserId { get; set; }
    public virtual required ICollection<Guid> ScootersId { get; set; }
}
