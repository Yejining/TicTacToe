using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IO
{
    class Print
    {
        public static void Title(string sceneName)
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
        
        public static void HomeOption()
        {
            string option1 = "1. User vs User                2. User vs Computer";
            string option2 = "3. Score Confirm               4. Exit            ";

            Console.WriteLine(String.Format("\n\n\n{0," + ((Console.WindowWidth / 2) + (option1.Length / 2)) + "}", option1));
            Console.WriteLine(String.Format("\n{0," + ((Console.WindowWidth / 2) + (option2.Length / 2)) + "}", option2));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

        public static void Error(string errorMessage)
        {
            Console.Write(String.Format("\n{0," + ((Console.WindowWidth / 2) + ((errorMessage.Length - 3) / 2)) + "}", errorMessage));

            System.Threading.Thread.Sleep(1000);
            ClearCurrentConsoleLine();
            Console.SetCursorPosition(0, Console.CursorTop - 2);
            ClearCurrentConsoleLine();
        }
    }
}
