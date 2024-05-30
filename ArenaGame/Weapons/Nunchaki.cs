using System;
using ArenaGame.Heroes;

namespace ArenaGame.Weapons
{
    public class Nunchaki : IWeapon
    {
        public string Name { get; set; }
        public double AttackDamage { get; private set; }
        public double BlockingPower { get; private set; }

        public Nunchaki(string name)
        {
            Name = name;
            AttackDamage = 25;
            BlockingPower = 5;
        }

        public void ApplyBonus(Hero hero)
        {
            if (hero is Ninja)
            {
                hero.Armor += 20;
                AttackDamage += 10; // Additional damage for Ninja
            }
        }
    }
}