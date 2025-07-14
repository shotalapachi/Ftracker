namespace Ftracker;

public record Transaction
{
    public int Id { get; init; }
    public required decimal Amount { get; init; }
    public string? Description { get; init; }
    public required DateTime Date { get; init; }
    public int CategoryId { get; init; }
    public Category? Category { get; init; }
    public bool IsExpense {get; init; }
};