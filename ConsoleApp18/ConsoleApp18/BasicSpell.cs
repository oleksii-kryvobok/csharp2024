using System;

namespace MageBattle
{
    public class BasicSpell : ISpell
    {
        private int damage;

        public BasicSpell(int damage)
        {
            this.damage = damage;
        }

        public void Cast(Mage target)
        {
            target.Defend(damage);
        }
    }
}
