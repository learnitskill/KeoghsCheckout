using System.Collections.Generic;

namespace KeoghsCheckout
{
    public class Checkout : ICheckout
    {        
        public int BasketTotalAmount(IEnumerable<BasketItem> basketItems)
        {
            int total = 0;
            foreach (var item in basketItems)
            {
                if (item.itemSKU == "A")
                    total += 10;
                if (item.itemSKU == "B")
                    total += 15;
            }

            return total;
        }
    }
}
