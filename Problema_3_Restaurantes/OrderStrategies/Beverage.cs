namespace Problema_3_Restaurantes.OrderStrategies
{
    public class Beverage : ItemOrder
    {
        public bool ContainsAlcohol { get; set; }

        public static int BEVERAGE_AVIABILITY { get; set; }

        public Beverage(string name, string size, double price, double discountPercentage, bool containsAlcohol)
            : base(name, size, price, discountPercentage)
        {
            ContainsAlcohol = containsAlcohol;
        }

        public override bool VerifyAviability()
        {
            return BEVERAGE_AVIABILITY > 0;
        }

        public override double CalculatePrice()
        {
            if (ContainsAlcohol)
            {
                return Price - (Price * DiscountPercentage);
            }
            else
            {
                return Price - (Price * DiscountPercentage * 2);
            }
        }

        public override void Prepare()
        {
            Console.WriteLine("La estrategia Beverage está PREPARANDO: '{0}'...", Name);
        }

        public override void Package()
        {
            Console.WriteLine("La estrategia Beverage está EMPAQUETANDO '{0}'...", Name);
        }
    }
}
