namespace Problema_3_Restaurantes
{
    public abstract class ItemOrder
    {
        public string Name { get; set; }

        public string Size { get; set; }

        public double Price { get; set; }

        public double DiscountPercentage { get; set; }


        public ItemOrder(string name, string size, double price, double discountPercentage)
        {
            this.Name = name;
            this.Size = size;
            this.Price = price;
            this.DiscountPercentage = discountPercentage;
        }

        public virtual bool VerifyAviability()
        {
            return false;
        }

        public virtual double CalculatePrice()
        {
            return 0;
        }

        public virtual void Prepare()
        {
            Console.WriteLine("El elemento está en preparación...");
        }

        public virtual void Package()
        {
            Console.WriteLine("El elemento está enpaquetándose...");
        }
    }
}
