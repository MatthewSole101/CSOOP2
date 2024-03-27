using System;

namespace CMP1903_A1_2324
{
    public class Statistics
    {
        int numberPlays = 0;
        int highScore = 0;
        int totalScore = 0;
        public int playerStat(int currentScore = 0)
        {
            numberPlays++;
            totalScore = currentScore + totalScore;
            if (currentScore > highScore)
            {
                highScore = currentScore;
            }
            Console.WriteLine("The total score is: " + totalScore);
            Console.WriteLine("The high score is: " + highScore);
            Console.WriteLine("The number of plays is: " + numberPlays);

                return highScore;

        }
    }
}