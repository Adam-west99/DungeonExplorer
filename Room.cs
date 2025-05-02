namespace DungeonExplorer
{
    public class Room
    {
        private string description;

        public Room(string description)
        {
            this.description = description;
            Item = "Dagger";
        }

        public string GetDescription()
        {
            return description;
        }
         public string Id { get; set; }
        public List<Monster> Monsters { get; set; } = new List<Monster>();
        public List<Item> Items { get; set; } = new List<Item>();
        public Dictionary<string, string> ConnectedRooms { get; set; } = new();
    }
}
