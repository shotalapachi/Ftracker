// ReSharper disable All
namespace Ftracker;
using Microsoft.EntityFrameworkCore;

public class FinanceDbContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Loan> Loans { get; set; }
    
    public FinanceDbContext(DbContextOptions<FinanceDbContext> options) : base(options) { }
}