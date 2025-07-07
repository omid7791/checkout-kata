namespace UnitTests.DomainModels;

public class BasketItemA : IBasketItem
{
    public ItemType ItemType => ItemType.A;

    public int GetPrice()
    {
        var inBatchesOfThree = Count / 3;
        var remainder = Count % 3;
        var totalPrice = (inBatchesOfThree * 130) + (remainder * 50);
        
        return totalPrice;
    }

    public int Count { get; set; }
}