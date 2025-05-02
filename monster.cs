using System;

namespace DungeonExplorer
{
    public class Monster : Creature, IDamageable
    {
        public int AttackPower { get; set; }
        public bool IsAlive => Health > 0;

        public override void Attack(Creature target)
        {
            if (target is IDamageable damageableTarget)
            {
                Console.WriteLine($"{Name} attacks {target.Name} for {AttackPower} damage!");
                damageableTarget.TakeDamage(AttackPower);
            }
            else
            {
                Console.WriteLine($"{target.Name} cannot be attacked.");
            }
        }

        public void TakeDamage(int amount)
        {
            Health -= amount;
            Console.WriteLine($"{Name} takes {amount} damage!");

            if (Health <= 0)
            {
                Health = 0;
                Console.WriteLine($"{Name} has been defeated!");
            }
        }
    }
}

