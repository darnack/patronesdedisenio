namespace Problema_3_Restaurantes
{
    public class OrderContext
    {
        private readonly List<ItemOrder> orderItems;

        public OrderContext()
        {
            orderItems = new List<ItemOrder>();
        }

        public void AddItem(ItemOrder item)
        {
            orderItems.Add(item);
            Console.WriteLine(string.Format("* {0} -> {1}", item.Name, item.Price.ToString("C2")));
        }

        public double GetTotalPrice()
        {
            double total = 0.0;
            double discounts = 0.0;
            foreach (var item in orderItems)
            {
                if (!item.VerifyAviability())
                    orderItems.Remove(item);

                total = total + item.CalculatePrice();
                discounts = discounts + (item.Price - item.CalculatePrice());
            }

            Console.WriteLine("Ahorras -> {0}", discounts.ToString("C2"));

            return total;
        }

        public void Confirm()
        {
            foreach (var item in orderItems)
            {
                item.Prepare();
                item.Package();
            }
        }
    }
}
