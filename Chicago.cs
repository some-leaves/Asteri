using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Asteri
{
    public class Chicago : Show
    {
        Player CurrentPlayer { get; set; }
        public string UserResponse = " ";
        //public string PickSeahorse;
         List<string> Inventory = new List<string>();
        //List of room in the game
        private List<Room> Rooms { get; set; }
       

        public  Chicago()
        {
            Console.WriteLine("Asteria portals you to downtown Chicago right in front of where the artifact is said to be hidden which is inside the Buckinghman Fountain." + "\n" + "She start" +
                "looking at her map and points towards one of the large sculpted fish in the mountain.");


            Console.WriteLine("Asteria: The only way to get in is to find the secret hatch. According to the book it says that there should be a switch inside the mouth of one of the fish " +
                "  so you better get going.");

            Console.WriteLine("When you took off your shoes to step over the border and into the freezing cold water you. which fish do you walk up to?");
            
            
             PickSeahorse();
          

           
          
        }
        
        public void PickSeahorse()
        {

            Console.WriteLine("Pick the seahorse you want to check A, B, C,D");
            UserResponse = Console.ReadLine().ToUpper();
            Console.Clear();

            if (UserResponse == "A")
            {
                Console.WriteLine("You twist the nozzle in the Seahorse but nothing happens. Try another ");
               
                
                PickSeahorse();

            }
            else if (UserResponse == "B")
            {
                Console.WriteLine("You twist the Nozzle and the seahorse sputters then blast you with water. Try again");
               
                PickSeahorse();
            }
            else if (UserResponse == "C")
            {
                Console.WriteLine("You twist the Nozzle inside the seahorse and you hear something behind you start to rumble");
                openedFountain();
            }
            else if (UserResponse == "D")
            {
                Console.WriteLine("No dice. Try again");
                
                PickSeahorse();
            }
           
        }
        public void openedFountain()
        {
            Console.WriteLine("You feel the ground shaking and soon you turn around to see that the fountain has revealed a door. The door looks ancient but still sturdy." + "\n" +
            "Asteria: An entrance! According to the map we should be able to get to the next item through a couple passageways and there is supposed to be a passageway that takes" +
            "you straight down if we find it we can probably make this a lot easier for ourselves.");



            Console.WriteLine("You and Asteria walk into the door and find that the place is dark the door shuts behind you. You walk forward until something hits your shoe");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("Do you pick the item up? Type Y or N");
            UserResponse = Console.ReadLine().ToUpper();

            if (UserResponse == "Y")
            {
                Console.WriteLine("You bend down to inspect what it was and discover that it's a flashlight!");
                Console.WriteLine("You have aquired a Flashlight!");
                Inventory.Add("Flashlight");
                PickedFlashlight();
              

            }
            else if (UserResponse == "N")
            {
                Console.WriteLine("You step over whatever it was and continue down the path. Asteria silently judges you. ");
                Console.Clear();
                NoFlashlight();

            }
            else if (UserResponse != "Y" || UserResponse != "N")
            {
                Console.WriteLine("Pick an option thats given to you");
            }


        }





        public void PickedFlashlight()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("As you walk down the hallway using your  flashlight you see a panel with a switch. When you come across it you notice there is a note. Would you like" +
                "to read it? Type: Y or N ");
            Console.BackgroundColor = ConsoleColor.White;
            UserResponse = Console.ReadLine().ToUpper();
            if (UserResponse == "Y")
            {
                Console.WriteLine("The note reads: Left, Right, Right, Left. This will guide you to your goal. If you stray you lose your soul");
                Console.WriteLine("Asteria: Well that sounds...grim. But we should listen to what it says or something might go awry. ");
                // have them follow it to get the key that will is along the way to the door
                Switch();
                
            }
            else if (UserResponse == "N")
            {
                Console.WriteLine("Asteria: You sure you don't wanna read it? Type Y or N ");
                UserResponse = Console.ReadLine();
                if (UserResponse == "y")
                {
                    Console.WriteLine("you and Asteria continue down the path. ");
                    Console.Write("Objective: Get to the location where the item is being held. ");

                }
                else if (UserResponse == "n")
                {
                    Console.WriteLine("You change your mind and pick up the note which says: Left, Right, Right, Left. This will guide you to your goal. If you stray you lose your soul");
                    Console.WriteLine("Asteria:...okay. So it sounds like we need to follow the directions or something bad may happen to us.");

                }

            }
            else if (UserResponse != "Y" || UserResponse != "N")
            {
                Console.WriteLine("Pick between Y or N please!");
                PickedFlashlight();
            }
        }

        // the consequence of not picking up the flashlight is that now you don't see the note or the switch on the wall so it's basically dark
        public void NoFlashlight()
        {
            Console.WriteLine("you keep going through the dark passageway. ");
            Console.WriteLine("Asteria: Into the dark we go. Though i'm sure this is a bad idea.");
            Console.WriteLine("Your objective is to go through the passgeways to obtain the item for Asteria.");
            passageways();
          
        }
        // use this only for the people who grabbed the flashlight this lets them turn on the lights in the underground tunnels
        public void Switch()
        {

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The note was pinned to a switch. Would you like to activate the switch. Type Y or N ");
           UserResponse = Console.ReadLine().ToUpper();
            if (UserResponse == "Y")
            {
                Console.WriteLine("You flip on the rusty switch and hear a slight murmur before the musty passageway becomes clear as the lights come on slightly flickering.");
                Console.WriteLine("Asteria: Let there be light. This is good! it'll be easier for us to go through these hallways");
                passageways();
            }
            else if (UserResponse == "N")
            {
                Console.WriteLine("you keep moving forward with your flaslight. ");
                passageways();
            }
            else if (UserResponse != "N"||UserResponse != "Y")
            {
                Console.WriteLine("Please choose an appropriate response. TIP: There is said to be a secret passageway you just have to choose it. ");
                Switch();
            }

           

        }

      public void passageways()
      { //here is the catch here this is where the note comes in happy
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Which way would you like to go? L for Left, R for right and D for Down");
           UserResponse = Console.ReadLine().ToUpper();
            //first passage
            if (UserResponse == "L")
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("You head left and start walking down the passageway");
            }
            else if (UserResponse != "L")
            {
                Console.WriteLine("You went into the void. Try again.");
                Console.Clear();
                passageways();

            }
            //2nd passage right answer is R
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You advance to the next passageway. Which direction would you like L, D, or R?");
            Console.BackgroundColor = ConsoleColor.White;
            UserResponse = Console.ReadLine().ToUpper();

            if (UserResponse == "R")
            {
                Console.WriteLine("You head right  and begin walking down the passageway");
                Console.WriteLine("Asteria: The item we're looking for is called a gavanti it's like an anti-matter gyroscope if I use it correctly it will ");
            }
            else if (UserResponse != "R")
            {
                Console.WriteLine("You got bit by a poisonous spider. Try again.");
                Console.Clear();
                passageways();

            }
            //3rd passage way down is the secret passageway just helps you get to your destination faster
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("When you get to the next passageway that is surely bringing you closer to your goal. You feel a certain coldness like a draft was being let in but " +
                "there was no windows. You come to a stop because you have entered a passageway that can take you in three different directions. Where would you like to go. " +
                "Left passage , Right passage or , Down type either L, D, or R ");
            Console.BackgroundColor = ConsoleColor.White;
            UserResponse =  Console.ReadLine().ToUpper();
            if (UserResponse == "L")
            {
                Console.WriteLine("You try to run through the Left passageway but get stuck in a trap. Try Again");
                passageways();
            }
            else if (UserResponse == "R")
            {// tech
                Console.WriteLine("You walk down the right passageway and see that it leads you to stairs that lead you deeper into whats looking more and more like an abandoned cave");
                GrabandGo();
            }
            else if (UserResponse == "D")
            {
                Console.WriteLine("You start to head down the passageway and before you can take another step you the passageway doors slides shut quickly with a slam." + "\n" + "you hear Asteria gasp. " +
                    "You're suprised to because after the door shuts the gound begins to rumble.");
                Console.WriteLine("Asteria: Um! Does Chicago normally have this much seismic activity!?! ");
                Console.WriteLine("After another second the rumbling stops and as you two look ahead you see what appears to be a door opening. at the end of the passageway ");
                Console.Write($"Asteria : {CurrentPlayer}, you don't think this is the secret passageway the note was talking about do you?" );
                Console.Clear();
                SecretPassage();
                


                
            }

            



      }
        //Escape after you grab the item
        public void GrabandGo()
        { // make it so 
            Console.WriteLine("It takes you to...another passageway");

            Console.WriteLine("Asteria sighs. " + "\n" + "Asteria: Oh the stars how long will this continue!" + "\n"+ "She turns to look at you." + "\n" +"Asteria: since the note said that we should go " +
                "left. Just hope its not another stupid passageway." );

            Console.WriteLine("Asteria leads you down another passageway where there is a red striped door wide open. And as you walk in Asteria gasps");

            Console.WriteLine("There it is! The Gavanti!  Millions of years ago my ancestors left it here so that when one of us came back it would be here" +
                "to help. The Gavanti puts things into balance and if I  work it in with the other two. It could balance out the black holes and bring the galaxies back together   ");
            ObtainTheGavanti();


        }


        public void SecretPassage()
        {
            Console.WriteLine("You and Asteria began walking closer to the door that opened. ");
            Console.WriteLine("Your dialogue choices:" + "\n"+ "A. It looks like an elevator" + "\n"+ "B. This could be a trap!" + "\n"+"C. ( Take selfie of yourself with the door)");
            UserResponse = Console.ReadLine().ToUpper();
            //Console.Clear();

            if (UserResponse == "A")
            {
                Console.WriteLine("Asteria: Looks like it. hmm on my planet elevators are ancients we teleport places now.");
                ObtainTheGavanti();
            }
            else if (UserResponse == "B")
            {
                Console.WriteLine(" Asteria: You're right...but we don't have any other way to go.");
                ObtainTheGavanti();


            }
            else if (UserResponse == "C")
            {
                Console.WriteLine("No! don't take pictures this is a  secret mission no one can no we ever did this!");
                ObtainTheGavanti();
                //Asteria points--
            }
            else if (UserResponse != "A"|| UserResponse != "B" || UserResponse != "C")
            {
                Console.WriteLine("Pick a valid option");
                SecretPassage();
            }

            Console.WriteLine("You take the elevator and ride it all the way down. When the elevator door opens you are met  with a red striped door.");

        }



        public void ObtainTheGavanti()
        {
            Console.WriteLine("You enter to see an already opened red striped door. Asteria walk up to it. She looks in and signals for you to wait there. She disappears inside of the room" +
                "for 5 minutes you wait then Asteria emerges.  ");
            Console.WriteLine("Asteria: It looked like someone lived here before it's a apartment.");
            Console.WriteLine("Asteria: There's a locked door in there that we need to get into. According to the map the gavanti should be behind it. But I need something to pick the lock" +
                "Unless you can find the key or a paperclip.");
            Console.Clear();
            Console.WriteLine("Objective: Go and search the rooms and find something that Asteria can pick the lock with. ");
            CurrentPlayer = new Player();
            //Create an empty list to hold the rooms for the game
            Rooms = new List<Room>();

            //Creating items
            Items Bobbypin = new Items("Bobbypin");
            Items Moldybread = new Items("Moldy Bread");

            //Creating rooms
            Room Kitchen = new Room()
            {
                Name = "Kitchen",
                RoomLoot = new List<Items>() {Moldybread},
                RequiredItems = null
            };
            Rooms.Add(Kitchen);


            //Adding kitchen room the Room list
            // Rooms.Add(kitchen);

            
            Room SmallBedroom = new Room()
            {
                Name = "A very small bedroom",
                RoomLoot = new List<Items>() { },
                RequiredItems = null
            };
            Rooms.Add(SmallBedroom);


            Items Lockpick = new Items("Bobbypin");
            Room masterBedroom = new Room()
            {
                Name = "Master Bedroom",
                RoomLoot = new List<Items>() { Bobbypin },
                RequiredItems = null
            };
            Rooms.Add(masterBedroom);



           
            //check to make sure this is correct

            Return();



        }

        public void Return()
        {
            Console.WriteLine("You return back to Asteria");

            Console.Clear();

            Console.Write($"{CurrentPlayer}! Did you find anything useful? " + "\n" + "You nod as you hand her the bobbypin");
            Console.WriteLine("Asteria: Great! give me one second and i'll have this door open faster than you can say Gaia" + "\n" + "She was right because in no time at all" +
                "the door opened and she looked proud of her handiwork. You both walk into the room and there it is.");
            Console.WriteLine("Asteria: There it is the Gavanti! " + "\n " + "As you look onwards you notice that it's behind a glass case you tell Asteria as much,");
            Console.WriteLine("Asteria: Well we could break it with that brick by the door or one of us can go through the vents and try to get to it from there. We don't have much time " +
                "left before daylight comes. ");
            Console.WriteLine("What do you want to do?" + "\n" + "A. Break the glaas " + "\n" + "B. Go through the vents");
            UserResponse = Console.ReadLine().ToUpper();

            if (UserResponse == "A")
            {
                BrokenGlass();
            }
            else if (UserResponse == "B")
            {
                Vents();
            }

        }


        //If you break the glass and answer the questions
        public void BrokenGlass()
        {
            Console.WriteLine("You pick up the brick and look warily at Asteria. You throw the brick to the glass and watches as it completely shatters. A beat later a loud blaring siren" +
                "plays as it gives a very loud and clear message:YOU ARE TRESSPASSING ON FORBIDDEN PROPERTY   ");
            Console.WriteLine("Quicly Asteria puts the Gavanti in her bag and grabs your hand and pulls out her transporter but it doesn't work. Asteria stares in shock. It's only gonna let one" +
                "of us teleport. With no time to decide quickly you and Asteria make a mad dash through the passageway turning left and right until you finally reach the opening of the fountain/");
           

            Console.WriteLine("When you emerge from the fountain . It's surrounded by law enforcement but they aren't dressed as police. Five unmarked cars ars infront of the fountain " +
                "as 10 people stand outside in trench coats all staring at you and Asteria. ");
            Console.WriteLine("Asteria: Look, if they find me here I could get in big trouble here and if they find me I won't be able to get the last one" +
                " and then all this would be for nothing. If thet get hold of me they'll know i'm not from here .My teleporter can only take one person. What do you wanna do. I");
            Console.WriteLine("A. Sacrifice yourself B. Make asteria stay with you.  ");

            //Console.Clear();

           UserResponse = Console.ReadLine().ToUpper();

            if (UserResponse == "A")
            {
                SacrificeYourself();
            }
            else if (UserResponse == "B")
            {
                AsteriaStays();


            }
            else if (UserResponse != "A"|| UserResponse != "B")
            {
                Console.WriteLine("Now you know thats not a valid response");
                Console.Clear();
                BrokenGlass();
            }
           

        }




        public void Vents()
        {
            Console.WriteLine("Asteria goes through the vents to get to the other side. When she emerges on the otherside she  grabs the object but sirens go off. The sirens blare and" +
                "you see that doors start closing, Asteria bags the object and quickly as she could pops out the other side. You and her make your way outside. The fountain rushes with water" +
                "and the sun is just now coming out. You and Asteria run through the city until she gets her transporter working. She flashes the both of you and you wake up in Macchu Picchu");
            new MacchiPicchu();

        }


        public void SacrificeYourself() // Bad ending Asteria erases your mind but you get taken to area 51 and never seen again\

        {
           
            Console.WriteLine(" You look at Asteria and signal her to portal away from here so she could finish her mission. She looksa at you and whispers ' i'm sorry' with remorseful eyes" +
                "she pulls something out of her pocket portals away but the flash is the only thing you could remember."+ "\n"+ "When you come back to you're sitting in a room a pristine" +
                "white room with a barred window. You look outside but it seems that you are in the middle of no where. " + "\n" + "A detective comes into the room and takes a seat across from" +
                "you and starts to question you.");
            Console.WriteLine("The Detective: The girl that was with you where is she now ?");
            Console.WriteLine("You: ...");
            Console.WriteLine("The Detective: What were you doing inside the fountain?");
            Console.WriteLine("You: ...");
            Console.WriteLine("You feel confused because you don't remember anything about a girl and you have no recollection of anything. The only thing that you remember is that you " +
                "were driving to clear your mind. Now you don't know where you are or whats even going on. When you tell the detective as much he looks at you with a hard glare");
            Console.WriteLine("The Detective: Well if you don't remember then I guess you'll be staying here until you do." + "\n" +
                "The detective stands to leave and that was last time you saw him before you were moved to an unknown facility. It's been two weeks since they found you at the fountain"
                + "\n" + "now you are set up in an apartment on a base but you are still a prisioner. You can't leave until you tell them what you know. As you sit on your chair" +
                "you turn the tv to the news to see that the news anchor was talking about a headline.");
            Console.WriteLine("News Anchor: Last night an anomaly was seen in space, scientist have been scrambling to explain it but for now they have no clue on what it might be.");
            Console.WriteLine(" You look onward as the news station shows the shaky footage of the sky. " + "\n" + "You: ...Asteria " + "\n" +"Something tingles in your mind.");

            Console.ReadLine();
            Summary();

        }

        public void Summary()
        {
            Console.Clear();
            Console.Write("You chose to sacrifice yourself so Asteria could finsih her mission. This resulted in you being taken by the U.S government until you give them information" +
                "on the girl that was with you the day you were caught. But Asteria erased your memory in hopes of protecting you and also her mission");

        }


        public void AsteriaStays()
        {
            Console.WriteLine("Asteria looks at you and it's clear she has a question in her eyes if she should stay or go. You hold her hand firmly to let her know your answer" +
                "the detective gets closer and closer ");
            Console.WriteLine("Asteria grips you and does a mad dash across the street. You two twist and turn into the night until she points at the biggest skycraper in Chicago. "
                + "\n"+ "You both run as fast as you could to the Sears Tower. Asteria keeps checking her portal device and checks it." + "\n" + "Asteria: I got a connection!"+ "\n"+
                "Asteria portals both of you away and you see white");
            new MacchiPicchu();
        }
    }
}
