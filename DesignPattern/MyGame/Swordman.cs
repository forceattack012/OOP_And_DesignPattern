using System;

namespace DesignPattern.MyGame {
    public class Swordman : Character
    {
        public Swordman()
        {
            hp = 500;
            atk = 50;
            exp = 100;
            MaxHp = 500;
        }

        public override void Sit() {
            if(Hp < MaxHp) {
                hp += 20;
            }
            Console.WriteLine($"Sit Heal HP + 20 : {hp}");
        }

        public override void Recurise()
        {
            base.Recurise();
        }
    }
}