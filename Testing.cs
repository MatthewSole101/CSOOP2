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
            

            //Created a Game and SevensOut and stats object
            Game gm = new Game();
            SevensOut so = new SevensOut();
            ThreeOrMore tom = new ThreeOrMore();
            
            
            SevensOutStatistics mySevensOutStatisticsstats = new SevensOutStatistics();
            ThreeOrMoreStatistics myThreeOrMoreStatistics = new ThreeOrMoreStatistics();

            CheckStats SevensOutmenuStats = new CheckStats();
            CheckStatsThreeOrMore ThreeOrMoremenuStats = new CheckStatsThreeOrMore();
            
            bool menuExit = false;
            

            //Call the myMethod method and saving its return in Roll which is a tuple

            int totalroll = 0;
            

            int player1totalscore = 0;
            int player2totalscore = 0;
            int gameChoice = 0;
            while (menuExit == false)
            {
                bool isExit = false;
                bool sevensOutexit = false;


                try
                {
                    Console.WriteLine("---------------------------------------------------------------------------------");
                    Console.WriteLine("Do you want to play SevensOut(1) or Three or More(2) or check statistics(3)?: ");
                    gameChoice = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input");
                    Console.WriteLine("Try again");
                }
                
                
                if (gameChoice == 1)
                {
                    
                    while (isExit == false) 
                    {
                        var Player1Roll = so.Player1game();
                        var Player2Roll = so.Player2game();

                        int player1CheckSeven = Player1Roll.Item1 + Player1Roll.Item2;
                        int player2CheckSeven = Player2Roll.Item1 + Player2Roll.Item2;

                        if (player1CheckSeven == 7)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Player 1 die rolled are: " + Player1Roll.Item1 + " and " + Player1Roll.Item2);
                            sevensOutexit = true;
                            break;
                            
                        }
                        if (player2CheckSeven == 7)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Player 2 die rolled are: " + Player2Roll.Item1 + " and " + Player2Roll.Item2);
                            sevensOutexit = true;
                            break;
                            
                        }
                        
                        
                        if (Player1Roll.Item1 != 7 || Player2Roll.Item1 != 7)
                        {
                            if (Player1Roll.Item1 != 7)
                            {
                                if (Player1Roll.Item1 != Player1Roll.Item2)
                                {
                                    totalroll = Player1Roll.Item1 + Player1Roll.Item2;
                                    player1totalscore = mySevensOutStatisticsstats.Player1Stat(totalroll, false);
                                    Console.WriteLine("");

                                    Console.WriteLine("Player 1 die rolled are: " + Player1Roll.Item1 + " and " + Player1Roll.Item2);

                                }
                            }

                            if (Player2Roll.Item1 != 7)
                            {
                                if (Player2Roll.Item1 != Player2Roll.Item2)
                                {
                                    totalroll = Player2Roll.Item1 + Player2Roll.Item2;
                                    player2totalscore = mySevensOutStatisticsstats.Player2Stat(totalroll, false);
                                    Console.WriteLine("Player 2 die rolled are: " + Player2Roll.Item1 + " and " + Player2Roll.Item2);
                            
                                }
                            }
                           
                        }

                        if ( Player1Roll.Item1 == Player1Roll.Item2 ||Player2Roll.Item1 == Player2Roll.Item2)
                        {
                            if ( Player1Roll.Item1 == Player1Roll.Item2) 
                            {
                                totalroll = (Player1Roll.Item1 * 2) + (Player1Roll.Item1 * 2);
                                player1totalscore = mySevensOutStatisticsstats.Player1Stat(totalroll, false);                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("Player 1 die rolled are: " + Player1Roll.Item1 + " and " + Player1Roll.Item2);

                            }
                            if (Player2Roll.Item1 == Player2Roll.Item2)
                            {
                                totalroll = (Player2Roll.Item1 * 2) + (Player2Roll.Item1 * 2);
                                player2totalscore = mySevensOutStatisticsstats.Player2Stat(totalroll, false);
                                Console.WriteLine("Player 2 die rolled are: " + Player2Roll.Item1 + " and " + Player2Roll.Item2);
                            }
                           
                        }
                        

                        
                        while (sevensOutexit == false)
                        {
                            string userStatChoice = "";
                            try
                            {
                                Console.WriteLine("Do you want to look at your statistics(yes/no)?: ");
                                userStatChoice = Console.ReadLine();
                            }
                            catch
                            {
                                Console.WriteLine("Invalid input");
                                Console.WriteLine("Try again");
                            }
                            

                            

                            if (userStatChoice == "Yes" || userStatChoice == "yes")
                            {
                                mySevensOutStatisticsstats.Player1Stat(0, true);
                                mySevensOutStatisticsstats.Player2Stat(0, true);


                            }
                            if (userStatChoice == "No" || userStatChoice == "no")
                            {
                                
                                break;
                            }
                           
                        }
                        

                    }
                    
                    Console.WriteLine("Player 1's total score is "+ player1totalscore);
                    Console.WriteLine("Player 2's total score is "+ player2totalscore);

                    if (player1totalscore > player2totalscore)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Player 1 is the winner!");
                    }

                    if (player1totalscore < player2totalscore)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Player 2 is the winner!");

                    }

                    if (player1totalscore == player2totalscore)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("It's a draw!");
                    }
                }

                
                
                
                
                
                
                
                
                if (gameChoice == 2)
                {
                    int threeOrMoreplayer1Score = 0;
                    int threeOrMoreplayer2Score = 0;
                    int count = 0;
                    int uniqueNum = 0;


                    
                       
                        while ((threeOrMoreplayer1Score <= 20)  || (threeOrMoreplayer2Score <= 20))
                        {
                            
                            ThreeOrMore tom2 = new ThreeOrMore();

                            if (threeOrMoreplayer1Score < 20)
                            {
                                if (threeOrMoreplayer1Score >= 20)
                                {
                                    break;
                                }

                                string player1exit = "";

                                try
                                {
                                    Console.WriteLine("Do you want to roll(yes/no)?: ");
                                    player1exit = Console.ReadLine();
                                }
                                catch
                                {
                                    Console.WriteLine("Invalid input");
                                    Console.WriteLine("Try again");
                                }
                                
                                

                                if (player1exit == "yes" || player1exit == "Yes")
                                {
                                    bool player1exit2 = false;
                                    while (player1exit2 == false)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("-----Player 1-----");
                                        Console.WriteLine("");
                                        List<int> Player1RollThreeorMore = new List<int>();
                                        uniqueNum = 0;

                                        Player1RollThreeorMore = tom2.Player1game();

                                        for (int i = 0; i < 5; i++)
                                        {
                                            Console.WriteLine(Player1RollThreeorMore[i]);
                                        }

                                        uniqueNum = tom2.checkUnique(Player1RollThreeorMore);



                                        threeOrMoreplayer1Score = myThreeOrMoreStatistics.Player1Stat(uniqueNum, false);
                                    
                                        if (threeOrMoreplayer1Score == 1)
                                        {
                                            player1exit2 = false;
                                    
                                        }
                                        else
                                        {
                                            player1exit2 = true;
                                        }

                                    
                                    
                                        Console.WriteLine("The dice are "+ uniqueNum+ " of a kind.");
                                    
                                        Console.WriteLine("Player 1 has " + threeOrMoreplayer1Score + " points");

                                    }
                                   
                                    
                                }
                                
                                
                                
                                
                            }
                                
                            else
                            {
                                break;
                            }
                            
                            

                            if (threeOrMoreplayer2Score < 20)
                            {
                                if (threeOrMoreplayer1Score >= 20)
                                {
                                    break;
                                }
                                

                                uniqueNum = 0;
                                string player2exit = "";
                                try
                                {
                                    Console.WriteLine("Do you want to continue(yes/no)?: ");
                                    player2exit = Console.ReadLine();
                                }
                                catch
                                {
                                    Console.WriteLine("Invalid input");
                                    Console.WriteLine("Try again");
                                }
                                
                                


                                if (player2exit == "yes" || player2exit == "Yes")
                                {
                                    bool player2exit2 = false;
                                    while (player2exit2 == false)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("-----Player 2-----");
                                        Console.WriteLine("");
                                        
                                        List<int> Player2RollThreeorMore = new List<int>();

                                        Player2RollThreeorMore = tom2.Player2game();
                                    


                                        for (int i = 0; i < 5; i++)
                                        {
                                            Console.WriteLine(Player2RollThreeorMore[i]);
                                        }

                                        uniqueNum = tom2.checkUnique(Player2RollThreeorMore);

                                        threeOrMoreplayer2Score = myThreeOrMoreStatistics.Player2Stat(uniqueNum, false);



                               
                            

                                        if (threeOrMoreplayer2Score == 1)
                                        {
                                            player2exit2 = false;
                                            
                                        
                                        }
                                        else
                                        {
                                            player2exit2 = true;

                                        }
                                    
                                        Console.WriteLine("The dice are "+ uniqueNum+ " of a kind.");
                                        Console.WriteLine("Player 2 has " + threeOrMoreplayer2Score + " points");
                                    }
                                    
                                    
                                }
                               
                            }
                            else
                            {
                                break;
                            }

                            
                        }
                        
                        int player1Score = myThreeOrMoreStatistics.Player1Stat(0, true);
                        int player2Score = myThreeOrMoreStatistics.Player2Stat(0, true);

                        if (player1Score > player2Score)
                        {
                            Console.WriteLine("Player 1 wins!");
                        }
                        if (player1Score < player2Score)
                        {
                            Console.WriteLine("Player 2 wins!");
                        }
                        
                        //Asks the user if they want to play another game
                        

                }

                if (gameChoice == 3)
                {
                    int statChoice = 0;
                    bool isStatChoice = false;
                    while (isStatChoice == false)
                    {
                        try
                        {
                            Console.WriteLine("Do you want to look at SevensOut(1) or ThreeOrMore(2)?: ");
                            statChoice = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input");
                            Console.WriteLine("Try again");
                        }
                       

                        if (statChoice == 1)
                        {
                            SevensOutmenuStats.SevensOutstats();
                            isStatChoice = true;
                        }

                        if (statChoice == 2)
                        {
                            ThreeOrMoremenuStats.ThreeOrMorestats();
                            isStatChoice = true;

                        }
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