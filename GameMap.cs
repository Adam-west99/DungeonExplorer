using system 
namespace DungeonExplorer
{  public class GameMap
  {
      private Dictionary<string, Room> rooms = new Dictionary<string, Room>();

      public void AddRoom(string id, Room room) => rooms[id] = room;
      public Room GetRoom(string id) => rooms.TryGetValue(id, out var room) ? room : null;
  }
}
