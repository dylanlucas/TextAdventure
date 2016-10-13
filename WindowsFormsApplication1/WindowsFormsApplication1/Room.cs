using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Room
    {
        public int roomID { get; set; }
        public string roomName { get; set; }
        public string roomDescription { get; set; }
        public List<Exit> Exits { get; set; }

        public Room()
        {
            // Initialize the Exits
            Exits = new List<Exit>();
            for (int i = 0; i < 4; i++)
            {
                Exit exit = new Exit();
                exit.exitID = i;
                exit.exitLocation = -1;
                Exits.Add(exit);
            }
        }
    }

    public class Exit
    {
        public int exitID { get; set; }
        public int exitLocation { get; set; }

        public const int NORTH = 0;
        public const int EAST = 1;
        public const int SOUTH = 2;
        public const int WEST = 3;
    }
}
