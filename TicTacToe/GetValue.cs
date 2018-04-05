using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataManager;
using Scene;

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

            PlayerInfo player1 = new PlayerInfo();
            PlayerInfo player2 = new PlayerInfo();

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

            if (firstPlayer == 1)
            {
                player1.Player(userName1, userStone1, 1);
                player2.Player(userName2, userStone2, 2);
            }
            else
            {
                player1.Player(userName1, userStone1, 2);
                player2.Player(userName2, userStone2, 1);
            }

            UvsUGame.Game(player1, player2);
        }

        public static void CSettingInfo()
        {
            string content1 = "[User Information]               ";
            string name = "Name of Player : ";
            string stone = "Stone of Palyer : ";
            string content2 = "[Your Oppenent]                  ";
            string computer = "1. Idiot(I)        2. Genius(G)";
            string question1 = "Who's your oppenent? ";
            string question2 = "Who's ganna first(1/2)? ";

            string userName;
            char userStone;
            int computerType;
            int firstPlayer;

            PlayerInfo player1 = new PlayerInfo();
            PlayerInfo player2 = new PlayerInfo();

            Console.WriteLine(String.Format("\n{0," + ((Console.WindowWidth / 2) + (content1.Length / 2)) + "}", content1));
            Console.WriteLine();

            userName = GetName(name);
            Console.WriteLine();
            userStone = GetStone(stone);

            Console.WriteLine(String.Format("\n\n{0," + ((Console.WindowWidth / 2) + (content2.Length / 2)) + "}", content2));
            Console.WriteLine(String.Format("\n{0," + ((Console.WindowWidth / 2) + (computer.Length / 2)) + "}", computer));
            Console.WriteLine();

            computerType = GetIntAnswer(question1, 1, 2);
            Console.WriteLine();

            firstPlayer = GetIntAnswer(question2, 1, 2);

            if (firstPlayer == 1)
            {
                player1.Player(userName, userStone, 1);
                if (computerType == 1) player2.Player("Idiot", 'I', 2);
                else player2.Player("Genius", 'G', 2);
            }
            else
            {
                player1.Player(userName, userStone, 2);
                if (computerType == 1) player2.Player("Idiot", 'I', 1);
                else player2.Player("Genius", 'G', 1);
            }

            UvsCGame.Game(player1, player2);
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
