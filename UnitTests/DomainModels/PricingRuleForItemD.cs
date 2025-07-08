namespace UnitTests.DomainModels;

public class PricingRuleForItemD : IPricingRule
{
    public int GetPrice(List<IBasketItem> basketItems)
    {
        var count = basketItems.Find(item => item.ItemType == ItemType.D)?.Count ?? 0;
        var totalPrice = count * 15;
        
        return totalPrice;
    }
}