using System;

namespace DungeonExplorer
{
    public class Inventory
  {
      private List<Item> items = new List<Item>();

      public void AddItem(Item item) => items.Add(item);
      public void RemoveItem(Item item) => items.Remove(item);
      public IEnumerable<T> GetItemsOfType<T>() where T : Item => items.OfType<T>();
  }
}
