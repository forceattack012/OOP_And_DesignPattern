namespace DesignPattern.Bank {

    // การใช้ inheritance มันมีความสัมพันธ์เป็น is a 
    // บัญชีรายวันเป็น บัญชีธนาคารประเภทหนึ่ง
    public class CurrentAccount : BankAccount
    {
        private double credit = 1000.00;
        public CurrentAccount(string ownerName, double balance) : base(ownerName, balance)
        {
        }

        public  override void Withdraw(double amount) {
            if(amount <= Balance + credit) {
                Balance -= amount;
            }
        }

    }
}