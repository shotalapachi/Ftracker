namespace Ftracker;

public record Account
{
    public required int Id { get; init; }
    public required String Name { get; init; }
    public required String Iban { get; init; }
    public required String Currency { get; init; }
}