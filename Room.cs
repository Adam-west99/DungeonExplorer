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
    }
}