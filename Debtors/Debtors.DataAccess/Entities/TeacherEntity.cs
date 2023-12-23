using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Debtors.DataAccess.Entities;

[Table("teachers")]

internal class TeacherEntity : BaseEntity
{
    public string Name { get; set; }

    [EmailAddress]
    public string Email { get; set; }
    public virtual ICollection<SubjectEntity> Subjects { get; set; }

}


