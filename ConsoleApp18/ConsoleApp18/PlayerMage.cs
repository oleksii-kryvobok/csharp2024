using System;

namespace MageBattle
{
    public class PlayerMage : Mage
    {
        private static Random random = new Random();

        public PlayerMage(string name, string element) : base(name, element) { }

        public override void Attack(Mage target)
        {
            Thread.Sleep(500);
            Console.WriteLine($"\n{Name} attacks {target.Name}!");
            ISpell spell = new BasicSpell(random.Next(15, 26));
            RaiseAttackEvent(target);
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
            RaiseDefendEvent(givenDamage);
            if (!IsAlive()) RaiseDefeatedEvent();
        }
    }
}
