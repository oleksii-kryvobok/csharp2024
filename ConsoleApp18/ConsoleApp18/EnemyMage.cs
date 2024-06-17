using System;

namespace MageBattle
{
    public class EnemyMage : Mage
    {
        private static Random random = new Random();
        private static string[] elements = { "Anemo", "Hydro", "Cryo", "Dendro", "Pyro", "Electro", "Geo" };

        public EnemyMage(string name) : base(name, elements[random.Next(elements.Length)]) { }

        public override void Attack(Mage target)
        {
            Thread.Sleep(500);
            Console.WriteLine($"\n{Name} attacks {target.Name}!");
            ISpell spell = new BasicSpell(random.Next(15, 26));
            spell.Cast(target);
        }

        public override void Defend(int damage)
        {
            Thread.Sleep(500);
            int givenDamage = damage - Defense;
            if (givenDamage < 0) givenDamage = 0;
            Health -= givenDamage;
            if (Health < 0) Health = 0;
            Console.WriteLine($"{Name} took {givenDamage} damage! Health: {Health}");
        }
    }
}
