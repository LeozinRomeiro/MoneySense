using MoneySense.Core.Domain.Enums;
using MoneySense.Core.Domain.ValueObjects;
using MoneySense.Core.Shared.Entities;

namespace MoneySense.Core.Domain.Entities;

public class Category : Entity
{
    public string Title { get; }
    public Description Description { get; }
    public string Icon { get;} = "";
    public ECategoryType Type { get; }
    public IReadOnlyCollection<Transaction> Transactions { get { return _transactions.ToArray();}}
    private IList<Transaction> _transactions;
    public DateTime LastUpdateDate { get; private set; }
    public Category(string title, Description description, string icon, ECategoryType type = ECategoryType.Income)
    {
        Title = title;
        Description = description;
        Icon = icon;
        Type = type;
        _transactions = new List<Transaction>();
        LastUpdateDate = DateTime.Now;
    }
}
