using System;

const int  priceSmall = 25;
const int priceLarge = 35;
const double taxRate = 0.06;
Console.WriteLine("Number of Small Carpets: ");
int numSmall = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Number of Large Carpets: ");
int numLarge = Convert.ToInt32(Console.ReadLine()); 
double costSmall = numSmall * priceSmall;
double costLarge = numLarge * priceLarge;
double subTotal = costSmall + costLarge;
double tax = subTotal * taxRate;
double total = subTotal + tax;
Console.WriteLine($"Cost of {numSmall} small carpets at {priceSmall:c} each: {costSmall:c}");
Console.WriteLine($"Cost of {numLarge} large carpets at {priceLarge:c} each: {costLarge:c}");
Console.WriteLine($"Subtotal: {subTotal:c}");
Console.WriteLine($"Tax: {tax:c}");
Console.WriteLine($"Total: {total:c}");

