namespace Problema_3_Restaurantes.OrderStrategies
{
    public class Dessert : ItemOrder
    {
        public bool ContainsPeanuts { get; set; }

        public static int DESSERT_AVIABILITY { get; set; }

        public Dessert(string name, string size, double price, double discountPercentage, bool containsPeanuts)
            : base(name, size, price, discountPercentage)
        {
            ContainsPeanuts = containsPeanuts;
        }

        public override bool VerifyAviability()
        {
            return DESSERT_AVIABILITY > 0;
        }

        public override double CalculatePrice()
        {
            return Price - (Price * DiscountPercentage);
        }

        public override void Prepare()
        {
            Console.WriteLine("La estrategia Dessert está PREPARANDO: '{0}'...", Name);
        }

        public override void Package()
        {
            Console.WriteLine("La estrategia Dessert está EMPAQUETANDO '{0}'...", Name);
        }
    }
}
