﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    class Game
    {
        public  Tuple<int, int, int> myMethod()
        {
                
                
            List<int> RollList = new List<int>();

                
            
                //Created three die objects 
                Die Die1 = new Die();
               


                    

                // Roll all three and saved it in roll 1, 2, 3 
                Console.WriteLine();
                int Roll1 = Die1.Roll();
                int Roll2 = Die1.Roll();
                int Roll3 = Die1.Roll();

                //Output what each die roll was
                Console.WriteLine("Die 1: " + Roll1);
                Console.WriteLine("Die 2: " + Roll2);
                Console.WriteLine("Die 3: " + Roll3);

                //Calculating the total
                int rolltotal = Roll1 + Roll2 + Roll3;

                //Displaying the total
                Console.WriteLine("The total amount is " +rolltotal);

                RollList.Add(Roll1);
                RollList.Add(Roll2);
                RollList.Add(Roll3);



                return new Tuple<int, int, int>(RollList[0], RollList[1], RollList[2]);




            
        }
    }

    class SevensOut
    {
        Die die = new Die();

        public Tuple<int, int> Player1game()
        {
            
            
            int Roll1 = die.Roll();
            int Roll2 = die.Roll();
            
            return new Tuple<int, int>(Roll1, Roll2);


        }
        
        public Tuple<int, int> Player2game()
        {
            
            
            int Roll1 = die.Roll();
            int Roll2 = die.Roll();
            
            return new Tuple<int, int>(Roll1, Roll2);


        }
        
    }

    class ThreeOrMore
    {
        
       

        public List<int> Player1game()
        {
            Die die = new Die();
            List<int> rollList = new List<int>();
            
            for (int j = 0; j < 5; j++)
            {
                rollList.Add(die.Roll());
            }


            
                
            return rollList ;
        }
        
        public List<int> Player2game()
        {
            List<int> rollList = new List<int>();
            Die die = new Die();

            for (int j = 0; j < 5; j++)
            {
                rollList.Add(die.Roll());
            }
            
            
            
          
            
            return rollList ;
        }

        public int checkUnique(List<int> RollNumbers)
        {
            int count = 0;
            
            List<int> RollNumbersuniquness = new List<int>();

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
            
            RollNumbersuniquness.Sort();
            RollNumbersuniquness.Reverse();
             
            return RollNumbersuniquness[0];
            
            
        }
    }
}