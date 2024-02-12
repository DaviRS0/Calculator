using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter your age: ");
        string input = Console.ReadLine();
        int age;
        double fee = 0;
        double discount = 0;
        double subtotal = 0;
        double hst = 0;
        double cityTax = 0;
        double finalFee = 0;

        if (int.TryParse(input, out age))
        {
            if (age <= 19)
            {
                fee = 10.00;
            }
            else if (age >= 20 && age <= 29)
            {
                fee = 25.50;
            }
            else if (age >= 30 && age <= 59)
            {
                fee = 50.50;
            }
            else if (age >= 60)
            {
                fee = 0;
            }

            Console.Write("Please enter the start month: ");
            string month = Console.ReadLine().ToLower();

            if (month == "january" || month == "february")
            {
                discount = 10.00;
            }
            else if (month == "march" || month == "april")
            {
                discount = fee * 0.10;
            }
            else if (month == "may")
            {
                discount = -20.00;
            }

            Console.Write("Were you referred by a client? (yes/no):  \n");
            string referral = Console.ReadLine().ToLower();

            if (referral == "yes")
            {
                discount += 10.50;
            }

            subtotal = fee + discount;
            if (subtotal < 0)
            {
                subtotal = 0;
            }

            hst = subtotal * 0.13;
            cityTax = subtotal * 0.08;
            finalFee = subtotal + hst + cityTax;

            Console.WriteLine("--------------------------------------------------------\n");
            Console.WriteLine($"Your age: {age}");
            Console.WriteLine($"Your registration month: {month} \n");
            Console.WriteLine("--------------------------------------------------------\n");
            Console.WriteLine($"Monthly subscription based on age: {fee:C}");
            Console.WriteLine($"Start Month Adjustment: {discount:C}");
            Console.WriteLine($"Subtotal: {subtotal:C}\n");
            Console.WriteLine("--------------------------------------------------------\n");
            Console.WriteLine($"HST: {hst:C}");
            Console.WriteLine($"City Services Tax: {cityTax:C}\n");
            Console.WriteLine("--------------------------------------------------------\n");
            Console.WriteLine($"Final Monthly Subscription Total: {finalFee:C}");
        }
    }
}
