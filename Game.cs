using System;
using System.Media;

namespace DungeonExplorer
{
    internal class Game
    {
        private Player Player {get; set;}
        private Room Room {get; set;}

        public Game()
        {
            // Initialize the game with one room and one player
           Console.writeline("please inout your name")
           string playname = console.readline()
           player = new Player(name: playname )
           Room = new Room(description: "you are in a dark dungeon with damp air and you can hear the rythm of water dripping")


        }
        public void Start()
        {
            // Change the playing logic into true and populate the while loop
            bool playing = false;
            while (playing)
            {
                Console.WriteLine(Room.GetDescription)
                Player.Displaystatus()
                if (Room.Item != null)
                {
                    Player.PickUpItem();

                }

            }
        }
    }
}