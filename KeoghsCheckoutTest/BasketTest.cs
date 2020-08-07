using KeoghsCheckout;
using NUnit.Framework;
using System;

namespace KeoghsCheckoutTest
{
    public class BasketTest
    {
        [Test]
        public void AddItem_GivenItemA_BaksetCountShouldBe1()
        {
            //Arrange
            var expected = 1;
            var basket = new Basket();
            var item = new BasketItem("A");

            //Act
            basket.Add(item);

            //Assert
            var total = basket.Total;
            Assert.That(total, Is.EqualTo(expected));
        }


        [Test]
        public void AddItem_GivenTwoItems_BaksetCountShouldBe2()
        {
            //Arrange
            var expected = 2;
            var basket = new Basket();
            var itemA = new BasketItem("A");
            var itemB = new BasketItem("B");

            //Act
            basket.Add(itemA);
            basket.Add(itemB);

            //Assert
            var total = basket.Total;
            Assert.That(total, Is.EqualTo(expected));
        }

    }
}
