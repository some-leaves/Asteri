using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteri
{
    public class Show
    {
       
        //A Player property that holds a reference to the current player
        private Player CurrentPlayer { get; set; }

        //List of room in the game
        private List<Room> Rooms { get; set; }

        //Default constructor to call the setup method
       public Show()
       {
           Setup();
       }

       public void HighFive()
       {
            Console.WriteLine("Press any key to high five asteria ");
            Console.ReadKey(true);
            Console.WriteLine("You and Asteria exitedly high five");
       }

      
        //Sets up all the items, rooms and the current player game.
        public void Setup()
        {
            CurrentPlayer = new Player();
            //Create an empty list to hold the rooms for the game
            Rooms = new List<Room>();

            //Creating items
            Items pbSandwich = new Items("");
            Items cheese = new Items("");
            
            //Creating rooms
            Room kitchen = new Room()
            {
                Name = "",
                RoomLoot = new List<Items>() { },
                RequiredItems = null
            };

            //Adding kitchen room the Room list
           // Rooms.Add(kitchen);

            Items goldRing = new Items("Gold Ring");
            Room kidsBedroom = new Room()
            {
                Name = "Kid's Bedroom",
                RoomLoot = new List<Items>() {  },
                RequiredItems = new List<Items>() {  }
            };
            Rooms.Add(kidsBedroom);


            Items stupidPrize = new Items("Prize");
            Room masterBedroom = new Room()
            {
                Name = "Master Bedroom",
                RoomLoot = new List<Items>() { stupidPrize },
                RequiredItems = new List<Items>() { goldRing }
            };
            Rooms.Add(masterBedroom);

            //Creates a player
            CurrentPlayer = new Player()
            {
                Name = "",
                Inventory = new List<Items>()
               
            };
           


            //Calls the greeting
            //  Greeting();
        }


        //Show the greeting for the game & show the menu
       /* public void Greeting()
        {

            Console.WriteLine("Welcome to the ToEarlyICantThink, what is your name?");

            //Get the user name from the user
            string userInput = Console.ReadLine();
            CurrentPlayer.Name = userInput;

            ShowMenu();
        } 
       */
        //Showing initial game menu options
        public void ShowMenu(List<Room>RoomToDisplay)
        {
            Console.Clear();
           // Console.WriteLine($" {CurrentPlayer.Name}, here is your options");

            Console.WriteLine("1) Look in the Rooms");
            Console.WriteLine("2) Inventory");

            var userInput = Console.ReadKey();
            Console.Clear();

            //Checking to see if player entered the correct input.
            if (userInput.Key == ConsoleKey.D1 || userInput.Key == ConsoleKey.NumPad1)
            {
                ShowRooms(RoomToDisplay);
            }
            else if (userInput.Key == ConsoleKey.D2 || userInput.Key == ConsoleKey.NumPad2)
            {
                Console.WriteLine(" Inventory");
            }
            else
            {
                Console.WriteLine("Pick one of the options");
                ShowMenu(RoomToDisplay);
            }

        }


        public void ShowRooms(List<Room>RoomsToDisplay)
        {
            //Console.Clear();
            Console.WriteLine("Viewing Rooms");

            //Defining a starting number that will increment with the room list
            int index = 1;
           
                //int index = 0;
            foreach (Room room in RoomsToDisplay)
            {
                //Show the room name with the index number
                Console.WriteLine($"{index}) {room.Name}");
                //Increment the index by 1 for the next room
                index++;
            }
            //Adding a manual option for user to select for exiting out this menu
            Console.WriteLine($"{index}) Exit");


            Console.WriteLine($"Where do you want to go? {CurrentPlayer.Name}");

            //Get the user input as a number using a utility function
            int userInputAsNumber = Utility.GetANumberFromUser(index);

            //Check the user made the selection of the last option we manually added to the list
            if (userInputAsNumber == index)
            {
                Console.WriteLine("Good Bye");

                //Show user's inventory before exit
                CurrentPlayer.ShowInventory();

                Environment.Exit(0);
            }

            //Find the room user wants to go to using the number user entered. It needs to be decreased by 1 to accomadate 0 based index of the list. 
            Room selectedRoom = RoomsToDisplay[userInputAsNumber - 1];

            //Calling a method to check and see user has the required items in their inventory.
            bool canUserMoveToThisRoom = MoveToARoom(selectedRoom);

            //If they user has the item, move that room
            if (canUserMoveToThisRoom)
            {
                ShowRoomDetails(selectedRoom, RoomsToDisplay);
            }
            else
            {
                //Shows rooms again
                ShowRooms(RoomsToDisplay);
            }
        }

        //A method to  check and see user has the required items in their inventory.
        public bool MoveToARoom(Room room)
        {
            //Create a bool value - default option is that user has everything required.
            bool userHasRequiredItems = true;

            //Checks if the room has required items or not
            if (room.RequiredItems != null)
            {
                //Going over the list of required items for that room
                foreach (Items item in room.RequiredItems)
                {
                    //If the players inventor does not contain a required item, mark the local variable false.
                    if (!CurrentPlayer.Inventory.Contains(item))
                    {
                        userHasRequiredItems = false;
                        //Show user that they are missing this item
                        Console.WriteLine($"You are missing:{item.Name}");
                    }
                }
            }
            //Return the result
            return userHasRequiredItems;
        }

        //Shows room details (inventory) Rooms to display help by Brendan
        public void ShowRoomDetails(Room room, List<Room>RoomsToDisplay)
        {



            Console.WriteLine($"Welcome to: {room.Name}, here are the item(s) in this room");

            //Defining a starting number that will increment with the room inventory list
            int index = 1;
            foreach (Items item in room.RoomLoot)
            {
                //Show the item name with the index number
                Console.WriteLine($"{index}) {item.Name}");
                index++;
            }
            //Adding a manual option for user to select for exiting out this menu
            Console.WriteLine($"{index}) Exit");
            Console.WriteLine($"What do you want to pick? {CurrentPlayer.Name}");
            int userInputAsNumber = Utility.GetANumberFromUser(index);

            //Check the user made the selection of the last option we manually added to the list
            if (userInputAsNumber == index)
            {
                //User wants to go back to the rooms.
                ShowRooms(RoomsToDisplay);
            }

            //Find the selected item from rooms item list
            Items selectedItem = room.RoomLoot[userInputAsNumber - 1];

            //Call the player method to add the item to the inventory
            CurrentPlayer.PickUpItem(selectedItem);

            //Show room details again so user can pick up other items
            ShowRoomDetails(room, RoomsToDisplay);


        }
    }
}
    

