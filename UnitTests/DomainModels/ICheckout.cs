namespace UnitTests.DomainModels;

public interface ICheckout
{
    void Scan(string item); 
    int GetTotalPrice();
}