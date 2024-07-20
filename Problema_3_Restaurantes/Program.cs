// See https://aka.ms/new-console-template for more information
using Problema_3_Restaurantes;
using Problema_3_Restaurantes.OrderTypes;

Console.WriteLine("Bienvenido al sistema de ordenes en línea!");

Food.FOOD_AVIABILITY = 100;
Beverage.BEVERAGE_AVIABILITY = 80;
Dessert.DESSERT_AVIABILITY = 20;

var order = new Order();

var hamgurguesa = new Food("Hamburguesa dobel carne", "240 grs", 28000, false);
var papas = new Food("Papas fritas", "150 grs", 4000, false);
var te = new Beverage("Té frío", "220 ml", 7500, false);
var chessecake = new Dessert("Chessecake de mora", "180 grm", 9900, true);

order.AddItem(hamgurguesa);
order.AddItem(papas);
order.AddItem(te);
order.AddItem(chessecake);

Console.WriteLine("El precio total es -> {0}", order.GetTotalPrice().ToString("C2"));

order.Confirm();

Console.WriteLine("Su orden se encuentra en camino!");
