using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debtors.DataAccess
{
    public class Test
    {
        public void test(IDbContextFactory<DebtorsDbContext> contextFactory)
        {
            using var context = contextFactory.CreateDbContext();
            context.Users.Add(new Entities.DebtEntity() { });
            context.Users.Where(x => x.Id == 1);
            context.SaveChanges();
        }
    }
}
