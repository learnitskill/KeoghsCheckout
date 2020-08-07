using System.Collections.Generic;

namespace KeoghsCheckout
{
    public interface ICheckout
    {
        int BasketTotalAmount(IEnumerable<BasketItem> basketItems);
    }
}