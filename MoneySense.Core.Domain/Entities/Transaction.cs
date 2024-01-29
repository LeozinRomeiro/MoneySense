using MoneySense.Core.Domain.ValueObjects;
using MoneySense.Core.Shared.Entities;
using Flunt.Validations;
using Flunt.Notifications;

namespace MoneySense.Core.Domain.Entities;

public class Transaction : Entity
{
    public Category? Category { get; private set; }
    public Coin Amount { get; set; }
    public Description Description { get; set; }
    public DateTime Date { get; }
    public DateTime? CreateDate { get;}
    public Transaction(Coin amount, Description description, DateTime date)
    {
        Amount = amount;
        Description = description;
        Date = date;
        CreateDate = DateTime.Now;
    }
    public void AddCategory(Category category)
    {
        AddNotifications(new Contract<Notification>().Requires());
        Category = category;
    }
}
