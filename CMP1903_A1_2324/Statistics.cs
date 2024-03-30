using System;

namespace CMP1903_A1_2324
{
    public class Statistics
    {
        int Player1NumberPlays = 0;
        int Player1HighScore = 0;
        int Player1TotalScore = 0;
        
        
        public int player1Stat(int currentScore = 0)
        {
            Player1NumberPlays++;
            Player1TotalScore = currentScore + Player1TotalScore;
            if (currentScore > Player1HighScore)
            {
                Player1HighScore = currentScore;
            }
            Console.WriteLine("Player 1's high score is: " + Player1HighScore);
            Console.WriteLine("Player 1 has made " + Player1NumberPlays + " moves");

                return Player1TotalScore;

        }
        
        int Player2NumberPlays = 0;
        int Player2HighScore = 0;
        int Player2TotalScore = 0;
        public int player2Stat(int currentScore = 0)
        {
            Player2NumberPlays++;
            Player2TotalScore = currentScore + Player2TotalScore;
            if (currentScore > Player2HighScore)
            {
                Player2HighScore = currentScore;
            }
            Console.WriteLine("Player 2's high score is: " + Player2HighScore);
            Console.WriteLine("Player 2 has made " + Player2NumberPlays + " moves");

            return Player2TotalScore;

        }
        
        
        
        
    }
    
    
}