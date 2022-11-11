using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using u1.DbModels;

namespace u1.DbData
{
    public class AbstractContext : DbContext
    {
        public DbSet<AbstractEnt> AbstractTables { get; set; } = null!;
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=EFEasyExample;Trusted_Connection=True;");
        }
    }

}
