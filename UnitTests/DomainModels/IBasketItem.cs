namespace UnitTests.DomainModels;

public interface IBasketItem
{
    public ItemType ItemType { get; }
    public int GetPrice();
    public int Count { get; set; }
}