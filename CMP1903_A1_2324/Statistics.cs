using System;
using System.Runtime.CompilerServices;

namespace CMP1903_A1_2324
{
    public class SevensOutStatistics
    {

        public static int sevensOutPlayer1NumberPlays = 0;
        public static int sevensOutPlayer1HighScore = 0;
        public static int sevensOutPlayer1TotalScore = 0;


        public int Player1Stat(int currentScore = 0, bool userStat = false)
        {
            if (userStat == false)
            {
                sevensOutPlayer1NumberPlays++;
                sevensOutPlayer1TotalScore = currentScore + sevensOutPlayer1TotalScore;
                if (currentScore > sevensOutPlayer1HighScore)
                {
                    sevensOutPlayer1HighScore = currentScore;
                }
                 
            }


            if (userStat == true)
            {
                
                Console.WriteLine("");
                Console.WriteLine("Player 1's high score is: " + sevensOutPlayer1HighScore);
                Console.WriteLine("Player 1 has made " + sevensOutPlayer1NumberPlays + " moves");
            }

            return sevensOutPlayer1TotalScore;

        }

        public static int sevensOutPlayer2NumberPlays = 0;
        public static int sevensOutPlayer2HighScore = 0;
        public static int sevensOutPlayer2TotalScore = 0;

        public int Player2Stat(int currentScore = 0, bool userStat = false)
        {

            if (userStat == false)
            {
                sevensOutPlayer2NumberPlays++;
                sevensOutPlayer2TotalScore = currentScore + sevensOutPlayer2TotalScore;
                if (currentScore > sevensOutPlayer2HighScore)
                {
                    sevensOutPlayer2HighScore = currentScore;
                }
                
            }


            if (userStat == true)
            {
                Console.WriteLine("");
                Console.WriteLine("Player 2's high score is: " + sevensOutPlayer2HighScore);
                Console.WriteLine("Player 2 has made " + sevensOutPlayer2NumberPlays + " moves");
                Console.WriteLine("");

            }

            return sevensOutPlayer2TotalScore;

        }
    }

    class ThreeOrMoreStatistics : SevensOutStatistics
        {
            public  static int threeOrMorePlayer1NumberPlays = 0;
            public  static int threeOrMorePlayer1TotalScore = 0;
            
            //Polymorphism
            public int Player1Stat(int ofAKind = 0, bool userStat = false)
            {
                if (userStat == false)
                {
                    if (ofAKind == 2)
                    {
                        int rethrowChoice = 0;
                        //Error handling
                        try
                        {
                            Console.WriteLine("Do you want to rethrow all?(1): ");
                            rethrowChoice = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input");
                            Console.WriteLine("Try again");
                        }
                        

                        if (rethrowChoice == 1)
                        {
                            Console.WriteLine("Rethrowing all");

                        }


                        return rethrowChoice;
                    }
                    if (ofAKind == 3)
                    {
                        threeOrMorePlayer1TotalScore = threeOrMorePlayer1TotalScore + 3;
                    }
                    if (ofAKind == 4)
                    {
                        threeOrMorePlayer1TotalScore = threeOrMorePlayer1TotalScore + 6;
                    }
                    if (ofAKind == 5)
                    {
                        threeOrMorePlayer1TotalScore = threeOrMorePlayer1TotalScore + 12;
                    }

                    threeOrMorePlayer1NumberPlays++;

                    return threeOrMorePlayer1TotalScore;
                }
                
                

                if (userStat == true)
                {
                    Console.WriteLine("");

                    Console.WriteLine("Player 1 has "+ threeOrMorePlayer1TotalScore + " score.");
                    Console.WriteLine("Player 1 has " + threeOrMorePlayer1NumberPlays + " plays.");
                    Console.WriteLine("");
                    return threeOrMorePlayer1TotalScore;

                }
                return threeOrMorePlayer1TotalScore;

               
            }
            public static int threeOrMorePlayer2NumberPlays = 0;
            public static int threeOrMorePlayer2TotalScore = 0;
            
            public int Player2Stat(int ofAKind = 0, bool userStat = false)
            {
                if (userStat == false)
                {
                    if (ofAKind == 2)
                    {
                        int rethrowChoice = 0;
                        try
                        {
                            Console.WriteLine("Do you want to rethrow all?(1): ");
                            rethrowChoice = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input");
                            Console.WriteLine("Try again");
                        }

                        return rethrowChoice;
                    }
                    if (ofAKind == 3)
                    {
                        threeOrMorePlayer2TotalScore = threeOrMorePlayer2TotalScore + 3;
                    }
                    if (ofAKind == 4)
                    {
                        threeOrMorePlayer2TotalScore = threeOrMorePlayer2TotalScore + 6;
                    }
                    if (ofAKind == 5)
                    {
                        threeOrMorePlayer2TotalScore = threeOrMorePlayer2TotalScore + 12;
                    }

                    threeOrMorePlayer2NumberPlays++;

                    return threeOrMorePlayer2TotalScore;
                }

                if (userStat == true)
                {
                    Console.WriteLine("Player 2 has "+ threeOrMorePlayer2TotalScore + " score.");
                    Console.WriteLine("Player 2 has " + threeOrMorePlayer2NumberPlays + " plays.");
                    Console.WriteLine("");
                    return threeOrMorePlayer2TotalScore;
                }
                return threeOrMorePlayer2TotalScore;

           
        }
        }
        
        
        
    

    //Inheritance
    class CheckStats : SevensOutStatistics
    {
        //Shows the stats of the both players depending on what game they ask to check in the menu in the Testing class
        public void SevensOutstats()
        {
            Console.WriteLine("-----SevensOut-----");
            Console.WriteLine("Player 1 has " + sevensOutPlayer1TotalScore + " points");
            Console.WriteLine("Player 1's current high score is " + sevensOutPlayer1HighScore);
            Console.WriteLine("");
            Console.WriteLine("Player 2 has " + sevensOutPlayer2TotalScore + " points");
            Console.WriteLine("Player 2's current high score is " + sevensOutPlayer2HighScore);
            Console.WriteLine("");


    
            if (sevensOutPlayer1TotalScore > sevensOutPlayer2TotalScore)
            {
                Console.WriteLine("Player 1 is currently winning");
            }

            if (sevensOutPlayer2TotalScore > sevensOutPlayer1TotalScore)
            {
                Console.WriteLine("Player 2 is currently winning");

            }
            if (sevensOutPlayer2TotalScore == sevensOutPlayer1TotalScore)
            {
                Console.WriteLine("It is currently a draw!");

            }


        }

        
    }

    class CheckStatsThreeOrMore : ThreeOrMoreStatistics
    {
        public void ThreeOrMorestats()
        {
            Console.WriteLine("-----Three Or More-----");
            Console.WriteLine("Player 1 has " + threeOrMorePlayer1TotalScore + " points");
            Console.WriteLine("Player 1 has made " + threeOrMorePlayer1NumberPlays +" plays");
            Console.WriteLine("");
            Console.WriteLine("Player 2 has " + threeOrMorePlayer2NumberPlays + " points");
            Console.WriteLine("Player 2 has made " + threeOrMorePlayer2NumberPlays +" plays");
            Console.WriteLine("");


    
            if (sevensOutPlayer1TotalScore > sevensOutPlayer2TotalScore)
            {
                Console.WriteLine("Player 1 is currently winning");
            }

            if (sevensOutPlayer2TotalScore > sevensOutPlayer1TotalScore)
            {
                Console.WriteLine("Player 2 is currently winning");

            }
            if (sevensOutPlayer2TotalScore == sevensOutPlayer1TotalScore)
            {
                Console.WriteLine("It is currently a draw!");

            }
        }
    }
    
    
}