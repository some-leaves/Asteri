using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Asteri
{
    public class MacchiPicchu : Show
    {
        

        Player CurrentPlayer { get; set; }

        public string UserResponse = " ";

        public List<string> Inventory = new List<string>();
        //List of room in the game
        private List<Room> Rooms { get; set; }


        //public string PickSeahorse;

        //List of room in the game

        public MacchiPicchu()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Asteria transports the both of you to Machu Picchu where you come face to face with a man." + "\n" + "You and Asteria look at the man strangely and for a moment " + "\n" +
                "Until the man looks and say " + "\n" + "Man: Asteria is that you");

            Console.WriteLine("Asteria has a look of recognition on her face" + "\n" + " Asteria: Marco!" + "\n" +"Asteria runs and jumps into his arms. You look until they stop talking " +
                "animatedly. When they calm down they look over at you " + "\n" + "I'm sorry this is Marco. He's my friend from my home planet. He's here to help lead us to the " +
                "heart. " );

            Console.WriteLine("Marco apologizes for scaring you and gifts you a chain" + "\n" +  "He leads the both of you to through mountains and fields the hike  takes two days to finally get to" +
                "the center." + "\n" +"When you reach it you discover that the heart is in a large hole embedded in the mountain." + "\n" +"Marco: The heart can only be accessed " +
                "by  you Asteria. Your ancestors left this for you because they knew you would come get it." + "\n" + "Marco: I can't go any farther but I'll see you when you get back to" +
                "our planet" + "\n" +"Marco and Asteria hugged and Marco walks away. " + "\n" + "You and Asteria jump down into the hole and met with a pool of water. " + "\n" +"You see that the " +
                "water pools down to two staircase that takes you to the heart.");
            Console.Clear();

                
            ObtainTheHeart();
            




         
        }


        public void ObtainTheHeart()
        {
           // Console.Clear();
            Console.WriteLine("You and Asteria get to the bottom of the stairs where a long walkway leads to the heart." + "\n" +"Asteria walks down the walkway and the light from the heart" +
                "absorbs her." + "\n" +"You are blinded by the shining light but when it dies down Asteria is standing eyes closed and her hand around a glowing light " + "\n" +"You both shared a look" +
                "a moment of silence but then the walkway and altar disappear. " + "\n" +"You and Asteria are falling through the dark and screaming for dear life. Until you get to " +
                "another lake. That leads you through a waterfall and into a streaming river");
            
            Console.WriteLine("Asteria grabs onto a tree branch and hooks you onto the branch so you could  get your footing on land. After you help her up and both of you are sopping wet" +
                "you walk around for a bit to only come to a one realization");
            Console.WriteLine("Asteria: We're lost...aren't we?");

            Console.BackgroundColor = ConsoleColor.Blue;

            Console.WriteLine("You become a little disheartend but you see something off in the distance" + "\n" +"You see something blazing a little bit away from you " +
                "you notice that it becomes bigger and bigger and you realize is coming at you. What do you do?" + " \n" + "A. Run "+ "\n" +"B. Go towards it ");
            UserResponse = Console.ReadLine().ToUpper();
            Console.BackgroundColor = ConsoleColor.White;
            if (UserResponse == "A")
            {//error right here assisted by Karen Spriggs
                Console.WriteLine($" {CurrentPlayer} screams and runs away from the blaze thats coming near you. Asteria following suit runs after you " + " \n" + " You hear a shout " +
                    "behind you and when you look at Asteria she's on the ground and a large animal is over her. You think she's heart until you hear a loud giggle");
                Console.WriteLine("Its' Asteria. The animal and her are...playing." + " \n" +"After a second she gets up and the large animal is still nuzzling into her stomach as she" +
                    "composes herself she looks up" + " \n" +"Asteria: He told me his name is Zephyr and he wants to help us." );
                EscapeTheRuins();
               
            }
            else if (UserResponse == "B")
            {
                Console.WriteLine(" You and Asteria runs toward the blazing light and all of you collide together to end up in a dark place. Asteria huffs" + " /n" +"Asteria: He said" +
                    "his name is Zephyr and he wants to help");
                EscapeTheRuins();



               
            }



            
        }

        public void EscapeTheRuins()
        {
            Console.Clear();
            Console.WriteLine("Get the get the key to get out of the ruins ");
            Console.WriteLine("The light from the heart should help navigate us and our little buddy. ");

            Items rock = new Items("rock");
            Items straw = new Items("straw");
            Items key = new Items("key");

            //Creating rooms
            Room room1 = new Room()
            {
                Name = "First room",
                RoomLoot = new List<Items>() { rock, },
                RequiredItems = null
            };
            Rooms = new List<Room>();
            //Adding room1 room the Room list
            Rooms.Add(room1);

           
            Room room2 = new Room()
            {
                Name = "Second room",
                RoomLoot = new List<Items>() { key },
                RequiredItems = null // new List<Items>() { Hangar }
            };
            Rooms.Add(room2);


           
            Room room3 = new Room()
            {
                Name = "Room 3",
                RoomLoot = new List<Items>() {straw, },
                RequiredItems = null
            };
            Rooms.Add(room3);

            CurrentPlayer = new Player()
            {
                Name = "",
                Inventory = new List<Items>()

            };

            ShowMenu(Rooms);

            Console.Clear();
           // Ending();

            




        }

        public void Ending()
        {
            Console.WriteLine("When you finally get out of the ruins Asteria grabs you and Zephyr and portals back to your house. " + "/n" + "Asteria: It's time for me to go home" +
                "and fufill my mission. But please don't tell anyone about what we did. Do you promise. Y or N");
            UserResponse = Console.ReadLine().ToUpper();

            if (UserResponse == "Y")
            {
                Console.WriteLine("After you swear to her that you won't she gets on Zephyr and leaves." + "/n" + "Couple " +
                "of weeks later you see on the news that there was an anomaly in space.");
               Console.WriteLine($" {CurrentPlayer} : ...Asteria");
                Console.WriteLine("The End ");
               
            }
            else if (UserResponse == "N")
            {
                Console.WriteLine("After you say you won't. Asteria looks at Zephyr and looks back at you and before you could think" +
                    "you see a bright light. When you come back to you have a pounding headache but you're laying down in your bes. Your rollover and go " +
                    "back to sleep");
            }
        }

           


    }

}
