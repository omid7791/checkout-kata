namespace UnitTests.DomainModels;

public class Checkout : ICheckout
{
    private readonly List<IBasketItem> _basketItems = [];

    public Checkout()
    {
        
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
                _basketItems.Add(new BasketItemC());
                break;
            case "D":
                _basketItems.Add(new BasketItemD());
                break;
        }
    }

    public int GetTotalPrice()
    {
        var totalPrice = _basketItems.Sum(item => item.GetPrice());

        return totalPrice;
    }
}