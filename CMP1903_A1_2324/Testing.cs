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
            ThreeOrMore tom = new ThreeOrMore();
            Statistics stats = new Statistics();
            

            //Call the myMethod method and saving its return in Roll which is a tuple

            int totalroll = 0;
            

            bool isExit = false;
            int player1totalscore = 0;
            int player2totalscore = 0;
            
            Console.WriteLine("Do you want to play SevensOut(1) or Three or More(2)?: ");
            int gameChoice = Convert.ToInt32(Console.ReadLine());
            
            if (gameChoice == 1)
            {
                
                while (isExit == false) 
                {
                    var Player1Roll = so.Player1game();
                    var Player2Roll = so.Player2game();
                    

                    
                    if (Player1Roll.Item1 != 7 || Player2Roll.Item1 != 7)
                    {
                        if (Player1Roll.Item1 != 7)
                        {
                            if (Player1Roll.Item1 != Player1Roll.Item2)
                            {
                                totalroll = Player1Roll.Item1 + Player1Roll.Item2;
                                player1totalscore = stats.SevensOutplayer1Stat(totalroll, false);
                                Console.WriteLine("Player 1 die rolled are: " + Player1Roll.Item1 + " and " + Player1Roll.Item2);
                                Console.WriteLine("");

                            }
                        }

                        if (Player2Roll.Item1 != 7)
                        {
                            if (Player2Roll.Item1 != Player2Roll.Item2)
                            {
                                totalroll = Player2Roll.Item1 + Player2Roll.Item2;
                                player2totalscore = stats.SevensOutplayer2Stat(totalroll, false);
                                Console.WriteLine("Player 2 die rolled are: " + Player2Roll.Item1 + " and " + Player2Roll.Item2);
                        
                            }
                        }
                       
                    }

                    if ( Player1Roll.Item1 == Player1Roll.Item2 ||Player2Roll.Item1 == Player2Roll.Item2)
                    {
                        if ( Player1Roll.Item1 == Player1Roll.Item2) 
                        {
                            totalroll = (Player1Roll.Item1 * 2) + (Player1Roll.Item1 * 2);
                            player1totalscore = stats.SevensOutplayer1Stat(totalroll, false);
                            Console.WriteLine("Player 1 die rolled are: " + Player1Roll.Item1 + " and " + Player1Roll.Item2);
                            Console.WriteLine("");

                        }
                        if (Player2Roll.Item1 == Player2Roll.Item2)
                        {
                            totalroll = (Player2Roll.Item1 * 2) + (Player2Roll.Item1 * 2);
                            player2totalscore = stats.SevensOutplayer2Stat(totalroll, false);
                            Console.WriteLine("Player 2 die rolled are: " + Player2Roll.Item1 + " and " + Player2Roll.Item2);
                        }
                       
                    }
                    if (Player1Roll.Item1 == 7 ||Player2Roll.Item1 == 7 )
                    {
                        if (Player1Roll.Item1 == 7)
                        {
                            player1totalscore = stats.SevensOutplayer1Stat(Player1Roll.Item1, false);
                            Console.WriteLine("Player 1 die rolled are: " + Player1Roll.Item1);
                            Console.WriteLine("");

                        }
                        if (Player2Roll.Item1 == 7 )
                        {
                            player2totalscore = stats.SevensOutplayer2Stat(Player2Roll.Item1, false);
                            Console.WriteLine("Player 2 die rolled are: " + Player2Roll.Item1);
                        }
                        
                    }
                    Console.WriteLine("Do you want to look at your statistics");
                    string userStatChoice = Console.ReadLine();

                    if (userStatChoice == "Yes" || userStatChoice == "yes")
                    {
                        stats.SevensOutplayer1Stat(0, true);
                        stats.SevensOutplayer2Stat(0, true);

                        
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
                    // else
                    // {
                    // if(nameof.type = string)
                    //     Console.WriteLine("Invalid input!!");
                    // }

                }
                
                Console.WriteLine("Player 1's total score is "+ player1totalscore);
                Console.WriteLine("Player 2's total score is "+ player2totalscore);

            }

            if (gameChoice == 2)
            {
                int threeOrMoreplayer1Score = 0;
                int threeOrMoreplayer2Score = 0;
                int count = 0;

                // int uniqueNum = 0;
                //
                // List<int>Player1Roll = tom.Player1game();
                // Console.WriteLine("");
                //
                // for (int i = 0; i < 5; i++)
                // {
                //     Console.WriteLine(Player1Roll[i]);
                // }
                //
                // uniqueNum = tom.checkUnique(Player1Roll);
                // uniqueNum = 5 - uniqueNum;
                // if (uniqueNum == 4)
                // {
                //     uniqueNum = uniqueNum - 1;
                // }
                //
                // threeOrMoreplayer1Score = stats.ThreeOrMorePlayer1Stat(uniqueNum, false);
                // Console.WriteLine("It has " +uniqueNum +" unique numbers");
                // Console.WriteLine("The dice are "+ uniqueNum+ " of a kind.");

                

                    while (threeOrMoreplayer1Score < 20 )
                    {
                        ThreeOrMore tom2 = new ThreeOrMore();
                        List<int> Player1RollThreeorMore = new List<int>();

                        Player1RollThreeorMore = tom2.Player1game();

                        int uniqueNum = 0;
                
                        Console.WriteLine("");
    
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine(Player1RollThreeorMore[i]);
                        }
                        Console.WriteLine(threeOrMoreplayer1Score);

                        uniqueNum = tom.checkUnique(Player1RollThreeorMore);
                        uniqueNum = 5 - uniqueNum;
                        if (uniqueNum == 4)
                        {
                            uniqueNum = uniqueNum - 1;
                        }
                        
                        threeOrMoreplayer1Score = stats.ThreeOrMorePlayer1Stat(uniqueNum, false);
                        Console.WriteLine("The dice are "+ uniqueNum+ " of a kind.");
                    }
                    
                    stats.ThreeOrMorePlayer1Stat(0, true);
                    

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