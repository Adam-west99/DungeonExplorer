using System.Collections.Generic;

namespace DungeonExplorer
{
    public class Player
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        private List<string> inventory ;

        public Player(string name, int health = 100) 
        {
            Name = name;
            Health = health;
            inventory = new List<string>();
        }
        public void PickUpItem(string item)
        {
            Console.Writeline("would you like to pick up the item ?")
            string ans = Console.Readline()
            if ans.upper == "YES"
                inventory.Add(item)
            
            
        }
        public void Displaystatus ()
        {
            console.writeline($"Player: {name}, Health:{health} ,  Inventory; {string.Join(", ", inventory);}")
        }
        public string InventoryContents()
        {
            return string.Join(", ", inventory);
        }
    }
}