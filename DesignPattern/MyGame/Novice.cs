using System;
using System.Collections.Generic;

namespace DesignPattern.MyGame {
    public class Novice : Character
    {
        public Novice()
        {
            hp = 100;
            atk = 100;
            MaxHp = 100;
            Skills = new List<Skill>() {
                new Skill()
                {
                    Name = "Double Attack",
                    Attack = 800
                }
            };
            
        }

        public override void Sit() {
            if(Hp < MaxHp)
            {
                base.Sit();
            }
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

        public override void Spell(Skill skill, Character target)
        {
            target.Hp = skill.Attack;
            Console.WriteLine($"Attack Skill : {skill.Name} Damage : {skill.Attack}");
        }
    }
}