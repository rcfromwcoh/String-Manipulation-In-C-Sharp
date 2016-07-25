using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace StringManipulationInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //This program utilizes methods to build and manipulate strings in C#.
            //By Robert Horrocks, July, 2016
            
            //Problem One
            Console.WriteLine("Which phrase would you like to have reversed?");
            string userSentence = Console.ReadLine();
            string reversedSentence = ReverseWords(userSentence);
            Console.Clear();

            //Problem Two

            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("What is your birth month?");
            string userBirthMonth = Console.ReadLine();
            string completeBirthMonthSentence = BirthMonthSentence(userName, userBirthMonth);
            Console.Clear();

            //Problem Three

            Console.WriteLine("What is your first name?");
            string userFirstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string userLastName = Console.ReadLine();
            string properlyCapitalizedName = NameCapitalized(userFirstName, userLastName);
            Console.Clear();

            //Problem Four

            Console.WriteLine("Enter any random set of letters and numbers, then hit ENTER");
            string userInput = Console.ReadLine();
            
            string userInputZeroesRemoved = RemovingZeroMethod(userInput);
            Console.Clear();



        }

        static string ReverseWords(string userSentence)
        {
            //Problem One Method: The goal of this method is to take in one string parameter,
            //in the form of a phrase and print to the console the phrase reversed. 

            StringBuilder wordsReversed = new StringBuilder();
            string[] split = userSentence.Split(' ');
            for (int i = split.Length - 1; i > -1; i--)
            {
                wordsReversed.Append(split[i]);
                wordsReversed.Append(" ");
            }
            Console.WriteLine(wordsReversed);
            Console.ReadLine();
            return wordsReversed.ToString();
             
        }


        static string BirthMonthSentence(string userName, string userBirthMonth)
        {
            //Problem Two Method: This method will have two string parameters. 
            //The first parameter should be for the user's name. 
            //The second parameter should be for the user's birth month. 
            //The method should print to the console: 
            //[name] is a/an [birth month] baby!

            StringBuilder completeSentence = new StringBuilder(userName);
            completeSentence.Append(" is a");
            

            char firstLetterOfBirthMonth = Convert.ToChar(userBirthMonth.Substring(0, 1).ToUpper());
            

            if (firstLetterOfBirthMonth == 'A')
                completeSentence.Append("n");

            if (firstLetterOfBirthMonth == 'O')
                completeSentence.Append("n");

            completeSentence.Append(" " + userBirthMonth + " baby!");

            Console.WriteLine(completeSentence);
            Console.ReadKey();
            return completeSentence.ToString();
            

        }

        static string NameCapitalized(string userFirstName, string userLastName)
        {
            //Problem three method: Write a method that has two parameters.
            //The first parameter should be for the user's first name.
            //The second parameter should be for the user's last name. 
            //Assume the first and the last names are completely lower case. 
            //Your method should return the full name of the user with the first letter of each name capitalized. 
            //Using the variable in main print the full name to the console. 

            
            string firstLetterOfFirstName = userFirstName.Substring(0, 1).ToUpper();
            string firstLetterOfLastName = userLastName.Substring(0, 1).ToUpper();
            string updatedName = (firstLetterOfFirstName + userFirstName.Substring(1) + " " + firstLetterOfLastName + userLastName.Substring
                (1));

            Console.WriteLine(updatedName);
            Console.ReadKey();
            return updatedName.ToString();
        }

        static string RemovingZeroMethod(string userInput)
        {
            //Problem Four Method: Write a method that finds and removes any randomly placed '0' in the string.
            //The method has one string parameter for the string that will be searched. 
            //If there is no '0' in the string, the method should print to the console:
            //"This string is okay!"

            string zerolessString = userInput;
            string replacedZerolessString = "0";
            bool noZeroes = false;

            for (int z = 0; z < userInput.Length; z++)
            {

                if (zerolessString.Substring(z, 1) == "0")
                {
                    noZeroes = true;
                }


            }

            if (noZeroes == false)
            {
                Console.WriteLine("This string is okay!");
            }

            else
            {
                replacedZerolessString = Regex.Replace(userInput, "[0]", "");
                Console.WriteLine(replacedZerolessString);
            }

                Console.ReadKey();
                return replacedZerolessString.ToString();
            
          

        }
    }
}
