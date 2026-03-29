using Restaurant;
using Xunit;

// #######################
//       UNIT TEST
// #######################
public class UnitTests
{
    [Fact]
    public void AddProduct_ShouldIncreaseItemsCount()
    {
        // Order a pizza
        var order = new Order();
        var pizza = new Product("Pizza", 12.5f, 10);
        
        order.AddProduct(pizza);

        // Verify if only exits one item in the order list
        Assert.Single(order.Items); 
        Assert.Equal("Pizza", order.Items[0].Name);
    }
}