using System;
using System.Collections.Generic;

namespace DesignPattern.MyGame {

    // abstract class คือคลาสที่ไม่สามารถนำไปใช้ได้ จริงเป็น แค่ concept เพื่อไม่ให้คนอื่นนำ Character ไปสร้างเป็น object
    public abstract class Character {
        public string Name { get; set; }
        public double hp { get;  protected set; }
        public double MaxHp { get; protected set; } = 0;
        public double level { get; protected set; }
        public string status {get;  protected set; }

        public double atk {get; protected set; }
        public IEnumerable<Skill> Skills { get; protected set; }

        public double Hp { 
            get => hp; 
            set  {
                var hpTemp = hp;
                hpTemp -= value;
                if(hpTemp <= 0) {
                    hp = 0;
                    status = "Dead";
                    Dead();
                }
                else {
                    status = "Alive";
                    hp = hpTemp;
                }
            } 
        }

        public double exp { get; protected set; }

        public double Exp { 
            get => exp;  
            set {
                var expTemp = exp;
                exp += value;

                if(exp >= 100) {
                    exp = 0;
                    level++;
                }
                else {
                    exp = expTemp;
                }
            }
        }

        public Character() { 
            hp = 100;
        }
        public void Walk() {
            Console.WriteLine($"Walk");
        }

        public virtual void Attack(Character target) {
            if(target != null) {
                exp +=10;
                Console.WriteLine($"Normal Attack : {target.Name}");
            }
        }

        public void Dead() {
            Console.WriteLine($"{status}");
        }

        public void Spell(Skill skill) {

        }
        public void Spell(Skill skill, Character target) {

        }

        public virtual void Sit() {
            if(hp != hp ) {
                hp += 10;
            }
            Console.WriteLine($"Sit Heal HP + 10 : {hp}");
        }

        public virtual void Recurise()
        {
            hp = 10;
            status = "Alive";
        }
    }
}