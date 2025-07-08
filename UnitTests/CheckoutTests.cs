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
        var pricingRuleForItemA = new PricingRuleForItemA();
        var sut = new Checkout([pricingRuleForItemA]);
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
        var pricingRuleForItemA = new PricingRuleForItemA();
        var pricingRuleForItemB = new PricingRuleForItemB();
        var pricingRuleForItemC = new PricingRuleForItemC();
        var pricingRuleForItemD = new PricingRuleForItemD();
        
        var sut = new Checkout([
            pricingRuleForItemA,  
            pricingRuleForItemB, 
            pricingRuleForItemC, 
            pricingRuleForItemD]);
        
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
        var pricingRuleForItemA = new PricingRuleForItemA();
        
        var sut = new Checkout([pricingRuleForItemA]);
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
        var pricingRuleForItemB = new PricingRuleForItemB();
        
        var sut = new Checkout([pricingRuleForItemB]);
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
        var pricingRuleForItemA = new PricingRuleForItemA();
        var pricingRuleForItemB = new PricingRuleForItemB();
        
        var sut = new Checkout([pricingRuleForItemA, pricingRuleForItemB]);
        sut.Scan("B");
        sut.Scan("A");
        sut.Scan("B");
        
        // Act
        var totalPrice = sut.GetTotalPrice();

        // Assert
        Assert.Equal(95, totalPrice);
    }
    
    [Fact]
    public void GivenBasketHasPricingRuleToDiscountTwoItemCs_WhenGettingTotalPrice_ShouldReturnCorrectDiscount()
    {
        // Arrange
        var pricingRuleForItemC = new PricingRuleForItemC();
        var sut = new Checkout([pricingRuleForItemC]);
        sut.Scan("C");
        sut.Scan("C");
        sut.Scan("C");
        
        // Act
        var totalPrice = sut.GetTotalPrice();

        // Assert
        Assert.Equal(35, totalPrice);
    }
}