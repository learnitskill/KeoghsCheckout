using System.Collections.Generic;

namespace KeoghsCheckout
{
    public class Checkout : ICheckout
    {
        private readonly IPriceEngine priceEngine;

        public Checkout(IPriceEngine priceEngine)
        {
            this.priceEngine = priceEngine;
        }

        public int BasketTotalAmount(IEnumerable<BasketItem> basketItems)
        {
            int total = 0;
            foreach (var item in basketItems)
            {
                total += priceEngine.GetPrice(item.itemSKU);
            }

            return total;
        }
    }
}
