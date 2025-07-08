namespace UnitTests.DomainModels;

public interface IPricingRule
{
    int GetPrice(List<IBasketItem> basketItems);
}