namespace UnitTests.DomainModels;

public class BasketItemC : IBasketItem
{
    public ItemType ItemType => ItemType.C;

    public int GetPrice()
    {
        return 20;
    }

    public int Count { get; set; }
}