using System;

namespace MageBattle
{
    public class MageEventArgs : EventArgs
    {
        public Mage Target { get; }
        public int Damage { get; }

        public MageEventArgs(Mage target)
        {
            Target = target;
        }

        public MageEventArgs(int damage)
        {
            Damage = damage;
        }
    }
}
