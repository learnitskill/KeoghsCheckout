namespace KeoghsCheckout
{
    public class Checkout : ICheckout
    {
        public int BasketTotalAmount(Basket basket)
        {
            return 10;
        }
    }
}
