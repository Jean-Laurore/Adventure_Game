using System;

namespace AdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Jean Laurore
             * 11-22-19
             * Adventure Game
             */

            /* THE MYSTERIOUS NOISE */

            // Setting the background color & title
            // Set up Console UI (CUI)
            Console.Title = "THE MYSTERIOUS NOISE";
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("**** WELCOME TO THE MYSTERIOUS NOISE ****");
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            // wait for enter key to be pressed.
            Console.WriteLine("\r\nPlease press Enter/Return to continue...");
            Console.ReadLine();

            // Start by asking for the user's name:
            Console.Write("\r\nWhat is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");

            //Print the following sentences to the console:
            Console.WriteLine("\r\nIt begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. " +
                "\nDo you go investigate?");

            //Decision making
            Console.Write("Type YES or NO: ");
            string noiseChoice = Console.ReadLine().ToUpper();

            //Adding conditional statement
            if (noiseChoice == "NO")
            {
                Console.WriteLine("\r\nNot much of an adventure if we don't leave our room!");
                Console.WriteLine("THE END.");
                return;
            }
            else if (noiseChoice == "YES")
            {
                Console.WriteLine("\r\nYou walk into the hallway and see a light coming from under a door down the hall. " +
                    "\nYou walk towards it. Do you open it or knock?");
            }

            //Time for our user to make another decision
            Console.Write("OPEN or KNOCK: ");
            string doorChoice = Console.ReadLine().ToUpper();

            //Another conditonal
            if (doorChoice == "KNOCK")
            {
                Console.WriteLine("\r\nA voice behind the door speaks. it says, \"Answer this riddle:\" " +
                    "\n\"Poor people have it. Rich people need it. If you eat it you die. What is it?\" ");

                Console.Write("Type your answer: ");
                string riddleAnswer = Console.ReadLine().ToUpper();

                if (riddleAnswer == "NOTHING")
                {
                    Console.WriteLine("\r\nThe door opens and NOTHING is there. \nYou turn off the light and run back to your room and lock the door.");
                    Console.WriteLine("\r\nTHE END.");
                    return;
                }
                else
                {
                    Console.WriteLine("\r\nYou answered incorrectly. The door doesn't open.");
                    Console.WriteLine("\r\nTHE END.");
                    return;
                }
            }
            else if (doorChoice == "OPEN")
            {
                Console.WriteLine("\r\nThe door is locked! See if one of your three keys will open it.");
                Console.Write("Enter a number (1-3): ");
                string keyChoice = Console.ReadLine().ToUpper();

                //going to use the value of the variable keyChoice for our switch statement case. 
                switch (keyChoice)
                {
                    case "1":
                        Console.WriteLine("\r\nYou choose the first key. Lucky choice! The door opens and NOTHING is there. Strange...");
                        Console.WriteLine("\r\nTHE END.");
                        break;
                    case "2":
                        Console.WriteLine("\r\nYou choose the second key. The door doesn't open.");
                        Console.WriteLine("\r\nTHE END.");
                        break;
                    case "3":
                        Console.WriteLine("\r\nYou choose the third key. The door doesn't open.");
                        Console.WriteLine("\r\nTHE END.");
                        break;
                    default:
                        Console.WriteLine("Wrong key.");
                        break;
                }
            }
        }
    }
}
