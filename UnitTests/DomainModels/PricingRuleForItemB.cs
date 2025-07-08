namespace UnitTests.DomainModels;

public class PricingRuleForItemB : IPricingRule
{
    public int GetPrice(List<IBasketItem> basketItems)
    {
        var count = basketItems.Find(item => item.ItemType == ItemType.B)?.Count ?? 0;
        var inBatchesOfTwo = count / 2;
        var remainder = count % 2;
        var totalPrice = (inBatchesOfTwo * 45) + (remainder * 30);
        
        return totalPrice;
    }
}