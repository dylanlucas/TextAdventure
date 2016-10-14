using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH8P1
{
    public partial class Form1 : Form
    {
        //Initialize the Player Object
        Player playerOne = new Player();

        //Initialize the Bag Object
        //Bag playerBag = new Bag();
        List<Bag> playerBag = new List<Bag>();

        //Initialize the List Objects
        //List<Room> rooms = new List<Room>();
        //List<Item> bag = new List<Item>();
        List<Object> objects = new List<Object>();

        //Initialize Rooms;
        Room r1 = new Room();
        Room r2 = new Room();
        Room r3 = new Room();
        Room r4 = new Room();
        Room r5 = new Room();
        Room r6 = new Room();
        Room r7 = new Room();
        Room r8 = new Room();
        Room r9 = new Room();
        Room r10 = new Room();
        Room r11 = new Room();
        Room r12 = new Room();

        //Initialize Objects;
        Object obj1 = new Object();
        Object obj2 = new Object();
        Object obj3 = new Object();
        Object obj4 = new Object();

        //Set up the players bag items
        Bag itemOne = new Bag();
        Bag itemTwo = new Bag();
        Bag itemThree = new Bag();
        Bag itemFour = new Bag();

        //Set up the Chest Objects
        Chest chest1 = new Chest();

        public Form1()
        {
            InitializeComponent();

            //Setup the rooms & objects per room
            
            //Room r1 = new Room();
            r1.roomID = 0;
            r1.roomName = "Bed Room\n";
            r1.roomDescription = "You've just awoken in an unfamiliar area. The only light source you have is the candle to your left that is shines just enough for you to nice you're not at your home.\n" +
                                 "\nYou see that the only exit around is the one to the south of the room.\n" +
                                 "\nYou should probably take the candle incase the rest of wherever you are is to dark to see....\n\n";
            r1.northExit = false;
            r1.eastExit = false;
            r1.southExit = true;
            r1.westExit = false;

            obj1.itemID = 1;
            obj1.itemName = "\nCandle";
            obj1.itemDescription = "\nA small candle with a dim light emitting from it.\n";
            obj1.itemLocation = 0;

            r1.objectsInRoom = obj1;

            r2.roomID = 1;
            r2.roomName = "\nHallway\n";
            r2.roomDescription = "You've left the Bed Room and are now in a hallway. You can see to your left and right a bit and notice that there are many doors, most closed, but one wide open with a flickering light coming from it.\n" +
                                 "\nYou see that there are four exits around you, one to your North, East, South, and West.\n";
            r2.northExit = true;
            r2.eastExit = true;
            r2.southExit = true;
            r2.westExit = true;
            
            r3.roomID = 2;
            r3.roomName = "\nBathroom\n";
            r3.roomDescription = "You've left the hallway and have entered a Bathroom. You look around and see stains all around the walls. Not only do you see the stains but you smell something horrendous. You start to feel sick.\n" +
                                  "After looking around you see that there is a piece of glass from the mirror that can easily be taken and used as a weapon?..\n";
            r3.northExit = false;
            r3.eastExit = false;
            r3.southExit = true;
            r3.westExit = false;

            obj2.itemID = 2;
            obj2.itemName = "\nPiece of Glass";
            obj2.itemDescription = "\nA piece of the mirror that was laying on the sink in the Bathroom. Looks pretty sharp. Be careful with it.\n";
            obj2.itemLocation = 2;

            r4.roomID = 3;
            r4.roomName = "\nStairwell\n";
            r4.roomDescription = "You've found a stairwell, you can either go north which would lead you upstairs into an attic maybe?, or you can go south which would lead you downstairs to maybe the first level of the floor?, its hard to tell there is no direction here.\n";
            r4.northExit = true;
            r4.eastExit = false;
            r4.southExit = true;
            r4.westExit = true;

            r5.roomID = 4;
            r5.roomName = "\nRoom with a TV\n";
            r5.roomDescription = "You decided to go towards the room with the flickering light. You entered the room and notice that there was a TV on with no signal, just the black and white static.\n";
            r5.northExit = false;
            r5.eastExit = true;
            r5.southExit = false;
            r5.westExit = false;

            obj3.itemID = 3;
            obj3.itemName = "\nKey";
            obj3.itemDescription = "\nA bronze key, could unlock something...\n";
            obj3.itemLocation = 4;

            r6.roomID = 5;
            r6.roomName = "\nThe Attic\n";
            r6.roomDescription = "You decided to go up the stairwell and have found yourself in an attic. You see tons of boxes and old paintings.\n";
            r6.northExit = false;
            r6.eastExit = false;
            r6.southExit = true;
            r6.westExit = false;

            obj4.itemID = 4;
            obj4.itemName = "\nChest";
            obj4.itemDescription = "\nA big wooden chest... probably contains something..\n";
            obj4.itemLocation = 5;

            r7.roomID = 6;
            r7.roomName = "\nFirst Floor Stairwell\n";
            r7.roomDescription = "\nYou decided to go down the stairwell and have found yourself in the first floor stairwell of this house... or you think so the stairs don't lead further down.\n";
            r7.northExit = true;
            r7.eastExit = false;
            r7.southExit = false;
            r7.westExit = true;

            r8.roomID = 7;
            r8.roomName = "\nFirst Floor Lobby\n";
            r8.roomDescription = "\nYou entered the first floor Lobby area, you see a door infront of you and to both sides of the room. It resembles the Hallway you entered when you left the first room.\n";
            r8.northExit = true;
            r8.eastExit = true;
            r8.southExit = true;
            r8.westExit = true;

            r9.roomID = 8;
            r9.roomName = "\nThe Kitchen\n";
            r9.roomDescription = "\nYou smell something wonderful cooking in this room but aren't sure of what it is. It is clear now that you are in the Kitchen.\n";
            r9.northExit = false;
            r9.eastExit = false;
            r9.southExit = true;
            r9.westExit = false;

            r10.roomID = 9;
            r10.roomName = "\nThe Boss Room\n";
            r10.roomDescription = "\nYou found the main person... creature... thing that lives here he's sleeping away.. You see a key next to him... you could try and take it.. its probably useful.\n";
            r10.northExit = false;
            r10.eastExit = true;
            r10.southExit = false;
            r10.westExit = false;

            r11.roomID = 10;
            r11.roomName = "\nThe House Exit\n";
            r11.roomDescription = "\nYou finally escaped whatever this weird place you were in... its time for you to get back home.\n";
            r11.northExit = true;
            r11.eastExit = true;
            r11.southExit = true;
            r11.westExit = true;

            r12.roomID = 11;
            r12.roomName = "\nAbyss\n";
            r12.roomDescription = "\nThere is no where to go from here.\n";
            r12.northExit = false;
            r12.eastExit = false;
            r12.southExit = false;
            r12.westExit = false;


            playerOne.currentLocation = r1;
        }

        private void userInputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {

            //Movement System between all 12 Rooms.

            if (playerOne.currentLocation == r1)
            {
                if (userInputTextBox.Text.ToLower() == "go north")
                {
                    mainRichTextBox.Text += "\nThere is no North exit.\n";
                }
                else if (userInputTextBox.Text.ToLower() == "go east")
                {
                    mainRichTextBox.Text += "\nThere is no East exit.\n";
                }
                else if (userInputTextBox.Text.ToLower() == "go south")
                {
                    playerOne.currentLocation = r2;
                    mainRichTextBox.Text += "\nYou went South.\n";
                }
                else if (userInputTextBox.Text.ToLower() == "go west")
                {
                    mainRichTextBox.Text += "\nThere is no West exit.\n";
                }
            }
            else if(playerOne.currentLocation == r2)
            {
                if (userInputTextBox.Text.ToLower() == "go north")
                {
                    playerOne.currentLocation = r3;
                    mainRichTextBox.Text += "\nYou went North.\n";
                }
                else if (userInputTextBox.Text.ToLower() == "go east")
                {
                    playerOne.currentLocation = r4;
                    mainRichTextBox.Text += "\nYou went East.\n";
                }
                else if (userInputTextBox.Text.ToLower() == "go south")
                {
                    playerOne.currentLocation = r1;
                    mainRichTextBox.Text += "\nYou went South.\n";
                }
                else if (userInputTextBox.Text.ToLower() == "go west")
                {
                    playerOne.currentLocation = r5;
                    mainRichTextBox.Text += "\nYou went West.\n";
                }
            }
            else if(playerOne.currentLocation == r3)
            {
                if (userInputTextBox.Text.ToLower() == "go north")
                {
                    mainRichTextBox.Text += "\nThere is no North exit.\n";
                }
                else if (userInputTextBox.Text.ToLower() == "go east")
                {
                    mainRichTextBox.Text += "\nThere is no East exit.\n";
                }
                else if (userInputTextBox.Text.ToLower() == "go south")
                {
                    playerOne.currentLocation = r2;
                    mainRichTextBox.Text += "\nYou went South.\n";
                }
                else if (userInputTextBox.Text.ToLower() == "go west")
                {
                    mainRichTextBox.Text += "\nThere is no West exit.\n";
                }
            }
            else if(playerOne.currentLocation == r4)
            {
                if (userInputTextBox.Text.ToLower() == "go north")
                {
                    playerOne.currentLocation = r6;
                    mainRichTextBox.Text += "\nYou went North.\n";
                }
                else if (userInputTextBox.Text.ToLower() == "go east")
                {
                    mainRichTextBox.Text += "\nThere is no East exit.\n";
                }
                else if (userInputTextBox.Text.ToLower() == "go south")
                {
                    playerOne.currentLocation = r7;
                    mainRichTextBox.Text += "\nYou went South.\n";
                }
                else if (userInputTextBox.Text.ToLower() == "go west")
                {
                    playerOne.currentLocation = r2;
                    mainRichTextBox.Text += "\nYou went West.\n";
                }
            }
            else if(playerOne.currentLocation == r5)
            {
                if (userInputTextBox.Text.ToLower() == "go north")
                {
                    mainRichTextBox.Text += "\nThere is no North exit.\n";
                }
                else if (userInputTextBox.Text.ToLower() == "go east")
                {
                    playerOne.currentLocation = r2;
                    mainRichTextBox.Text += "\nYou went East.\n";
                }
                else if (userInputTextBox.Text.ToLower() == "go south")
                {
                    mainRichTextBox.Text += "\nThere is no South exit.\n";
                }
                else if (userInputTextBox.Text.ToLower() == "go west")
                {
                    mainRichTextBox.Text += "\nThere is no West exit.\n";
                }
            }
            else if(playerOne.currentLocation == r6)
            {
                if (userInputTextBox.Text.ToLower() == "go north")
                {
                    mainRichTextBox.Text += "\nThere is no North exit.\n";
                }
                else if (userInputTextBox.Text.ToLower() == "go east")
                {
                    mainRichTextBox.Text += "\nThere is no East exit.\n";
                }
                else if (userInputTextBox.Text.ToLower() == "go south")
                {
                    playerOne.currentLocation = r4;
                    mainRichTextBox.Text += "\nYou went South.\n";
                }
                else if (userInputTextBox.Text.ToLower() == "go west")
                {
                    mainRichTextBox.Text += "\nThere is no West exit.\n";
                }
            }
            else if(playerOne.currentLocation == r7)
            {
                if (userInputTextBox.Text.ToLower() == "go north")
                {
                    playerOne.currentLocation = r4;
                    mainRichTextBox.Text += "\nYou went North.\n";
                }
                else if (userInputTextBox.Text.ToLower() == "go east")
                {
                    mainRichTextBox.Text += "\nThere is no East exit.\n";
                }
                else if (userInputTextBox.Text.ToLower() == "go south")
                {
                    mainRichTextBox.Text += "\nThere is no South exit.\n";
                }
                else if (userInputTextBox.Text.ToLower() == "go west")
                {
                    playerOne.currentLocation = r8;
                    mainRichTextBox.Text += "\nYou went West.\n";
                }
            }
            else if(playerOne.currentLocation == r8)
            {
                if (userInputTextBox.Text.ToLower() == "go north")
                {
                    playerOne.currentLocation = r9;
                    mainRichTextBox.Text += "\nYou went North.\n";
                }
                else if (userInputTextBox.Text.ToLower() == "go east")
                {
                    playerOne.currentLocation = r7;
                    mainRichTextBox.Text += "\nYou went East.\n";
                }
                else if (userInputTextBox.Text.ToLower() == "go south")
                {
                    playerOne.currentLocation = r11;
                    mainRichTextBox.Text += "\nPlayer went South.\n";
                }
                else if (userInputTextBox.Text.ToLower() == "go west")
                {

                    mainRichTextBox.Text += "\nPlayer went West.\n";
                }
            }
            else if(playerOne.currentLocation == r9)
            {
                if (userInputTextBox.Text.ToLower() == "go north")
                {
                    mainRichTextBox.Text += "\nThere is no North exit.\n";
                }
                else if (userInputTextBox.Text.ToLower() == "go east")
                {
                    mainRichTextBox.Text += "\nThere is no East exit.\n";
                }
                else if (userInputTextBox.Text.ToLower() == "go south")
                {
                    playerOne.currentLocation = r8;
                    mainRichTextBox.Text += "\nPlayer went South.\n";
                }
                else if (userInputTextBox.Text.ToLower() == "go west")
                {

                    mainRichTextBox.Text += "\nThere is no West exit.\n";
                }
            }
            else if(playerOne.currentLocation == r10)
            {
                if (userInputTextBox.Text.ToLower() == "go north")
                {
                    mainRichTextBox.Text += "\nThere is no North exit.\n";
                }
                else if (userInputTextBox.Text.ToLower() == "go east")
                {
                    playerOne.currentLocation = r8;
                    mainRichTextBox.Text += "\nPlayer went East.\n";
                }
                else if (userInputTextBox.Text.ToLower() == "go south")
                {
                    mainRichTextBox.Text += "\nThere is no South exit.\n";
                }
                else if (userInputTextBox.Text.ToLower() == "go west")
                {

                    mainRichTextBox.Text += "\nThere is no West exit.\n";
                }
            }
            else if(playerOne.currentLocation == r11)
            {
                if (userInputTextBox.Text.ToLower() == "go north")
                {
                    playerOne.currentLocation = r8;
                    mainRichTextBox.Text += "\nYou went North.\n";
                }
                else if (userInputTextBox.Text.ToLower() == "go east")
                {
                    mainRichTextBox.Text += "\nYou went East.\n";
                }
                else if (userInputTextBox.Text.ToLower() == "go south")
                {
                    mainRichTextBox.Text += "\nYou went South.\n";
                }
                else if (userInputTextBox.Text.ToLower() == "go west")
                {

                    mainRichTextBox.Text += "\nYou went West.\n";
                }
            }
            else
            {
                mainRichTextBox.Text += "\nEnd the Game.\n";
            }

            //Command Look to see what is in each room

            if (userInputTextBox.Text.ToLower() == "look")
            {
                mainRichTextBox.Text += playerOne.currentLocation.ToString();
            }

            //take Command methods per room for specific items
            //Includes the unlock method to open the chest
            //and Open method to open the unlocked chest

            if (playerOne.currentLocation == r1)
            {
                if (userInputTextBox.Text.ToLower() == "take candle")
                {
                    if (itemOne.bagContains == false)
                    {
                        itemOne.bagItemName = obj1.itemName;
                        itemOne.bagItemDescription = obj1.itemDescription;
                        itemOne.bagContains = true;
                        playerBag.Add(itemOne);
                        mainRichTextBox.Text += "\nYou have taken the Candle and it is now in your inventory.\n";
                    }
                    else
                    {
                        mainRichTextBox.Text += "\nThis item is already in your inventory.\n";
                    }
                }
            }

            if (playerOne.currentLocation == r3)
            {
                if (userInputTextBox.Text.ToLower() == "take glass")
                {
                    if (itemTwo.bagContains == false)
                    {
                        itemTwo.bagItemName = obj2.itemName;
                        itemTwo.bagItemDescription = obj2.itemDescription;
                        itemTwo.bagContains = true;
                        playerBag.Add(itemTwo);
                        mainRichTextBox.Text += "\nYou have taken the piece of Glass and it is now in your inventory.\n";
                    }
                    else
                    {
                        mainRichTextBox.Text += "\nThis item is already in your inventory.\n";
                    }
                }
            }

            if (playerOne.currentLocation == r5)
            {
                if (userInputTextBox.Text.ToLower() == "take key")
                {
                    if (itemThree.bagContains == false)
                    {
                        itemThree.bagItemName = obj3.itemName;
                        itemThree.bagItemDescription = obj3.itemDescription;
                        itemThree.bagContains = true;
                        playerBag.Add(itemThree);
                        mainRichTextBox.Text += "\nYou have taken the Key and it is now in your inventory.\n";
                    }
                    else
                    {
                        mainRichTextBox.Text += "\nThis item is already in your inventory.\n";
                    }
                }
            }

            if (playerOne.currentLocation == r6)
            {
                if (userInputTextBox.Text.ToLower() == "unlock chest") 
                {
                    if (chest1.isUnlocked == false)
                    {
                        if (itemThree.bagContains == true)
                        {
                            chest1.isUnlocked = true;
                            playerBag.Remove(itemThree);
                            itemThree.bagContains = false;
                            mainRichTextBox.Text += "\nYou have unlocked the chest.\n";
                        }
                        else
                        {
                            mainRichTextBox.Text += "\nYou do not have the key to unlock this chest.\n";
                        }
                    }
                    else
                    {
                        mainRichTextBox.Text += "\nThe chest is already unlocked.\n";
                    }
                }
            }

            if (userInputTextBox.Text.ToLower() == "open chest")
            {
                if (chest1.isUnlocked == true)
                {
                    if (itemFour.bagContains == false)
                    {
                        itemFour.bagItemName = "Sword";
                        itemFour.bagItemDescription = "A very shiny, sharp sword.";
                        itemFour.bagContains = true;
                        playerBag.Add(itemFour);
                        mainRichTextBox.Text += "\nYou have taken the Sword and it is now in your inventory.\n";
                    }
                    else
                    {
                        mainRichTextBox.Text += "\nThis item is already in your inventory.\n";
                    }
                }
                else
                {
                    mainRichTextBox.Text += "\nThe chest is not unlocked.\n";
                }
            }

            if (userInputTextBox.Text.ToLower() == "drop candle")
            {
                if (itemOne.bagContains == false)
                {
                    mainRichTextBox.Text += "\nThere is no candle to drop from your bag.\n";
                }
                else
                {
                    playerBag.Remove(itemOne);
                    itemOne.bagContains = false;
                    mainRichTextBox.Text += "\nYou have removed the Candle from your inventory.\n";
                }
            }
            else if(userInputTextBox.Text.ToLower() == "drop glass")
            {
                if(itemTwo.bagContains == false)
                {
                    mainRichTextBox.Text += "\nThere is no glass to drop from your bag.\n";
                }
                else
                {
                    playerBag.Remove(itemTwo);
                    itemTwo.bagContains = false;
                    mainRichTextBox.Text += "\nYou have removed the Glass from your inventory.\n";
                }
            }
            else if(userInputTextBox.Text.ToLower() == "drop key")
            {
                if(itemThree.bagContains == false)
                {
                    mainRichTextBox.Text += "\nThere is no key to drop from your bag.\n";
                }
                else
                {
                    playerBag.Remove(itemThree);
                    itemThree.bagContains = false;
                    mainRichTextBox.Text += "\nYou have removed the Key from your inventory.\n";
                }
            }
            else if(userInputTextBox.Text.ToLower() == "drop sword")
            {
                if(itemFour.bagContains == false)
                {
                    mainRichTextBox.Text += "\nThere is no sword to drop from your bag.\n";
                }
                else
                {
                    playerBag.Remove(itemFour);
                    itemFour.bagContains = false;
                    mainRichTextBox.Text += "\nYou have removed the Sword from your inventory.\n";
                }
            }

            if (userInputTextBox.Text == "inventory")
            {

                // IF YOU HAVE ITEM ONE BUT NOT CERTAIN OTHER ITEMS

                if (itemOne.bagContains == false && itemTwo.bagContains == false && itemThree.bagContains == false && itemFour.bagContains == false)
                {
                    mainRichTextBox.Text += "\nYou don't have anything in your inventory.\n";
                }
                else if (itemOne.bagContains == true && itemTwo.bagContains == true && itemThree.bagContains == true && itemFour.bagContains == true)
                {
                    mainRichTextBox.Text += itemOne.ToString();
                    mainRichTextBox.Text += itemTwo.ToString();
                    mainRichTextBox.Text += itemThree.ToString();
                    mainRichTextBox.Text += itemFour.ToString();
                }
                else if (itemOne.bagContains == true && itemTwo.bagContains == true && itemThree.bagContains == true && itemFour.bagContains == false)
                {
                    mainRichTextBox.Text += itemOne.ToString();
                    mainRichTextBox.Text += itemTwo.ToString();
                    mainRichTextBox.Text += itemThree.ToString();
                }
                else if (itemOne.bagContains == true && itemTwo.bagContains == true && itemThree.bagContains == false && itemFour.bagContains == false)
                {
                    mainRichTextBox.Text += itemOne.ToString();
                    mainRichTextBox.Text += itemTwo.ToString();
                }
                else if (itemOne.bagContains == true && itemTwo.bagContains == false && itemThree.bagContains == false && itemFour.bagContains == false)
                {
                    mainRichTextBox.Text += itemOne.ToString();
                }
                else if (itemOne.bagContains == true && itemTwo.bagContains == false && itemThree.bagContains == true && itemFour.bagContains == true)
                {
                    mainRichTextBox.Text += itemOne.ToString();
                    mainRichTextBox.Text += itemThree.ToString();
                    mainRichTextBox.Text += itemFour.ToString();
                }
                else if (itemOne.bagContains == true && itemTwo.bagContains == false && itemThree.bagContains == false && itemFour.bagContains == true)
                {
                    mainRichTextBox.Text += itemOne.ToString();
                    mainRichTextBox.Text += itemFour.ToString();
                }
                else if (itemOne.bagContains == true && itemTwo.bagContains == false && itemThree.bagContains == true && itemFour.bagContains == false)
                {
                    mainRichTextBox.Text += itemOne.ToString();
                    mainRichTextBox.Text += itemThree.ToString();
                }
                else if (itemOne.bagContains == true && itemTwo.bagContains == true && itemThree.bagContains == false && itemFour.bagContains == true)
                {
                    mainRichTextBox.Text += itemOne.ToString();
                    mainRichTextBox.Text += itemThree.ToString();
                    mainRichTextBox.Text += itemFour.ToString();
                }

                //IF YOU HAVE ITEM TWO BUT NOT CERTAIN OTHER ITEMS

                else if(itemOne.bagContains == false && itemTwo.bagContains == true && itemThree.bagContains == true && itemFour.bagContains == true)
                {
                    mainRichTextBox.Text += itemTwo.ToString();
                    mainRichTextBox.Text += itemThree.ToString();
                    mainRichTextBox.Text += itemFour.ToString();
                }
                else if (itemOne.bagContains == false && itemTwo.bagContains == true && itemThree.bagContains == true && itemFour.bagContains == false)
                {
                    mainRichTextBox.Text += itemTwo.ToString();
                    mainRichTextBox.Text += itemThree.ToString();
                }
                else if (itemOne.bagContains == false && itemTwo.bagContains == true && itemThree.bagContains == false && itemFour.bagContains == true)
                {
                    mainRichTextBox.Text += itemTwo.ToString();
                    mainRichTextBox.Text += itemFour.ToString();
                }
                else if (itemOne.bagContains == false && itemTwo.bagContains == true && itemThree.bagContains == false && itemFour.bagContains == false)
                {
                    mainRichTextBox.Text += itemTwo.ToString();
                }
                
                // IF YOU HAVE ITEM THREE BUT NOT CERTAIN OTHER ITEMS

                else if(itemOne.bagContains == false && itemTwo.bagContains == false && itemThree.bagContains == true && itemFour.bagContains == true)
                {
                    mainRichTextBox.Text += itemThree.ToString();
                    mainRichTextBox.Text += itemFour.ToString();
                }
                else if (itemOne.bagContains == false && itemTwo.bagContains == false && itemThree.bagContains == true && itemFour.bagContains == false)
                {
                    mainRichTextBox.Text += itemThree.ToString();
                }

                // IF YOU HAVE ITEM FOUR BUT NOT CERTAIN OTHER ITEMS

                else if (itemOne.bagContains == false && itemTwo.bagContains == false && itemThree.bagContains == false && itemFour.bagContains == true)
                {
                    mainRichTextBox.Text += itemFour.ToString();
                }
            }

            if (userInputTextBox.Text.ToLower() == "help")
            {
                mainRichTextBox.Text += "\nThe list of available commands for you to use are : \n" +
                                        "Go North\n" +
                                        "Go East\n" +
                                        "Go South\n" +
                                        "Go West\n" +
                                        "Look\n" +
                                        "Take\n" +
                                        "Drop\n" +
                                        "Unlock\n" +
                                        "Open\n" +
                                        "Inventory\n";
            }

            userInputTextBox.Focus();
            userInputTextBox.Text = "";
        }
    }
}
