namespace Problema_3_Restaurantes.OrderTypes
{
    public class Beverage : CatalogItem, ItemOrder
    {
        public bool ContainsAlcohol { get; set; }

        public static int BEVERAGE_AVIABILITY { get; set; }

        private const double BEVERAGE_PERCENTAGE_DISCOUNT = 0.8;

        public Beverage(string name, string size, double price, bool containsAlcohol)
            : base(name, size, price)
        {
            ContainsAlcohol = containsAlcohol;
        }

        public virtual bool VerifyAviability()
        {
            return BEVERAGE_AVIABILITY > 0;
        }

        public virtual double CalculatePrice()
        {
            if (ContainsAlcohol)
            {
                return Price - (Price * BEVERAGE_PERCENTAGE_DISCOUNT);
            }
            else
            {
                return Price - (Price * BEVERAGE_PERCENTAGE_DISCOUNT * 2);
            }
        }

        public virtual void Prepare()
        {
            Console.WriteLine("Beverage manager is PREPARING your '{0}'...", Name);
        }

        public virtual void Package()
        {
            Console.WriteLine("Beverage manager is PACKAGING your '{0}'...", Name);
        }
    }
}
