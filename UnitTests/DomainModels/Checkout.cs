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
                _basketItems.Add(new BasketItemB());
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

public class BasketItemB : IBasketItem
{
    public ItemType ItemType => ItemType.B;

    public int GetPrice()
    {
        return 30;
    }

    public int Count { get; set; }
}

public class BasketItemC : IBasketItem
{
    public ItemType ItemType => ItemType.C;

    public int GetPrice()
    {
        return 20;
    }

    public int Count { get; set; }
}

public class BasketItemD : IBasketItem
{
    public ItemType ItemType => ItemType.D;

    public int GetPrice()
    {
        return 15;
    }

    public int Count { get; set; }
}

public interface IBasketItem
{
    public ItemType ItemType { get; }
    public int GetPrice();
    public int Count { get; set; }
}

public enum ItemType
{
    A,
    B,
    C,
    D
}