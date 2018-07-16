using EShop.Model;
using FluentAssertions;
using Xunit;

namespace EShop.Tests
{
    public class OrderTests
    {
        [Fact]
        public void AddItem_MainFlow_ChangeTotal()
        {
            var order = new Order();

            var toothpaste = new Product() { Name = "Toothpaste", Price = 129 };
            order.AddItem(toothpaste, 1);

            order.Total.Should().Be(129);

            var mouthwash = new Product() { Name = "Mouthwash", Price = 342 };
            order.AddItem(mouthwash, 2);

            order.Total.Should().Be(813);
        }
    }
}
