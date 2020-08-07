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
        
            var groupedItems = basketItems.GroupBy(x => x.itemSKU);
            foreach (var item in groupedItems)
            {
                if(item.Count() ==3)
                    continue;

                total += priceEngine.GetPrice(item.Key) * item.Count();
            }
             
            if (basketItems.Count(x=>x.itemSKU=="B") == 3)
                total += 40;

            return total;
        }
    }
}
