namespace Problema_3_Restaurantes.OrderTypes
{
    public class Dessert : CatalogItem, ItemOrder
    {
        public bool ContainsPeanuts { get; set; }

        public static int DESSERT_AVIABILITY { get; set; }

        private const double DESSERT_PERCENTAGE_DISCOUNT = 0.20;

        public Dessert(string name, string size, double price, bool containsPeanuts)
            : base(name, size, price)
        {
            ContainsPeanuts = containsPeanuts;
        }

        public virtual bool VerifyAviability()
        {
            return DESSERT_AVIABILITY > 0;
        }

        public virtual double CalculatePrice()
        {
            return Price - (Price * DESSERT_PERCENTAGE_DISCOUNT);
        }

        public virtual void Prepare()
        {
            Console.WriteLine("Dessert manager is PREPARING your '{0}'...", Name);
        }

        public virtual void Package()
        {
            Console.WriteLine("Dessert manager is PACKAGING your '{0}'...", Name);
        }
    }
}
