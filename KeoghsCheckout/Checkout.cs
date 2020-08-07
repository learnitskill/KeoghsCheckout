using System.Collections.Generic;
using System.Linq;

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
                if (basketItems.Count(x=>x.itemSKU=="B") == 3)
                    continue;
                total += priceEngine.GetPrice(item.itemSKU);
            }

                if (basketItems.Count(x=>x.itemSKU=="B") == 3)
                total += 40;

            return total;
        }
    }
}
