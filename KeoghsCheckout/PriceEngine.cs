namespace KeoghsCheckout
{
    public class PriceEngine: IPriceEngine
    {
        public int GetPrice(string SKU)
        {
            switch (SKU)
            {
                case "A": return 10;
                case "B": return 15;
            }
            return 0;
        }
    }
}