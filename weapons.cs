using System;
using DungeonExplorer.monsters;

namespace DungeonExplorer
{
    public class Weapon : Item
    {
        public int Damage { get; set; }

        public Weapon(string name, int damage)
        {
            Name = name;
            Damage = damage;
        }

        public override void Use(Creature target)
        {
            if (target is IDamageable damageable)
            {
                Console.WriteLine($"Using {Name} to deal {Damage} damage to {target.Name}.");
                damageable.TakeDamage(Damage);
            }
            else
            {
                Console.WriteLine($"{target.Name} cannot be attacked with a weapon.");
            }
        }
    }
}

