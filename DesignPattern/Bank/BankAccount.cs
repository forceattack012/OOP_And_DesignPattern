namespace DesignPattern.Bank {
    public class BankAccount {
        public string OwnerName { get; set; }
        private double balance { get; set; } 
        private bool isClosed { get; set; }
        public double Balance { 
            get => balance; 
            protected set => balance = value; //มีการกำหนดค่าจากคลาสที่ สืบทอดจากคลาสแม่
        }
        public bool IsClosed { get => isClosed; }


        public BankAccount(string ownerName, double balance) {
            if(!isClosed) {
                OwnerName = ownerName;
                this.balance = balance;
            }
        }

        public void Deposit(double amount) {
            if(amount > 0 && !isClosed){
                balance += amount;
            }
        }

        // keyword virture ทำให้ method นี้ในคลาสลูกสามารถตั้งชื่อเดียวกันได้แต่ทำงานคนละ ตามแต่คลาสลูก
        public virtual void Withdraw(double amount) {
            if(amount >= 0 && amount <= balance && !isClosed){ 
                balance -= amount;
            }
        }
        public void ClosedAccount() { 
            isClosed = true;
        }
    }
}