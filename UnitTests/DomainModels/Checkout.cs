namespace UnitTests.DomainModels;

public class Checkout : ICheckout
{
    private readonly List<IPricingRule> _pricingRules;
    private readonly List<IBasketItem> _basketItems = [];

    public Checkout(List<IPricingRule>  pricingRules)
    {
        _pricingRules = pricingRules;
    }

    public Checkout()
    {
        _pricingRules = [];
    }
    
    public void Scan(string item)
    {
        switch (item)
        {
            case "A":
                if (_basketItems.All(basketItem => basketItem.ItemType != ItemType.A))
                {
                    _basketItems.Add(new BasketItemA { Count = 1 });
                }
                else
                {
                    _basketItems.Find(basketItem => basketItem.ItemType == ItemType.A)!.Count++;
                }

                break;
            case "B":
                if (_basketItems.All(basketItem => basketItem.ItemType != ItemType.B))
                {
                    _basketItems.Add(new BasketItemB { Count = 1 });
                }
                else
                {
                    _basketItems.Find(basketItem => basketItem.ItemType == ItemType.B)!.Count++;
                }
                
                break;
            case "C":
                if (_basketItems.All(basketItem => basketItem.ItemType != ItemType.C))
                {
                    _basketItems.Add(new BasketItemC { Count = 1 });
                }
                else
                {
                    _basketItems.Find(basketItem => basketItem.ItemType == ItemType.C)!.Count++;
                }
                
                break;
            case "D":
                if (_basketItems.All(basketItem => basketItem.ItemType != ItemType.D))
                {
                    _basketItems.Add(new BasketItemD { Count = 1 });
                }
                else
                {
                    _basketItems.Find(basketItem => basketItem.ItemType == ItemType.D)!.Count++;
                }
                
                break;
        }
    }

    public int GetTotalPrice()
    {
        var totalPrice = _pricingRules.Sum(rule => rule.GetPrice(_basketItems));

        return totalPrice;
    }
}