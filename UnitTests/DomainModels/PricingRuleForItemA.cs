namespace UnitTests.DomainModels;

public class PricingRuleForItemA : IPricingRule
{
    public int GetPrice(List<IBasketItem> basketItems)
    {
        var count = basketItems.Find(item => item.ItemType == ItemType.A)?.Count ?? 0;
        var inBatchesOfThree = count / 3;
        var remainder = count % 3;
        var totalPrice = (inBatchesOfThree * 130) + (remainder * 50);
        
        return totalPrice;
    }
}