using System.Collections.Generic;

namespace KeoghsCheckout
{
    public class Basket
    {
        private readonly List<BasketItem> basketItems;
        public Basket()
        {
            basketItems = new List<BasketItem>();
        }

        public int Total
        {
            get
            {
                return basketItems.Count;
            }
        }

        public void Add(BasketItem item)
        {
            basketItems.Add(item);           
        }
    }
}