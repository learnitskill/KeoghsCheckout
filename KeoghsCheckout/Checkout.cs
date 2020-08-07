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

                if (item.Key == "B")
                {
                    var onOffer = item.Count() / 3;
                    var noOffer = item.Count() % 3;

                    if(noOffer > 0)
                        total += priceEngine.GetPrice(item.Key) * item.Count();
                    else
                        total += 40 * onOffer;                   
                    
                }
                else
                    total += priceEngine.GetPrice(item.Key) * item.Count();
            }
            return total;
        }
    }
}
