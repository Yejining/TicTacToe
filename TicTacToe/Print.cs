using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    class Print
    {
        //GetValue getValue = new GetValue();
        //Progress progress = new Progress();

        public void Title(string sceneName)
        {
            string title1 = "┌                ┐";
            string title2 = " TIC TAC TOE";
            string title3 = "└                ┘";

            Console.SetWindowSize(80, 25);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (title1.Length / 2)) + "}", title1));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (title2.Length / 2)) + "}", title2));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (title3.Length / 2)) + "}", title3));
            
            Console.WriteLine();
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (sceneName.Length / 2)) + "}", sceneName));            
        }
        
        public void HomeOption()
        {
            string option1 = "1. User vs User                2. User vs Computer";
            string option2 = "3. Score Confirm               4. Exit            ";

            Console.WriteLine(String.Format("\n\n\n{0," + ((Console.WindowWidth / 2) + (option1.Length / 2)) + "}", option1));
            Console.WriteLine(String.Format("\n{0," + ((Console.WindowWidth / 2) + (option2.Length / 2)) + "}", option2));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        public void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

        public void Error(string errorMessage)
        {
            Console.Write(String.Format("\n{0," + ((Console.WindowWidth / 2) + ((errorMessage.Length - 3) / 2)) + "}", errorMessage));

            System.Threading.Thread.Sleep(1000);
            ClearCurrentConsoleLine();
            Console.SetCursorPosition(0, Console.CursorTop - 2);
            ClearCurrentConsoleLine();
        }

        //public void USettingInfo()
        //{
        //    string contents = "[User Information]               ";
        //    string name1 = "Name of Player 1 : ";
        //    string name2 = "Name of Palyer 2 : ";
        //    string stone1 = "Stone of Player 1 : ";
        //    string stone2 = "Stone of Player 2 : ";
        //    string question = "Who's ganna first(1/2)? ";

        //    string userName1, userName2;
        //    string userStone1, userStone2;
        //    int firstPlayer;

        //    Console.WriteLine(String.Format("\n\n{0," + ((Console.WindowWidth / 2) + (contents.Length / 2)) + "}", contents));

        //    Console.Write(String.Format("\n\n{0," + ((Console.WindowWidth / 2) + ((name1.Length - 10) / 2)) + "}", name1));
        //    userName1 = Console.ReadLine(); // 예외처리 할 것!

        //    Console.Write(String.Format("\n{0," + ((Console.WindowWidth / 2) + ((stone1.Length - 12) / 2)) + "}", stone1));
        //    userStone1 = Console.ReadLine(); // 예외처리 할 것!

        //    Console.Write(String.Format("\n{0," + ((Console.WindowWidth / 2) + ((name2.Length - 10) / 2)) + "}", name2));
        //    userName2 = Console.ReadLine(); // 예외처리 할 것!

        //    Console.Write(String.Format("\n{0," + ((Console.WindowWidth / 2) + ((stone2.Length - 12) / 2)) + "}", stone2));
        //    userStone2 = Console.ReadLine(); // 예외처리 할 것!

        //    Console.Write(String.Format("\n\n{0," + ((Console.WindowWidth / 2) + ((question.Length) / 2)) + "}", question));
        //    firstPlayer = getValue.GetIntAnswer(1, 2);

        //    progress.UNextStage(firstPlayer);
        //}

        //public void CSettingInfo()
        //{

        //}
    }
}
