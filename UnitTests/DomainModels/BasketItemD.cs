namespace UnitTests.DomainModels;

public class BasketItemD : IBasketItem
{
    public ItemType ItemType => ItemType.D;

    public int GetPrice()
    {
        return 15;
    }

    public int Count { get; set; }
}