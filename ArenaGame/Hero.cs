using ArenaGame.Weapons;
using System;

namespace ArenaGame
{
    public abstract class Hero : IHero
    {
        protected Random random = new Random();
        public string Name { get; private set; }
        public double Health { get;  set; }
        public double Armor { get; set;  }
        public double Strenght { get; set; }
        public IWeapon Weapon { get; private set; }
        public bool IsAlive
        {
            get
            {
                return Health > 0;
            }
        }

        static IWeapon GetRandomWeapon()
        {
            Random random = new Random();
            List<IWeapon> weapons = new List<IWeapon>
            {
                new Sword("Sword"),
                new Dagger("Dagger"),
                new Scepter("Scepter"),
                new Nunchaki("Nunchaki"),
                new Hammer("Hammer")
            };

            int index = random.Next(weapons.Count);
            return weapons[index];
        }
        public Hero(string name, double armor, double strenght)
        {
            Health = 100;

            Name = name;
            Armor = armor;
            Strenght = strenght;
            Weapon = GetRandomWeapon();
            Weapon.ApplyBonus(this);
        }

        // returns actual damage
        public virtual double Attack()
        {
            double totalDamage = Strenght + Weapon.AttackDamage;
            double coef = random.Next(80, 120 + 1);
            double realDamage = totalDamage * (coef / 100);
            return realDamage;
        }

        public virtual double Defend(double damage)
        {
            double coef = random.Next(80, 120 + 1);
            double defendPower = (Armor + Weapon.BlockingPower) * (coef / 100);
            double realDamage = damage - defendPower;
            if (realDamage < 0)
                realDamage = 0;
            Health -= realDamage;
            return realDamage;
        }

        public override string ToString()
        {
            return $"{Name} with health {Math.Round(Health, 2)} and with the {Weapon.Name}";
        }
    }
}

