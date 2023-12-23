using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Debtors.DataAccess.Entities;

[Table("students")]
public class DebtEntity : BaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int StudentId { get; set; }
    public string Name { get; set; }
    public int Course { get; set; }

    [EmailAddress]
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public virtual ICollection<DebtEntity> Debts { get; set; }
}



