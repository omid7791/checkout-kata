namespace UnitTests.DomainModels;

public class Checkout : ICheckout
{
    private readonly List<BasketItem> _basketItems = new List<BasketItem>();
    
    public void Scan(string item)
    {
        if (item == "A")
        {
            _basketItems.Add(new BasketItem { Item = item, Price = 50 });
        }
    }

    public int GetTotalPrice()
    {
        var totalPrice = _basketItems.Sum(item => item.Price);

        return totalPrice;
    }
}

public class BasketItem
{
    public string Item { get; set; }
    public int Price { get; set; }
}