using System;
using ArenaGame.Weapons;

namespace ArenaGame.Heroes
{
    public class Assassin : Hero
    {
        public Assassin(string name, double armor, double strength) : base(name, armor, strength)
        {
            Weapon.ApplyBonus(this);
        }

        public override double Attack()
        {
            double damage = base.Attack();
            double probability = new Random().NextDouble();
            if (probability < 0.10) 
            {
                damage *= 3;
            }
            return damage;
        }
    }
}
