using System;
using DesignPattern.Bank;
using DesignPattern.School;
using DesignPattern.MyAnimal;


namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static void ShowStudent(){
            Student student = new Student("Jo","Runo",4.00);

            Console.WriteLine($"name : {student.FirstName} {student.LastName} Garde: {student.Garde}");
        }

        static void ShowBankAccount() {
            SavingAccount SavingAccount = new SavingAccount("(Saving Account) Wisarut",1000);

            CurrentAccount currentAccount = new CurrentAccount("(current Account) Wisarut",500);

            SavingAccount.Withdraw(1000);
            currentAccount.Withdraw(1000);

            currentAccount.Deposit(1000);

            SavingAccount.ClosedAccount();
            SavingAccount.Deposit(200);
            Console.WriteLine($"Saving Account Balance : {SavingAccount.Balance} : Closed : {SavingAccount.IsClosed}");

            Console.WriteLine($"Current Account Balance : {currentAccount.Balance} : ");
        }

        static void ShowAnimal(){

            //  Polymorphism คือการเปลี่ยนรูป โดยที่คลาสลูกสามารถเปลี่ยนรูปเป็น class แม่ได้ 
            // แต่คลาสลูกกับคลาสแม่ต้องมีความสัมพันธ์เป็น is a แปลว่า เป็น 
            // เช่น สุนัขเป็นสัตว์ชนิดหนึ่ง แมวเป็นสัตว์ชนิดนึง ถึงทำได้ อย่าใช้มั่วซั่ว
            Animal Dog = new Dog();

            Animal Cat = new Cat();
        }
    }
}
