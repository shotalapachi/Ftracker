// ReSharper disable All
namespace Ftracker;

public record Transaction
{
    public int Id { get; init; }
    public required decimal Amount { get; set; }
    public string? Description { get; set; }
    public required DateTime Date { get; set; }
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
    public bool IsExpense {get; set; }
    public bool IsDeleted { get; set; } = false;
};