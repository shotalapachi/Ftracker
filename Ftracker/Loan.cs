// ReSharper disable All
using System.Diagnostics.CodeAnalysis;

namespace Ftracker;

public record Loan
{
    public int Id { get; init; }
    public required decimal StartingAmount { get; set; }
    public required decimal RemainingAmount { get; set; }
    public required DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public required String Borrower { get; set; }
    public required String Currency { get; set; }
    public required Status LoanStatus { get; set; }
};
public enum Status
{
    Active,
    PaidOff,
    Overdue
}