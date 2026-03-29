using Restaurant;
using Xunit;

// #######################
//    FULL SYSTEM TEST
// #######################
namespace Restaurant.Tests
{
    public class SystemTests
    {
        [Fact]
        public void FullRestaurantFlow_ShouldCompleteSuccessfully()
        {
            // Init all the system
            var myRestaurant = new RestaurantSystem();
            string customerName = "Valerio";
            string productToOrder = "Pizza";

            // Simulate all the restaurant order process
            bool success = myRestaurant.ProcessCustomerOrder(customerName, productToOrder);

            // Verify a correct final state
            Assert.True(success);
            Assert.Single(myRestaurant.activeOrders);
            Assert.Equal("created", myRestaurant.activeOrders[0].Status);
        }
    }
}