using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Debtors.DataAccess.Entities;

[Table("debts")]


public class DebtEntity : BaseEntity
{
    public DateTime DebtDay { get; set; }
    public DebtEntity Student { get; set; }
    public SubjectEntity Subject { get; set; }

}

