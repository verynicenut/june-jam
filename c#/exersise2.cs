/*
EXERCISE 2: METHODS
You are making a game where players run a bubble tea shop. Each bubble tea in your shop costs $5.
If any customer buys 3 or more cups, they receive a 10% discount. Otherwise, they pay the full price.
Create three methods: CalculateSubtotal(), CalculateDiscount() and CalculateFinalPrice() to complete the program.
*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("How many cups of bubble tea would you like to buy?");
        int cups = Convert.ToInt32(Console.ReadLine());

        double subtotal = CalculateSubtotal(cups);
        double discount = CalculateDiscount(subtotal, cups);
        double finalPrice = CalculateFinalPrice(subtotal, discount);

        Console.WriteLine($"Subtotal: {subtotal}");
        Console.WriteLine($"Discount: {discount}");
        Console.WriteLine($"Final Price: {finalPrice}");
    }

    static double CalculateSubtotal(int cups)
    {
        return cups * 5;
    }

    static double CalculateDiscount(double subtotal, int cups)
    {
        if (cups >= 3)
        {
            return subtotal * 0.1;
        }
        return 0;
    }

    static double CalculateFinalPrice(double subtotal, double discount)
    {
        return subtotal - discount;
    }
}