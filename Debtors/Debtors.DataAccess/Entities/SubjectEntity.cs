using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Debtors.DataAccess.Entities;

[Table("subjects")]


internal class SubjectEntity : BaseEntity
{
    public string Title { get; set; }
    public TeacherEntity Teacher { get; set; }
    public string Description { get; set; }

    public virtual ICollection<DebtEntity> Debts { get; set; }

}


