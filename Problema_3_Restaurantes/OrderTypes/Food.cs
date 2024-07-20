namespace Problema_3_Restaurantes.OrderTypes
{
    public class Food : CatalogItem, ItemOrder
    {
        public bool IsSpicy { get; set; }

        public static int FOOD_AVIABILITY { get; set; }

        private const double FOOD_PERCENTAGE_DISCOUNT = 0.10;

        public Food(string name, string size, double price, bool isSpicy)
            : base(name, size, price)
        {
            IsSpicy = isSpicy;
        }

        public virtual bool VerifyAviability()
        {
            return FOOD_AVIABILITY > 0;
        }

        public virtual double CalculatePrice()
        {
            return Price - (Price * FOOD_PERCENTAGE_DISCOUNT);
        }

        public virtual void Prepare()
        {
            Console.WriteLine("Food manager is PREPARING your '{0}'...", Name);
        }

        public virtual void Package()
        {
            Console.WriteLine("Food manager is PACKAGING your '{0}'...", Name);
        }
    }
}
