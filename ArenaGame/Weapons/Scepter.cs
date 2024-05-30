using System;
using ArenaGame.Heroes;

namespace ArenaGame.Weapons
{
    public class Scepter : IWeapon
    {
        public string Name { get; set; }
        public double AttackDamage { get; private set; }
        public double BlockingPower { get; private set; }

        public Scepter(string name)
        {
            Name = name;
            AttackDamage = 15;
            BlockingPower = 5;
        }

        public void ApplyBonus(Hero hero)
        {
            if (hero is Witch)
            {
                hero.Health += 10; 
                AttackDamage += 5; // Additional damage for Witch
            }
        }
    }
}
