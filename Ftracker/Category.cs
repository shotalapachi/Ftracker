namespace Ftracker;

public record Category
{
    public int Id { get; init; }
    public required String Name { get; init; }
};