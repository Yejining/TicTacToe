﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Progress;

namespace IO
{
    class GetValue
    {
        public static int GetIntAnswer(string question, int min, int max)
        {
            string strAnswer;
            int intAnswer;
            string errorMessage;
            StringBuilder errorMessageBldr = new StringBuilder("Please enter a number between ");

            errorMessageBldr.AppendFormat("{0} and {1}", min.ToString(), max.ToString());
            errorMessage = errorMessageBldr.ToString();

            while (true)
            {
                Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + ((question.Length - 3) / 2)) + "}", question));
                strAnswer = Console.ReadLine();

                Int32.TryParse(strAnswer, out intAnswer);

                if (intAnswer >= min && intAnswer <= max) break;
                else Print.Error(errorMessage);
            }

            return intAnswer;
        }

        public static void USettingInfo()
        {
            string contents = "[User Information]               ";
            string name1 = "Name of Player 1 : ";
            string name2 = "Name of Palyer 2 : ";
            string stone1 = "Stone of Player 1 : ";
            string stone2 = "Stone of Player 2 : ";
            string question = "Who's ganna first(1/2)? ";

            string userName1, userName2;
            char userStone1, userStone2;
            int firstPlayer;

            Console.WriteLine(String.Format("\n\n{0," + ((Console.WindowWidth / 2) + (contents.Length / 2)) + "}", contents));
            Console.WriteLine();
            Console.WriteLine();

            userName1 = GetName(name1);
            Console.WriteLine();
            userStone1 = GetStone(stone1);
            Console.WriteLine();
            userName2 = GetName(name2, userName1);
            Console.WriteLine();
            userStone2 = GetStone(stone2, userStone1);
            Console.WriteLine();
            Console.WriteLine();

            firstPlayer = GetIntAnswer(question,1, 2);
        }

        public static string GetName(string question)
        {
            string name;
            string errorMessage = "Please enter within 15 characters";

            while (true)
            {
                Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + ((question.Length - 3) / 2)) + "}", question));
                name = Console.ReadLine();

                if (name.Length > 15 || name.Length == 0) Print.Error(errorMessage);
                else break;
            }

            return name;
        }
        
        public static string GetName(string question, string player1)
        {
            string name;
            string errorMessage = "Please enter within 15 characters";
            string overlapErrorMessage = "Please enter a different name from Player 1";
            
            while (true)
            {
                Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + ((question.Length - 3) / 2)) + "}", question));
                name = Console.ReadLine();

                if (name.Length > 15 || name.Length == 0) Print.Error(errorMessage);
                else if (name == player1) Print.Error(overlapErrorMessage);
                else break;
            }

            return name;
        }
       
        public static char GetStone(string question)
        {
            string strStone;
            char charStone;
            string errorMessage = "Please enter 1 character for stone";
            string overlapErrormessage = "Please enter 1 character except circle character";

            while (true)
            {
                Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + ((question.Length - 3) / 2)) + "}", question));
                strStone = Console.ReadLine();

                if (strStone.Length > 1 || strStone.Length == 0) Print.Error(errorMessage);
                else if (strStone[0] >= '①' && strStone[0] <= '⑨') Print.Error(overlapErrormessage);
                else break;
            }

            charStone = strStone[0];

            return charStone;
        }

        public static char GetStone(string question, char player1)
        {
            string strStone;
            char charStone;
            string errorMessage = "Please enter 1 character for stone";
            string overlapErrormessage = "Please enter 1 character except circle character";
            string overlapErrormessage1 = "Please enter 1 character different from player 1's";

            while (true)
            {
                Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + ((question.Length - 3) / 2)) + "}", question));
                strStone = Console.ReadLine();

                if (strStone.Length > 1 || strStone.Length == 0) Print.Error(errorMessage);
                else if (strStone[0] >= '①' && strStone[0] <= '⑨') Print.Error(overlapErrormessage);
                else if (strStone[0] == player1) Print.Error(overlapErrormessage1);
                else break;
            }

            charStone = strStone[0];

            return charStone;
        }

        public static char GetStone(string question, char idiot, char genius)
        {
            string strStone;
            char charStone;
            string errorMessage = "Please enter 1 character for stone";
            string overlapErrormessage = "Please enter 1 character except circle character";
            string overlapErrormessage1 = "Please enter 1 character different from computer";

            while (true)
            {
                Console.Write(String.Format("{0," + ((Console.WindowWidth / 2) + ((question.Length - 3) / 2)) + "}", question));
                strStone = Console.ReadLine();

                if (strStone.Length > 1 || strStone.Length == 0) Print.Error(errorMessage);
                else if (strStone[0] >= '①' && strStone[0] <= '⑨') Print.Error(overlapErrormessage);
                else if (strStone[0] == idiot || strStone[0] == genius) Print.Error(overlapErrormessage1);
                else break;
            }

            charStone = strStone[0];

            return charStone;
        }
    }
}
