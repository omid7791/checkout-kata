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
}