using System;

namespace MageBattle
{
    public abstract class Mage
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Defense { get; set; }
        public string Element { get; set; }

        public event EventHandler<MageEventArgs> OnAttack;
        public event EventHandler<MageEventArgs> OnDefend;
        public event EventHandler OnDefeated;

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

        protected virtual void RaiseAttackEvent(Mage target)
        {
            OnAttack?.Invoke(this, new MageEventArgs(target));
        }

        protected virtual void RaiseDefendEvent(int damage)
        {
            OnDefend?.Invoke(this, new MageEventArgs(damage));
        }

        protected virtual void RaiseDefeatedEvent()
        {
            OnDefeated?.Invoke(this, EventArgs.Empty);
        }
    }
}
