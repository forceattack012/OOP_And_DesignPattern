using System;
using DesignPattern.Bank;
using DesignPattern.School;
using DesignPattern.MyAnimal;
using DesignPattern.MyGame;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMyGame();
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

        static void ShowMyGame() {
            Character swordMan = new Swordman();
            Character novice = new Novice();
            swordMan.Name = "swordMan";
            novice.Name = "Novice";

            Console.WriteLine("------------------ Novice ------------------------");
            Console.WriteLine($"Name : {novice.Name}");
            Console.WriteLine($"Hp : {novice.Hp }");
            novice.Sit();

            do {
                novice.Attack(swordMan);
                novice.Spell(novice.Skills[0], swordMan);
                Console.WriteLine($"target HP : {swordMan.Hp}");
            } while(swordMan.Hp > 0);

            Console.WriteLine($"{novice.level}");

            swordMan.Recurise();
            swordMan.Sit();

            // Console.WriteLine("------------------ Swordman ------------------------");
            // Console.WriteLine($"Name : {swordMan.Name}");
            // Console.WriteLine($"Hp : {swordMan.Hp }");
            // swordMan.Sit();
            
        }
    }
}
