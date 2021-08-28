using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Training_Project__List_of_expenses_and_List_of_debt_obligations_.Models;

namespace Training_Project__List_of_expenses_and_List_of_debt_obligations_.Domain
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Item> ItemsTable { get; set; }
    }
}
