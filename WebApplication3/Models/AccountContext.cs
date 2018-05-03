using System.Data.Entity;

namespace WebApplication3.Models
{
    public class AccountContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Ledger> Ledgers { get; set; }
    }
}