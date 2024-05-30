using System;
using ArenaGame.Heroes;

namespace ArenaGame.Weapons
{
    public class Hammer : IWeapon
    {
        public string Name { get; set; }
        public double AttackDamage { get; private set; }
        public double BlockingPower { get; private set; }

        public Hammer(string name)
        {
            Name = name;
            AttackDamage = 40;
            BlockingPower = 2;
        }

        public void ApplyBonus(Hero hero)
        {
            hero.Strenght += 10;
            AttackDamage += 5; // Additional damage for all characters
        }
    }
}