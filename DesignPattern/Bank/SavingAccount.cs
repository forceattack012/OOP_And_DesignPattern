namespace DesignPattern.Bank {

    //Inheritance คือการสืบทอดคุณสมบัติจากคลาสแม่

    //ข้อควรระวัง อย่าใช้ Inheritance เพราะเราขี้เกียจเขียนโค้ดซ้ำๆ เพราะมันจะได้ความสัมพันธ์แบบ Is A เข้าไปด้วย 

    //จงทำ Inheritance เมื่อ Class พวกนั้นมันเป็นประเภทเดียวกันจริงๆ จากมุมมองของ Abstraction เท่านั้น
    public class SavingAccount : BankAccount
    {
        // ส่งเข้า Constructure ของ คลาสแม่
        public SavingAccount(string ownerName, double balance) : base(ownerName, balance)
        {
        }
    }
} 