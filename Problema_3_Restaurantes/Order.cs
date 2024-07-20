namespace Problema_3_Restaurantes
{
    public class Order
    {
        private readonly List<ItemOrder> orderItems;

        public Order()
        {
            orderItems = new List<ItemOrder>();
        }

        public void AddItem(ItemOrder item)
        {
            orderItems.Add(item);
        }

        public double GetTotalPrice()
        {
            double total = 0.0;
            foreach (var item in orderItems)
            {
                if (!item.VerifyAviability())
                    orderItems.Remove(item);

                total = total + item.CalculatePrice();
            }

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
