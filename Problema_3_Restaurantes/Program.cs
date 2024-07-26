// See https://aka.ms/new-console-template for more information
using Problema_3_Restaurantes;
using Problema_3_Restaurantes.OrderStrategies;

Console.WriteLine("Bienvenido al sistema de ordenes en línea!");

Food.FOOD_AVIABILITY = 100;
Beverage.BEVERAGE_AVIABILITY = 80;
Dessert.DESSERT_AVIABILITY = 20;

var order = new OrderContext();

var hamgurguesa = new Food("Hamburguesa dobel carne", "240 grs", price: 28000, discountPercentage: 0.10, isSpicy: false);
var papas = new Food("Papas fritas", "150 grs", price: 4000, discountPercentage: 0.05, isSpicy: false);
var te = new Beverage("Té frío", "220 ml", price: 7500, discountPercentage: 0.07, containsAlcohol: false);
var chessecake = new Dessert("Chessecake de mora", "180 grm", price: 9900, discountPercentage: 0.20, containsPeanuts: true);

order.AddItem(hamgurguesa);
order.AddItem(papas);
order.AddItem(te);
order.AddItem(chessecake);

Console.WriteLine("El precio total es -> {0}", order.GetTotalPrice().ToString("C2"));

Console.WriteLine("¿Desea confirmar su pedido? (Y/N)");
var confirm = Console.ReadLine();
if (confirm != null && confirm.Trim().ToUpper() == "Y")
{
    order.Confirm();
    Console.WriteLine("Su orden se encuentra en camino!");
}
else
{
    Console.WriteLine("Vuelve pronto!");
}
