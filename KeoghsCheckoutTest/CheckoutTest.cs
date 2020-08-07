using KeoghsCheckout;
using NUnit.Framework;
using System;

namespace KeoghsCheckoutTest
{
    public class CheckoutTest
    {
        [Test]
        public void BasketTotalAmount_GivenBasket_BaksetTotalAmountShouldBe10()
        {
            //Arrange
            var expected = 10;
            var checkout = new Checkout();                    
            var basket = new Basket();
            var itemA = new BasketItem("A");            
            basket.Add(itemA);

            //Act
            var total = checkout.BasketTotalAmount(basket);

            //Assert
            Assert.That(total, Is.EqualTo(expected));
        }
    }
}
