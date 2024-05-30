using System;
using ArenaGame.Heroes;

namespace ArenaGame.Weapons
{
    public class Sword : IWeapon
    {
        public string Name { get; set; }
        public double AttackDamage { get; private set; }
        public double BlockingPower { get; private set; }

        public Sword(string name)
        {
            Name = name;
            AttackDamage = 35;
            BlockingPower = 3;
        }

        public void ApplyBonus(Hero hero)
        {
            if (hero is Knight a)
            {
                AttackDamage += 10; // Additional damage for Knight 
            }
        }
    }
}