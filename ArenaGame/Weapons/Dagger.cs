using System;
using ArenaGame.Heroes;

namespace ArenaGame.Weapons
{
    public class Dagger : IWeapon
    {
        public string Name { get; set; }
        public double AttackDamage { get; private set; }
        public double BlockingPower { get; private set; }

        public Dagger(string name)
        {
            Name = name;
            AttackDamage = 30;
            BlockingPower = 1;
        }

        public void ApplyBonus(Hero hero)
        {
            if (hero is Assassin)
            {
                hero.Strenght += 5;
                AttackDamage += 10; // Additional damage for Assassin
            }
        }
    }
}
