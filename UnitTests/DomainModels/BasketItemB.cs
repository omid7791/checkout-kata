namespace UnitTests.DomainModels;

public class BasketItemB : IBasketItem
{
    public ItemType ItemType => ItemType.B;

    public int GetPrice()
    {
        var inBatchesOfTwo = Count / 2;
        var remainder = Count % 2;
        var totalPrice = (inBatchesOfTwo * 45) + (remainder * 30);
        
        return totalPrice;
    }

    public int Count { get; set; }
}