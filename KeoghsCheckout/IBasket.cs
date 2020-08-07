namespace KeoghsCheckout
{
    public interface IBasket
    {
        int Total { get; }
        void Add(BasketItem item);
    }
}