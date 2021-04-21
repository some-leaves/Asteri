using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Asteri
{
    public class Giza : Show
    {

       
        public String UserResponse = " ";
        static Player CurrentPlayer { get; set; }
       public List<string> Inventory = new List<string>();
        
       private List< Room > Rooms { get;  set; }

        public Giza()
        {

            Console.WriteLine("Asteria portals you until the both of you are standing in front of the large pyramids. You were shocked you couldn't believe that you were actually in " +
                "Egypt. You barely knew what was going on but you'll go along with it...for now. Asteria was no better because she was staring in awe as well. But you had to keep moving " +
                "because it was hot in egypt and you had to keep moving to get the artifacts that Asteria wanted");
            

            Console.WriteLine("Asteria: Ok according to this map it says that the artifact is inside the pyramid in a case. I suppose we can't just walk in and take it ? We can go" +
                " at night and sneak in and grab it. ");

            Console.WriteLine(" You and Asteria wait until nightfall. You return back to the Pyramid of Giza and start to go into the main one. You walk up to the pyramid door and " +
                "of course its locked.");

            Console.WriteLine("Asteria: Well we can't walk in through the front door but I researched this place and according to it there are air shafts we can use to get in near the " +
                "top of the pyramid. I know how to make a makeshift grappling hook so if you go and get the items I need I can make it and we can get in ");
            //add color like orange or blue and make inventory system
            Console.WriteLine(" I need a hangar, Rope, and some tape. Think you can handle it? The map tells me there is a town nearby that may have what we need. ");

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("New Objective: Find Hangar, Tape, and Rope");

            Console.WriteLine(" Head into the small town? A. yes B.No");

            UserResponse = Console.ReadLine().ToUpper();


            if (UserResponse == "A")
            {//error right here
                Console.WriteLine($" {CurrentPlayer} heads into the small town");
            }
            else if (UserResponse == "B")
            {
                Console.WriteLine(" Stay by Asteria");
                Console.WriteLine(" Asteria: You know other planets talk about Earth like its a nightmare... I haven't been here long" +
                    "enough to experience it yet. " +
                    "You: Lets hope you don't have to. ");
                Console.WriteLine("You start in on walking to the Small town ");

            }

            Console.Clear();
            Console.WriteLine("Upon entering the small town you see that even though its dark 3  shops are still open " +
                "A book store, A clothing Store, A merchant selling food, and a lone consrruction worker. Where do you want to go?" +
                " A. Book Store B. Clothing Store C. Merchant D.Check Inventory ");
            UserResponse = Console.ReadLine();

            Items Hangar = new Items("Hangar");
            Items Tape = new Items("Duct tape");
            Items Rope = new Items("Long Rope");

            //Creating rooms
            Room BookStore = new Room()
            {
                Name = "The Book Store",
                RoomLoot = new List<Items>() { Tape, },
                RequiredItems = null
            };
            Rooms = new List<Room>();
            //Adding bookstore room the Room list
            Rooms.Add(BookStore);

            Items Book = new Items("Old Book");
            Room ClothingStore = new Room()
            {
                Name = "Clothing Store",
                RoomLoot = new List<Items>() { Hangar, Book },
                RequiredItems = null // new List<Items>() { Hangar }
            };
            Rooms.Add(ClothingStore);


            Items SilverCoin = new Items("A silver Coin");
            Room Merchant = new Room()
            {
                Name = "Merchant",
                RoomLoot = new List<Items>() { SilverCoin, },
                RequiredItems = null
            };
            Rooms.Add(Merchant);

            
            Room Worker = new Room()
            {
                Name = "Construction Worker",
                RoomLoot = new List<Items>() { Rope },
                RequiredItems = null
            };
            Rooms.Add(Worker);

            MeetingUp();
            


            CurrentPlayer = new Player()
            {
                Name = "",
                Inventory = new List<Items>()

            };

            ShowMenu(Rooms);

           
            


        }

        public void MeetingUp()
        {
            Console.WriteLine("Asteria sees you coming back.");

            Console.WriteLine("You hand Asteria The hangar, the rope and the tape ");

            Console.WriteLine("Asteria: yes! " + "\n" + "Asteria turns her back towards you and for a few minutes she's just working. Then she turns around and proudly presents" +
                "a makeshift grappling hook.");

            Console.WriteLine("Asteria: Tadaa! " + "\n" + " Asteria looks so proud of herself that she raises her hand high in the sky and wait for you to high five. Type Y or N");

           UserResponse = Console.ReadLine().ToUpper();

            if (UserResponse == "Y")
            {
                Console.WriteLine("You high five Asteria and she squeals in joy. " + "\n" + "Asteria: Let's break into the pyramids!");
            }
            else if (UserResponse == "N")
            {
                Console.WriteLine("Asteria: you're no fun." + "\n" + "Asteria pouts and her land drops lifelessly by her side. Alright well lets get into the pyramids...I guess.");
            }
            else if (UserResponse != "A" || UserResponse != "B")
            {
                Console.WriteLine("Pick a valid answer");

                MeetingUp();
            }

            Console.WriteLine("You and Asteria take the makeshift grappling hook and make your way inside of the pyramids. You land in the gallery room");

            Console.WriteLine("Asteria: Ok the key to the kings tomb is behind one of these pictures. So pick one. A. B.  C. . D.");

           UserResponse = Console.ReadLine().ToUpper();

            if (UserResponse == "A")
            {
                Console.WriteLine("No key behind it try again!");
                MeetingUp();
            }
            else if (UserResponse == "B")
            {
                Console.WriteLine("No key behind it try again!");
                MeetingUp();
            }
            else if (UserResponse == "C")
            {
                Console.WriteLine("You reach back and feel cold steel touch your hand. You found the key ");
                KingsTomb();
            }
            else if (UserResponse == "D")
            {
                Console.WriteLine(" Not it ! Try Again");
                MeetingUp();
            }
            else if (UserResponse != "A" || UserResponse != "B" || UserResponse != "C" || UserResponse != "D")
            {
              
                
                Console.WriteLine("Pick a valid answer. Stop playing. Is Everything a a joke to you");
                MeetingUp();
            }





        }


        public void KingsTomb()
        {

            Inventory.Add("Tomb Key");

            Console.WriteLine("Now that you have aquired the tomb key. You and Asteria walk to the kings tomb and unlock the door the room is mostly vacant");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Asteria: Hererin the brick lies the immortal sword. I need to obtain it. To finsih my mission" + "\n" + "what shape will you press the bricks in"
                + "\n" + "A. Square" + "\n" +" B.Star" );

            UserResponse = Console.ReadLine().ToUpper();

            if (UserResponse == "A")
            {
                Console.WriteLine("The bricks don't move");
                KingsTomb();
            }
            else if (UserResponse == "B")
            {
                Console.WriteLine("After you trace the pattern on the wall with your finger the bricks begin to move outward and turn in presenting the sword in the stone");
                HighFive();
                finished();

                
            }
            else if (UserResponse != "A" || UserResponse != "B")
            {
                Console.WriteLine("Pick a valid answer");
                Console.Clear();
                KingsTomb();
            }


        }

        public void finished()
        {
            Console.WriteLine("You and Asteria with all your might. Pull the sword out and the bricks start moving back to their original positions.");
            Console.WriteLine("Asteria: This is one of the sacreds my ancestors left behind. The people here can't protect it if they never knew it was here in the first " +
                "place." + "\n" +"Asteria: Ok Next stop Chicago");
            

            new Chicago();
                
            
        }







        








































    }

        
    
}
