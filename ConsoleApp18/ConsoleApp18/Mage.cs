using System;

namespace MageBattle
{
    public abstract class Mage
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Defense { get; set; }
        public string Element { get; set; }

        public Mage(string name, string element, int health = 100, int defense = 10)
        {
            Name = name;
            Element = element;
            Health = health;
            Defense = defense;
        }

        public abstract void Attack(Mage target);
        public abstract void Defend(int damage);

        public bool IsAlive()
        {
            return Health > 0;
        }
    }
}
