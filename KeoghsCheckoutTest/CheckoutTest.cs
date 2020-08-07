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
            IPriceEngine priceEngine = new PriceEngine();
            ICheckout checkout = new Checkout(priceEngine);
            var basket = new Basket();
            var itemA = new BasketItem("A");            
            basket.Add(itemA);
            
            //Act
            var total = checkout.BasketTotalAmount(basket.basketItems);

            //Assert
            Assert.That(total, Is.EqualTo(expected));
        }

        [Test]
        public void BasketTotalAmount_Given2BasketItem_BaksetTotalAmountShouldBe25()
        {
            //Arrange
            var expected = 25;
            IPriceEngine priceEngine = new PriceEngine();
            ICheckout checkout = new Checkout(priceEngine);
            var basket = new Basket();
            var itemA = new BasketItem("A");
            var itemB = new BasketItem("B");
            basket.Add(itemA);
            basket.Add(itemB);

            //Act
            var total = checkout.BasketTotalAmount(basket.basketItems);

            //Assert
            Assert.That(total, Is.EqualTo(expected));
        }
    }
}
