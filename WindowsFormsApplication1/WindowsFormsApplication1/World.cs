using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class World
    {
        //Create a list of the Available Rooms
        public List<Room> Rooms { get; set; }

        //Player class variables
        public int playerLocation { get; set; }

        public World()
        {
            Rooms = new List<Room>();

            //Initiate the starting location of the player
            playerLocation = 0;
        }

        private void Start()
        {
            //Populate the World with Rooms.
            Room courtyard = new Room();
            courtyard.roomID = 0;
            courtyard.roomName = "Courtyard";
            courtyard.roomDescription = "The front outside area of the Dungeon Manor.";
            courtyard.Exits[Exit.NORTH].exitLocation = 1;
            Rooms.Add(courtyard);

            Room foyer = new Room();
            foyer.roomID = 1;
            foyer.roomName = "Foyer";
            foyer.roomDescription = "The inside entrance to the Dungeon Manor.";
            foyer.Exits[Exit.NORTH].exitLocation = 2;
            foyer.Exits[Exit.SOUTH].exitLocation = 0;
            foyer.Exits[Exit.EAST].exitLocation = 3;
            foyer.Exits[Exit.WEST].exitLocation = 4;
            Rooms.Add(foyer);

            Room hallway = new Room();
            hallway.roomID = 2;
            hallway.roomName = "Hallway";
            hallway.roomDescription = "The long dark hallway leading to the Boss Room.";
            hallway.Exits[Exit.NORTH].exitLocation = 5;
            hallway.Exits[Exit.SOUTH].exitLocation = 1;
            Rooms.Add(hallway);

            Room kitchen = new Room();
            kitchen.roomID = 3;
            kitchen.roomName = "Kitchen";
            kitchen.roomDescription = "Where the creatures that inhabit the Dungeon cook.";
            kitchen.Exits[Exit.WEST].exitLocation = 1;
            Rooms.Add(kitchen);

            Room livingRoom = new Room();
            livingRoom.roomID = 4;
            livingRoom.roomName = "Living Room";
            livingRoom.roomDescription = "Where the creatures get together to spend quality time with one another.";
            livingRoom.Exits[Exit.EAST].exitLocation = 1;
            Rooms.Add(livingRoom);

            Room dungeon = new Room();
            dungeon.roomID = 5;
            dungeon.roomName = "Dungeon";
            dungeon.roomDescription = "The location of where the leader of the creature army exists.";
            dungeon.Exits[Exit.SOUTH].exitLocation = 2;
            Rooms.Add(dungeon);
        }
        
    }
}
