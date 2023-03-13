using System;
class Program{
    static void Main(string[] args) {
       int dayofWeek, timeofDay, breakfastSetQty = 5, weekendsetQty = 2, coffeeQty = 3;
       string menu;

       Console.WriteLine("Welcome to Online Food Ordering: ");
       do {
        Console.Write("Enter Day of Week (1=Monday, 2=Tuesday, 3=Wednesday ,4=Thursday, 5=Friday, 6=saturday, 7=Sunday): ");
        dayofWeek = int.Parse(Console.ReadLine());

        Console.Write("Enter Time of Day (8 to 18): ");
        timeofDay = int.Parse(Console.ReadLine());

        Console.Write("Enter menu (Breakfast Set, Weekend Set, Coffee Set or End): ");
        menu = Console.ReadLine();

        switch (menu) {
            case "Breakfast Set": 
            if (timeofDay > 11) {
                Console.WriteLine("Sorry your order is not available");
                break;
            }
            else if (breakfastSetQty > 0) {
                breakfastSetQty--;
                Console.WriteLine("Your order has be placed!");
            }
            else {
                Console.WriteLine("Sorry your order is out of stock");
            }
            break;
            case "Weekend Set":
            if (dayofWeek < 6) {
                Console.WriteLine("Sorry your order is not available");
                break;
            }
            else if (weekendsetQty > 0) {
                weekendsetQty--;
                Console.WriteLine("Your order has be placed!");
            }
            else {
                Console.WriteLine("Sorry your order is out of stock");
            }
            break;
            case "Coffee":
            if(coffeeQty > 0) {
                coffeeQty--;
                Console.WriteLine("Your order has be placed!");
            }
            else {
                Console.WriteLine("Sorry your order is out of stock");
            }
            break;
            case "End":
            Console.WriteLine("Thank you");
            break;
            default:
            Console.WriteLine("Please enter a valid menu");
            break;
         }  
       }  while (menu != "End");
    }
}

