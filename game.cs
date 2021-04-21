using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Asteri
{
    public class game
    {
       

       
            
        string UserAnswer = "";
           
         

        public game()
        {



            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("You’re driving along an empty road. Watching as the sun says its silent goodnight and the hazy sunset begins to turn darker. " + "\n" +

                "You don’t know where you're going but you’re enjoying the ride. An hour later " +

                "you find yourself still driving around when a beam of pure white falls from the sky and has a rough landing in the woods." + "\n" +

                "It knocks some trees down and when you looked at the city in the distance it was like all the lights were flickering. " + "\n" +

                "You felt the air around you gain some sort of electricity." + "\n" +

                " What do you do?");




            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
            "A.keep driving closer to the woods " + "\n" +
                "B. Park the car and relax ") ;

            Console.BackgroundColor = ConsoleColor.White;
            UserAnswer = Console.ReadLine().ToUpper();

            if (UserAnswer.ToUpper() == "A")
            {
             
                Console.WriteLine("You get out of the car: You start to run towards the crash" + "\n" +

                    " and as you keep getting closer you start to see the smoke arising from the crash site." + "\n" +

                    " You continue towards the crash site as you get closer it becomes smokier and you start getting even closer" + "\n" +

                    " to the point where you are in the clearing you see what looks like a small aircraft. You get freaked out and run back to your car. You sit in it and try to breathe before you go" +

                    "full panic mode. You hear a knock on your car window.");
            }
            else if (UserAnswer.ToUpper() == "B")
            {
                Console.WriteLine("You quickly get back in the car because of how surprised you were you dropped your keys. " + "\n" +

                    "When you grab them and put them into into the car. You try to start your car but it sputters and dies." + "\n" +

                    " You don’t want to get out of the car so you try to contact support but your call keeps dropping. " + "\n" +

                    "Meanwhile since you had your head down you didn’t realize that someone came up to your car.");
            }
            else if(UserAnswer != "A"|| UserAnswer != "B")
            {
                Console.WriteLine("Pick a valid answer!");
                new game();
                
              
            }


            Console.Clear();


            Console.WriteLine("You look up and see a black woman with an afro with literal stars in her eyes. She waves and motions for you to roll your window down." + "\n" +

                "once you did she requested that she get in. You figured that that was the least shocking thing that had happened so you let her in. You watched as she " + "\n" +

                "came around and sat down in the passengar seat. She turns around to you and tells you to drive.  ");

            Console.WriteLine("You: I'm not moving until you tell me whats going on." );

            Console.WriteLine("This..person turns to look at you she stares at you then looks up and looks down with a heavy sigh. ");

            Console.WriteLine("Her: Fine you have 3 questions.");

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine( 
                "A. What just happened? " + "\n" +
                "B. Only 3? " + "\n" +
                "Type either A or B." );
            UserAnswer= Console.ReadLine().ToUpper();



            Console.BackgroundColor = ConsoleColor.White;
            if (UserAnswer.ToUpper() == "A")
            {

                Console.WriteLine("You: What just happened? With the crash and ...you. " + "\n" +
                    "you look back at the crash site expecting to see the large clearing in the woods and the small aircraft but you see nothing but the woods itself." + "\n" +
                    "The trees standing and swaying in the wind like nothing ever happened and no sign of any crash or even the aircraft. You look back at her " + "\n" +
                    "and raise your eyebrow. ");

                Console.WriteLine("Please forgive me . i'm sorry for coming to your planet in such a tacky way. I'm from a place very far from here but i promise I mean no harm" + "\n" +
                    "I am simply a explorer in search of something.  "); //explain more here
            }
            else if (UserAnswer.ToUpper() == "B")
            {
                Console.WriteLine("You: Only 3 Questions?" + "\n" +
                    "Her: well 2 now.");


            }
            else if (UserAnswer.ToUpper() != "A" || UserAnswer.ToUpper() != "B") {
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("You wrong for picking the wrong answer bro.");
                new game();
            }


            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Her: Okay so what else? Final question ");

            Console.WriteLine(
                "A. What are you searching for?" + "\n" +
                "B. Where are you from" + "\n" +
                "C. How did I only get 2 questions now?");
            
            
            UserAnswer = Console.ReadLine().ToUpper();

            if (UserAnswer == "A")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("I am looking for the sacred Celestial Artifacts. They are important for what I plan to do ");
            }
            else if (UserAnswer == "B")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("I am from the Magenallic Cloud Galaxy I reside on a planet named MakeMake. These artifacts will help me with the my quest ");
                
            }
            else if (UserAnswer == "C") {
                Console.BackgroundColor = ConsoleColor.Blue;

                Console.WriteLine("Well now you only have one more so use it wisely.");
               

            }
            else if (UserAnswer != "A"||UserAnswer != "B"|| UserAnswer != "C")
            {
                Console.WriteLine("Choose one of the three choices please!");
           
            }
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("You think hard about what you want to ask as your final question. ");

            Console.WriteLine("Before you could even open your mouth you are interrupted. " + "\n" +

                "Her: Please drive and I will tell you everything as long as you agree to not speak a word of this to anyone. You start up the car and start driving away your mind feels " +

                "like its in a daze. All you wanted was for a nice long drive to relax your mind and now it was even more chaoctic than when you left the house" +

                " She looks at you and you promise to not share with anyone. So she begins " + "\n" +

                "Her: Let me just start from the top. I am from a galaxy far from here. Once there was time where all the galaxies were connected and it was easy to visit them. " + "\n" +

                "and trade with their people. But then space expanded causing a rift between the galaxies now the Milky Way Galaxy is the only Galaxy the people from the cloud " +

                "galaxy can go. They choose not to though because no one interacts with Earth we kinda just cut your planet off because you people are INVASIVE I mean c'mon what's all" + "\n" +

                "this crap floating around your planet. Is this how you guys truly live? ");

           

            Console.WriteLine(" You look at her with a start. You couldn't really defend Earth because she had a point.");

            Console.WriteLine("Her: Where is my manners. What is your name?");

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Type in your name.");

            String PlayerName = Console.ReadLine();

            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine($"Y: My name is {PlayerName}. Whats yours? She turns away and looks out the windshield. " + "\n" +

                $"Her: My name is Asteria. Pleased to meet you {PlayerName}." + "\n" +

                $"You: Well Asteria welcome to Earth." + "\n" +

                $"you and Asteria share a laugh as you drive down the winding Road. ");

         
            Console.WriteLine("You take Asteria to your home. There she pulls out a holograph map that shoots out from her hand." + "\n" +

                "Asteria: Remember those Artifacts I told you about? Well they are 3 and I need to find them in order to connect the galaxies back together. All 3 of them work together" + "\n" +

                "to safely regulate the space of the galaxies but still allow us to passthrough to visit. This is a map of where they are hidden. Once I find them I can leave and start " + "\n" +
                "bridging galaxies back together. Oh you can help! you can even pick where we go first");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
                "Pick a Destination:" + "\n" +

                "A.Pyramids of giza    " + "\n" +

                "B. Chicago, Il "

                );
            Console.BackgroundColor = ConsoleColor.White;
            UserAnswer = Console.ReadLine().ToUpper();

            //Created an conditional statement so the user can choose where they want to go first 
            if ( UserAnswer == "A") {

                new Giza();
            }
            else if (UserAnswer == "B")
            {
                new Chicago();
               // Chicago PickSeahorse = new Chicago();
            }
        
            else if (UserAnswer != "A" || UserAnswer != "B" || UserAnswer != "C")
            {
                Console.WriteLine("Asteria: Alright since you're so indecisive i'm picking");

                new Giza();
                //What I can do here is make it random where she picks
            }
            


















            //   Items selectedItem = Room.RoomLoot[userInputAsNumber - 1];

            //Call the player method to add the item to the inventory
            // CurrentPlayer.PickUpItem(selectedItem);














        }


      

        
    }
}
