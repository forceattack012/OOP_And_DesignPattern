// See https://aka.ms/new-console-template for more information
using CreationalPatterns.Factory;

Console.WriteLine("Hello, World!");

var goldCard = CreditCardFactory.CreateCreditCard("Gold", "John", 10000);
var patinumCard = CreditCardFactory.CreateCreditCard("Pattinum", "Jame", 5000);

Console.WriteLine("======================= Gold =========================");
Console.WriteLine($"Card is {goldCard.GetAccountName()}");
Console.WriteLine(goldCard.GetType());
Console.WriteLine(goldCard.GetAmount() + "\n");


Console.WriteLine("======================= Patinum =========================");
Console.WriteLine($"Card is {patinumCard.GetAccountName()}");
Console.WriteLine(patinumCard.GetType());
Console.WriteLine(patinumCard.GetAmount());