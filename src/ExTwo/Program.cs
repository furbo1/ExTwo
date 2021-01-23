﻿using System;

namespace ExTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            do 
            {
                 MainMenu();
                UserAction();
               
            }while(true);

            static void MainMenu()
            {
                 Console.WriteLine("Welcome to word play game!");
                  Console.WriteLine("1.Press 1 to enter just one word.");
                   Console.WriteLine("2.Press 2 to enter a sentence with minimum 3 words.");
                    Console.WriteLine("3.Press 0 to exit the program.");


            }
           static void UserAction()
           {
               string input = Console.ReadLine();
               switch(input)
               {
                   case "1":
                  Console.WriteLine("Please enter just one word.");
                   RepeatWordTenTimes();
                   break;
                   case "2":
                   Console.WriteLine("Please enter a sentence with at least 3 words.");
                   break;
                   case "3":
                   Environment.Exit(0);

                   break;
                   default:
                   Console.WriteLine("Please enter 1, 2, 3  or 0 to exit ");
                   break;
                   
               }
           }
            //Repeats the word ten times given a user input
           static void  RepeatWordTenTimes()
           { 
               string input = Console.ReadLine();
               string word = input;
                input = 1 + input + " ";
              
              
              for(int i = 2; i < 11; i++)
              {
                 
                 input +=  i + word + " " ;
              }
              Console.WriteLine(input);
               
           }
           
        }
    }
}
