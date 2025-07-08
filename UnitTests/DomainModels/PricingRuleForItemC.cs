namespace UnitTests.DomainModels;

public class PricingRuleForItemC : IPricingRule
{
    public int GetPrice(List<IBasketItem> basketItems)
    {
        var count = basketItems.Find(item => item.ItemType == ItemType.C)?.Count ?? 0;
        var inBatchesOfTwo = count / 2;
        var remainder = count % 2;
        var totalPrice = (inBatchesOfTwo * 15) + (remainder * 20);
        
        return totalPrice;
    }
}