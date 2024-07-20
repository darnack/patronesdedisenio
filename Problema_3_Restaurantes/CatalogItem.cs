namespace Problema_3_Restaurantes
{
    public class CatalogItem
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public string Size { get; set; }

        public CatalogItem(string name, string size, double price)
        {
            this.Name = name;
            this.Size = size;
            this.Price = price;
        }
    }
}
