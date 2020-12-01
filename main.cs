using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Enter the name of the item:");
    string name = Console.ReadLine();
    Console.WriteLine("Enter the quantity");
    string q = Console.ReadLine();
    Console.WriteLine("Enter the price");
    string p = Console.ReadLine();

    int quantity = Int32.Parse(q);
    int price = Int32.Parse(p);

    string fin = (quantity * price).ToString();

    Console.WriteLine("Total price of the " + name + ": $" + fin);
  }
}