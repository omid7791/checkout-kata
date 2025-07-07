using UnitTests.DomainModels;

namespace UnitTests;

public class CheckoutTests
{
    [Fact]
    public void GivenBasketHasNoItems_WhenGettingTotalPrice_ShouldReturnZero()
    {
        // Arrange
        var sut = new Checkout();
        
        // Act
        var totalPrice = sut.GetTotalPrice();

        // Assert
        Assert.Equal(0, totalPrice);
    }
    
    [Fact]
    public void GivenBasketHasItemA_WhenGettingTotalPrice_ShouldReturn50()
    {
        // Arrange
        var sut = new Checkout();
        sut.Scan("A");
        
        // Act
        var totalPrice = sut.GetTotalPrice();

        // Assert
        Assert.Equal(50, totalPrice);
    }
    
    [Fact]
    public void GivenBasketHasItemsA_B_C_D_WhenGettingTotalPrice_ShouldReturn115()
    {
        // Arrange
        var sut = new Checkout();
        sut.Scan("A");
        sut.Scan("B");
        sut.Scan("C");
        sut.Scan("D");
        
        // Act
        var totalPrice = sut.GetTotalPrice();

        // Assert
        Assert.Equal(115, totalPrice);
    }
}