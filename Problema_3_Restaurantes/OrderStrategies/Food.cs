namespace Problema_3_Restaurantes.OrderStrategies
{
    public class Food : ItemOrder
    {
        public bool IsSpicy { get; set; }

        public static int FOOD_AVIABILITY { get; set; }

        public Food(string name, string size, double price, double discountPercentage, bool isSpicy)
            : base(name, size, price, discountPercentage)
        {
            IsSpicy = isSpicy;
        }

        public override bool VerifyAviability()
        {
            return FOOD_AVIABILITY > 0;
        }

        public override double CalculatePrice()
        {
            return Price - (Price * DiscountPercentage);
        }

        public override void Prepare()
        {
            Console.WriteLine("La estrategia Food está PREPARANDO: '{0}'...", Name);
        }

        public override void Package()
        {
            Console.WriteLine("La estrategia Food está EMPAQUETANDO: '{0}'...", Name);
        }
    }
}
