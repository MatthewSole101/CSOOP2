// Importing necessary namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    class Game
    {
        // myMethod rolls three die and returns their values as a tuple
        public Tuple<int, int, int> myMethod()
        {
            // Created list to store the die rolls
            List<int> RollList = new List<int>();

            // Created an instance of the Die class
            Die Die1 = new Die();

            // Rolling the die and storing the values from the Roll method in the Die class
            int Roll1 = Die1.Roll();
            int Roll2 = Die1.Roll();
            int Roll3 = Die1.Roll();

            // Displaying the values of each die roll
            Console.WriteLine();
            Console.WriteLine("Die 1: " + Roll1);
            Console.WriteLine("Die 2: " + Roll2);
            Console.WriteLine("Die 3: " + Roll3);

            // Calculated the total of the three dice rolls
            int rolltotal = Roll1 + Roll2 + Roll3;

            // Displaying the total
            Console.WriteLine("The total amount is " + rolltotal);

            // Adding the individual dice rolls to the list
            RollList.Add(Roll1);
            RollList.Add(Roll2);
            RollList.Add(Roll3);

            // Returning the list of die rolls in a tuple
            return new Tuple<int, int, int>(RollList[0], RollList[1], RollList[2]);
        }
    }

    class SevensOut
    {
        // Creating an instance of the Die class
        Die die = new Die();

        // This method rolls two die for Player 1 and returns their values as a tuple
        public Tuple<int, int> Player1game()
        {
            int Roll1 = die.Roll();
            int Roll2 = die.Roll();

            return new Tuple<int, int>(Roll1, Roll2);
        }

        // This method rolls two dice for Player 2 and returns their values as a tuple
        public Tuple<int, int> Player2game()
        {
            int Roll1 = die.Roll();
            int Roll2 = die.Roll();

            return new Tuple<int, int>(Roll1, Roll2);
        }
    }

    class ThreeOrMore
    {   //Both methods are called the same name as in the Sevens Out classes one
        // This method rolls five dice for Player 1 and returns their values as a list
        public List<int> Player1game()
        {
            Die die = new Die();
            List<int> rollList = new List<int>();

            for (int j = 0; j < 5; j++)
            {
                rollList.Add(die.Roll());
            }

            return rollList;
        }

        // This method rolls five dice for Player 2 and returns their values as a list
        public List<int> Player2game()
        {
            List<int> rollList = new List<int>();
            Die die = new Die();

            for (int j = 0; j < 5; j++)
            {
                rollList.Add(die.Roll());
            }

            return rollList;
        }

        // This method checks the uniqueness of the dice rolls and returns the highest count
        public int checkUnique(List<int> RollNumbers)
        {
            int count = 0;
            List<int> RollNumbersuniquness = new List<int>();

            // Counting the occurrences of each number (1 to 6) in the dice rolls
            for (int i = 1; i < 7; i++)
            {
                foreach (int num in RollNumbers)
                {
                    if (num == i)
                    {
                        count++;
                    }
                }
                RollNumbersuniquness.Add(count);
                count = 0;
            }

            // Sorting the list in descending order to get the highest count first
            RollNumbersuniquness.Sort();
            RollNumbersuniquness.Reverse();

            // Returning the highest count
            return RollNumbersuniquness[0];
        }
    }
}