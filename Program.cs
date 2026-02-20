using System;

class Program
{
    static void Main()
    {
       
        Console.Write("Product Name: ");
        string productName = Console.ReadLine();

        Console.Write("Quantity: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        Console.Write("Price per Item: ");
        double price = Convert.ToDouble(Console.ReadLine());

        Console.Write("Discount Percentage: ");
        double discount = Convert.ToDouble(Console.ReadLine());

        Console.Write("Delivery: ");
        double delivery = Convert.ToDouble(Console.ReadLine());

        Console.Write("Distance in km: ");
        double distance = Convert.ToDouble(Console.ReadLine());

        Console.Write("Payment Method: ");
        string payment = Console.ReadLine();

        double totalPrice = quantity * price;
        double discountAmount = totalPrice * discount / 100;
        double finalPrice = totalPrice - discountAmount + delivery*distance;

        Console.WriteLine("Total price: " + totalPrice);
        Console.WriteLine("Discount amount: " + discountAmount);
        Console.WriteLine("Final price after discount: " + finalPrice);
    }
}