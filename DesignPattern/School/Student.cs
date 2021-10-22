

namespace DesignPattern.School {
    
    //Abstraction คือ การแปลง Physical ต่างๆ ให้การเป็น Modeling
    public class Student {
        public string FirstName {get; set;}
        public string LastName {get; set;}

        //Encapsulation คือการป้องกันไม่ให้ผู้อื่น หรือคลาสอื่นๆ เข้ามาแก้ไขข้อมูล sensitive มั่วซั่ว 
        //เช่นเราไม่อยากให้ใครมา ใส่เกรด 5.00 มั่วซั่ว หรือ -4.00
        private double _garde { get; set; }

        //ให้คลาสอื่นมาดูข้อมูลได่้อย่างเดียว โดยจะดึงจากค่า garde มาแสดง
        public double Garde { get => _garde; }

        public Student(string firstName, string lastName, double garde) {
            FirstName = firstName;
            LastName = lastName;

            // เราสามารถป้องกันการกรอกข้อมูลมั่วๆซั่วๆได้
            if(garde > 0 && garde <= 4.00) {
                _garde = garde;
            }
        }

    }
}