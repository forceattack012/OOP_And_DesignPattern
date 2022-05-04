// See https://aka.ms/new-console-template for more information
using Adapter;

Console.WriteLine("Hello, World!");


IAccountAdapter accountAdapter = new AccountAdapter();
var account = accountAdapter.GetAccountInfo();
Console.WriteLine("Name : " + account.Name);
