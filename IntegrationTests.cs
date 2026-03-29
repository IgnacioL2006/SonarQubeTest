using Xunit;
using Restaurant;

// #######################
//    INTEGRATION TEST
// #######################

public class IntegrationTests
{
    [Fact]
    public void Order_ShouldCheckInventory_BeforeAdding()
    {
        // Create scenario
        var inventory = new Inventory(); 
        var order = new Order();     
        var pizza = new Product("Pizza", 12.5f, 1); // Only one left
        
        inventory.RequestProduct("pizza"); 
        order.AddProduct(pizza);

        // Assert
        Assert.Single(order.Items); // The pizza enter to the order
    }
}