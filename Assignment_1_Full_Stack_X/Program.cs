Console.WriteLine("Please Enter Recite Amount in JDs:");
var reciteAmount = Convert.ToDecimal(Console.ReadLine());
if (reciteAmount <= 0)
{
    Console.WriteLine("Please Enter a Valid Price!");
    return;
}
else if (reciteAmount >= 500)
{
    Console.WriteLine();
    Console.WriteLine("========================================");
    Console.WriteLine("               SALES RECEIPT            ");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine($"Date: {DateTime.Now:ddd dd-MM-yyyy}    Time: {DateTime.Now:hh:mm:ss tt}");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine($"Subtotal:{reciteAmount} JDs");
    Console.WriteLine($"Discount:{(reciteAmount - ((reciteAmount * 20) / 100))} JDs ({20}%)");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine($"TOTAL:   {(reciteAmount - ((reciteAmount * 20) / 100))} JDs");
    Console.WriteLine("========================================");
    Console.WriteLine("Thank you for your purchase!");
    return;
}
else if (reciteAmount >= 300 && reciteAmount <= 499)
{
    Console.WriteLine();
    Console.WriteLine("========================================");
    Console.WriteLine("               SALES RECEIPT            ");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine($"Date: {DateTime.Now:ddd dd-MM-yyyy}    Time: {DateTime.Now:hh:mm:ss tt}");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine($"Subtotal:{reciteAmount} JDs");
    Console.WriteLine($"Discount:{(reciteAmount - ((reciteAmount * 10) / 100))} JDs ({10}%)");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine($"TOTAL:   {(reciteAmount - ((reciteAmount * 10) / 100))} JDs");
    Console.WriteLine("========================================");
    Console.WriteLine("Thank you for your purchase!");
}
else
{
    Console.WriteLine();
    Console.WriteLine("========================================");
    Console.WriteLine("               SALES RECEIPT            ");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine($"Date: {DateTime.Now:ddd dd-MM-yyyy}    Time: {DateTime.Now:hh:mm:ss tt}");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine($"Subtotal:{reciteAmount} JDs");
    Console.WriteLine($"Discount:{reciteAmount} JDs ({0}%)");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine($"TOTAL:   {reciteAmount} JDs");
    Console.WriteLine("========================================");
    Console.WriteLine("Thank you for your purchase!");
    return;
}