using System;
using ArenaGame.Weapons;

namespace ArenaGame.Heroes
{
    public class Witch : Hero
    {
        private double healingCoef;

        public Witch(string name, double armor, double strength) : base(name, armor, strength)
        {
            healingCoef = 0.1; 
            Weapon.ApplyBonus(this);
        }

        public override double Attack()
        {
            double baseDamage = base.Attack() + 20; 
            if(Health < 100 && ((baseDamage * healingCoef) + Health) <100 )
            {
                Health += (baseDamage * healingCoef);
            }
            return baseDamage;
        }

        public override double Defend(double damage)
        {
            return base.Defend(damage);
        }
    }
}

