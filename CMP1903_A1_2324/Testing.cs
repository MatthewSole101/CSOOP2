using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{   
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method
        //
        public static void Main(string[] args)
        {
            

            //Created a Game and SevensOut object
            Game gm = new Game();
            SevensOut so = new SevensOut();
            Statistics stats = new Statistics();

            //Call the myMethod method and saving its return in Roll which is a tuple

            int totalroll = 0;
            bool isExit = false;
            
            Console.WriteLine("Do you want to play SevensOut(1) or Three or More(2)?: ");
            int gameChoice = Convert.ToInt32(Console.ReadLine());
            
            if (gameChoice == 1)
            {
                while (isExit == false) 
                {
                    var Roll = so.game();
                    if (Roll.Item1 != 7 )
                    {
                        if (Roll.Item1 != Roll.Item2)
                        {
                            totalroll = Roll.Item1 + Roll.Item2;
                            stats.playerStat(totalroll);
                            Console.WriteLine("Dice rolled are: " + Roll.Item1 + " and " + Roll.Item2);
                        
                        }
                    }

                    if ( Roll.Item1 == Roll.Item2 )
                    {
                        totalroll = (Roll.Item1 * 2) + (Roll.Item1 * 2);
                        stats.playerStat(totalroll);
                        Console.WriteLine("Dice rolled are: " + Roll.Item1 + " and " + Roll.Item2);
                    }
                    if (Roll.Item1 == 7)
                    {
                        stats.playerStat(Roll.Item1);
                        Console.WriteLine("Die rolled are: " + Roll.Item1);
                    }
                    Console.WriteLine("Do you want to continue(yes/no)?: ");
                    string userExit = Console.ReadLine();

                    if (userExit == "no" || userExit == "No")
                    {
                        isExit = true;
                    }
                    if (userExit == "yes" || userExit == "Yes")
                    {
                        isExit = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!!");
                    }

                }
            }
            
            

            //Getting the total so I can verify it in the Debug.Assert

            //Debugging

            // Debug.Assert(Roll.Item1 < 7 && Roll.Item1 > 0, "Roll 1 is not between 1 and 6");
            //
            // Debug.Assert(Roll.Item2 < 7 && Roll.Item2 > 0, "Roll 2 is not between 1 and 6" );
            //
            // Debug.Assert(Roll.Item3 < 7 && Roll.Item3 > 0, "Roll 3 is not between 1 and 6");
            //


        }


    }
}