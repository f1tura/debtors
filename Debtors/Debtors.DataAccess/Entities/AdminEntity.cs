
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Debtors.DataAccess.Entities;

[Table("admins")]
public class AdminEntity : BaseEntity
{
    public string Name { get; set; }
}
        
