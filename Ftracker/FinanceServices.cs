using Microsoft.EntityFrameworkCore;

namespace Ftracker;

public class FinanceService
{
    private readonly FinanceDbContext _context;

    public FinanceService(FinanceDbContext context)
    {
        _context = context;
    }

    public async Task<List<Transaction>> GetTransactionsAsync(String? descriptionFilter = null, int? categoryId = null, String? sortBy = null, bool ascending = true)
    {
        IQueryable<Transaction> query = _context.Transactions
            .AsNoTracking()
            .Include(t => t.Category);

        if (!String.IsNullOrEmpty(descriptionFilter))
        {
            query = query.Where(t => t.Description != null && t.Description.Contains(descriptionFilter, StringComparison.OrdinalIgnoreCase));
        }

        if (categoryId.HasValue)
        {
            query = query.Where(t => t.CategoryId == categoryId.Value);
        }

        if (!String.IsNullOrEmpty(sortBy))
        {
            query = sortBy.ToLower() switch
            {
                "amount" => ascending ? query.OrderBy(t => t.Amount) : query.OrderByDescending(t => t.Amount),
                "date" => ascending ? query.OrderBy(t => t.Date) : query.OrderByDescending(t => t.Date),
                "description" => ascending ? query.OrderBy(t => t.Description) : query.OrderByDescending(t => t.Description),
                _ => query
            };
        }

        return await query.ToListAsync();
    }
}
