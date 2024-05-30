using System;
using ArenaGame.Weapons;

namespace ArenaGame.Heroes
{
    public class Ninja : Hero
    {
        public Ninja(string name, double armor, double strength) : base(name, armor, strength)
        {
            Weapon.ApplyBonus(this);
        }

        public override double Attack()
        {
            return base.Attack();
        }

        public override double Defend(double damage)
        {
            double probability = new Random().NextDouble();
            if (probability < 0.25)  
            {
                return 0;
            }
            return base.Defend(damage);
        }
    }
}
