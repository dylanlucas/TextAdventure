using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH8P1
{
    class Player
    {
        List<Item> Bag = new List<Item>();

        public double playerHealth { get; set; }
        public double playerArmor { get; set; }
        public double playerAttack { get; set; }
        public String playerBag { get; set; }

        public Player()
        {
            Health = 50.0;
            Armor = 25.0;
            Attack = 1.0;
        }

        public Room currentLocation { get; set; }
        public Item currentItemInventory { get; set; }

        public double Health
        {
            set
            {
                playerHealth = value;
            }
            get
            {
                return playerHealth;
            }
        }

        public double Armor
        {
            set
            {
                playerArmor = value;
            }
            get
            {
                return playerArmor;
            }
        }

        public double Attack
        {
            set
            {
                playerAttack = value;
            }
            get
            {
                return playerAttack;
            }
        }

        override
        public String ToString()
        {
            String output;

            output = playerBag;
            return output;
        }
    }
}
