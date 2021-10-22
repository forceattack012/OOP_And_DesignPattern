using System;

namespace DesignPattern.MyGame {
    public class Novice : Character
    {
        public Novice()
        {
            hp = 100;
            atk = 100;
        }

        public override void Sit() {
            base.Sit();
        }

        public override void Attack(Character target) {
            if(target != null) {
                target.Hp = atk;
                if(target.Hp == 0) {
                    exp = target.exp;
                    Exp = target.Exp;
                    Console.WriteLine($"Normal Attack : {target.Name}");
                    Console.WriteLine($"Target Status : {target.status}");
                    Console.WriteLine($"Recived Exp : {Exp}");
                }
            }
        }
    }
}