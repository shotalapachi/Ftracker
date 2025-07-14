using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace Ftracker;

public class FinanceDbContextFactory  : IDesignTimeDbContextFactory<FinanceDbContext>
{
    public FinanceDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<FinanceDbContext>();
        
        optionsBuilder.UseSqlite("Data Source=Finance.db");
        return new FinanceDbContext(optionsBuilder.Options);
    }
}