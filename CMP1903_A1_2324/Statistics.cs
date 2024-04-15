using System;

namespace CMP1903_A1_2324
{
    public class Statistics
    {
      
        int sevensOutPlayer1NumberPlays = 0;
        int sevensOutPlayer1HighScore = 0;
        int sevensOutPlayer1TotalScore = 0;
        
        
        public int SevensOutplayer1Stat(int currentScore = 0, bool userStat = false)
        {
            if (userStat == false)
            {
                sevensOutPlayer1NumberPlays++;
                sevensOutPlayer1TotalScore = currentScore + sevensOutPlayer1TotalScore;
                if (currentScore > sevensOutPlayer1HighScore)
                {
                    sevensOutPlayer1HighScore = currentScore;
                }
                // Console.WriteLine("Player 1's high score is: " + Player1HighScore);
                // Console.WriteLine("Player 1 has made " + Player1NumberPlays + " moves");
            }
           

            if (userStat == true)
            {
                Console.WriteLine("");
                Console.WriteLine("Player 1's high score is: " + sevensOutPlayer1HighScore);
                Console.WriteLine("Player 1 has made " + sevensOutPlayer1NumberPlays + " moves");
            }

                return sevensOutPlayer1TotalScore;

        }
        
        int sevensOutPlayer2NumberPlays = 0;
        int sevensOutPlayer2HighScore = 0;
        int sevensOutPlayer2TotalScore = 0;
        public int SevensOutplayer2Stat(int currentScore = 0, bool userStat = false)
        {

            if (userStat == false)
            {
                sevensOutPlayer2NumberPlays++;
                sevensOutPlayer2TotalScore = currentScore + sevensOutPlayer2TotalScore;
                if (currentScore > sevensOutPlayer2HighScore)
                {
                    sevensOutPlayer2HighScore = currentScore;
                }
                // Console.WriteLine("Player 2's high score is: " + Player2HighScore);
                // Console.WriteLine("Player 2 has made " + Player2NumberPlays + " moves");
            }
            

            if (userStat == true)
            {
                Console.WriteLine("");
                Console.WriteLine("Player 2's high score is: " + sevensOutPlayer2HighScore);
                Console.WriteLine("Player 2 has made " + sevensOutPlayer2NumberPlays + " moves");
            }
            
            return sevensOutPlayer2TotalScore;

        }
        int threeOrMorePlayer1NumberPlays = 0;
        int threeOrMorePlayer1TotalScore = 0;
        public int ThreeOrMorePlayer1Stat(int ofAKind = 0, bool userStat = false)
        {
            if (userStat == false)
            {
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
                Console.WriteLine("Player 1 has "+ threeOrMorePlayer1TotalScore + " score.");
                Console.WriteLine("Player 1 has " + threeOrMorePlayer1NumberPlays + " plays.");
                
                
            }
            return threeOrMorePlayer1TotalScore;

           
        }
        
        
    }
    
    
}