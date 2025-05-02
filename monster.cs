
  public class Monster : Creature, IDamageable
  {
      public int AttackPower { get; set; }

      public override void Attack(Creature target)
      {
          // Implement attack logic
      }

      public void TakeDamage(int amount)
      {
          // Implement damage logic
      }
  }
