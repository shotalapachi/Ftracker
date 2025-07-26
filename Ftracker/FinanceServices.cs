namespace Ftracker;

public class FinanceService
{
    private readonly FinanceDbContext _context;

    public FinanceService(FinanceDbContext context)
    {
        _context = context;
    }
}
