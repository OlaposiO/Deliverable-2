using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LabVacation
{
    class Program
    {
        static void Main(string[] args)
        {
            string activity, location, party;
            int a;
           
            
           // Char start, chill, eat, games, dangers, people;

            Console.WriteLine("Hey there! Welcome to Ollie's World! I'm Ollie and I'm here to help you out! What type of adventure are you looking for today? ");
            
            start:
            Console.WriteLine("Chilling, Food, Arcade, or Danger(my favorite)?");
            activity = Console.ReadLine();

            switch (activity)
            
                {
                
                case "Chilling": 
                case "chilling": 
                case "CHILLING":
                    Console.WriteLine("Sounds relaxing!");
                    
                    goto chill;

                case "Food":
                case "food":
                case "FOOD":
                    Console.WriteLine("Food is always a great choice!");
                    
                    goto eat;

                case "Arcade":
                case "arcade":
                case "ARCADE":
                    Console.WriteLine("You can't go wrong with gaming!");
                    
                    goto games;

                case "Danger":
                case "danger":
                case "DANGER":
                    Console.WriteLine("I knew you were awesome! Check out our newest attarction, Danger Island!");
                    goto people;

                default:
                    Console.WriteLine("Sorry, I did get that. What would you like to do?");
                    goto start;
                   
                    }

            chill:
            Console.WriteLine("Great! If " + activity + " is your goal, we have a few options: Spa, beach, or the bar. What do you think?");
            location = Console.ReadLine();


            
            switch (location)

                {

                case "Spa":
                case "spa":
                case "SPA":
                    Console.WriteLine("I could use a massage too at the " + location);
                 
                    goto people;

                case "Beach": 
                case "beach":
                case "BEACH":
                    Console.WriteLine("It's a beautiful day to have sand in your toes at the " + location );
                    
                    
                    goto people;

                case "Bar":
                case "bar":
                case "BAR":
                    Console.WriteLine("I will take a virtual drink with you while you at the " + location);
                    Console.ReadLine();
                    
                    goto people; //dont fotget to make this label at the end


                    default:
                    Console.WriteLine("Sorry, I didn't get that.");
                  
                    goto chill;
            }

            eat:
            Console.WriteLine("For " + activity + " we have American, Mexican, or Italian.You choose!");
            location = Console.ReadLine();
            

            
            switch (location)
                {
                
                case "American":
                case "american":
                case "AMerican":
                    Console.WriteLine("An " + location + " cheeseburger sounds great right about now. ");
                                      
                    goto people;
               
                case "Mexican":
                case "mexican":
                case "MEXICAN":
                    Console.WriteLine("Tacos are my second favorite food! ^__^ ");
                                       
                    goto people;
            
                case "Italian":
                case "italian":
                case "ITALIAN":
                    Console.WriteLine("Did you know pizza is a vegetable! Eat as much as you like guilt free at our " +location + " restaurant");
                                        
                    goto people;
                
    
                default:
                    Console.WriteLine("Sorry, I didn't get that. ");
                    
                    goto eat;
                    }
            
            
            games:
            Console.WriteLine("Sweet! The " + activity + " is huge! And Ollie World has 2! RetroLande or FuturePalace! Which will it be RL or FP?");
            location = Console.ReadLine();
            

            
            switch (location)
                {
                
                case "RL":
                case "rl":
                case "Rl":
                    Console.WriteLine(location + " will have all of old school greats and classics!");                   
                  
                    goto people;
               
                case "FP":
                case "fp":
                case "Fp":
                    Console.WriteLine(location + " is where you will find all of the full dive and VR games.");
                                      
                    goto people;
                                      
    
                default:
                    Console.WriteLine("Sorry, I didn't get that.");
                   
                    goto games;
                    }


            people:
            Console.WriteLine("What is your party size?");
            party = Console.ReadLine();
            a = Convert.ToInt32(party);

            if ((a!=0) && (a<=4))
                { 
                Console.WriteLine("I recommend that you take the under water bullet train!");
                }
            
            if ((a==5) || ((a>=5) && (a<=10)))
                {
                Console.WriteLine("I recommend taking one of our shuttles! ");
                }
            
            if ((a==11) || ((a >= 11) && (a<=100)))
                {
                Console.WriteLine("This is a secret, but we have teleporters for large groups to navigate around Ollie's World!");
                }
            
            if (a>100)
                {Console.WriteLine("This is embrassing lol. Please split your groups so each one is less than 100 ^_^");
                goto people;
                }

            if (a==0)
                {
                Console.WriteLine("You have to count yourself. You are the star of this adventure!");
                goto people;
}

            
            Console.WriteLine("If you need anything else. I am happy to help. Have a good one!");
            Console.ReadLine();

}

        }
    }


