// ReSharper disable All
namespace Ftracker;

public record Account
{
    public required int Id { get; init; }
    public required String Name { get; set; }
    public required String Iban { get; set; }
    public required String Currency { get; set; }
}