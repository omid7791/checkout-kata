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
    
    [Fact]
    public void GivenBasketHasThreeItemA_WhenGettingTotalPrice_ShouldReturn130()
    {
        // Arrange
        var sut = new Checkout();
        sut.Scan("A");
        sut.Scan("A");
        sut.Scan("A");
        
        // Act
        var totalPrice = sut.GetTotalPrice();

        // Assert
        Assert.Equal(130, totalPrice);
    }
    
    [Fact]
    public void GivenBasketHasTwoItemB_WhenGettingTotalPrice_ShouldReturn45()
    {
        // Arrange
        var sut = new Checkout();
        sut.Scan("B");
        sut.Scan("B");
        
        // Act
        var totalPrice = sut.GetTotalPrice();

        // Assert
        Assert.Equal(45, totalPrice);
    }
    
    [Fact]
    public void GivenBasketHasTwoItemBAndItemA_WhenGettingTotalPrice_ShouldReturn95()
    {
        // Arrange
        var sut = new Checkout();
        sut.Scan("B");
        sut.Scan("A");
        sut.Scan("B");
        
        // Act
        var totalPrice = sut.GetTotalPrice();

        // Assert
        Assert.Equal(95, totalPrice);
    }
}