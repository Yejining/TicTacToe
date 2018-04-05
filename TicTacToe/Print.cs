using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DataManager;

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

        public static void Stadium(PlayerInfo player1, PlayerInfo player2)
        {
            Horses horses = new Horses();
            horses.InitHorses();

            StringBuilder stadiumBldr2 = new StringBuilder();
            StringBuilder stadiumBldr4 = new StringBuilder();
            StringBuilder stadiumBldr6 = new StringBuilder();
            string stadium1 = "┏       ┳       ┳       ┓";            
            string stadium3 = "┣       ╋       ╋       ┫";            
            string stadium5 = "┣       ╋       ╋       ┫";            
            string stadium7 = "┗       ┻       ┻       ┛";
            string stadium2;
            string stadium4;
            string stadium6;
            string name1, name2;
            
            stadiumBldr2.AppendFormat("{0}      {1}      {2}", horses.GetHorse(1), horses.GetHorse(2), horses.GetHorse(3));
            stadiumBldr4.AppendFormat("{0}      {1}      {2}", horses.GetHorse(4), horses.GetHorse(5), horses.GetHorse(6));
            stadiumBldr6.AppendFormat("{0}      {1}      {2}", horses.GetHorse(7), horses.GetHorse(8), horses.GetHorse(9));
            stadium2 = stadiumBldr2.ToString();
            stadium4 = stadiumBldr4.ToString();
            stadium6 = stadiumBldr6.ToString();

            if (player1.GetName().Length > player2.GetName().Length)
            {                
                name1 = player1.GetName().PadLeft(50);
                name2 = player2.GetName().PadLeft(50 - player1.GetName().Length + player2.GetName().Length);
            }
            else
            {
                name1 = player1.GetName().PadLeft(50 - player2.GetName().Length + player1.GetName().Length);
                name2 = player2.GetName().PadLeft(50);
            }

            Console.WriteLine(String.Format("\n{0," + ((Console.WindowWidth / 2) + ((stadium1.Length - 30) / 2)) + "}", stadium1));
            Console.WriteLine(name1);
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ((stadium2.Length - 30) / 2)) + "}", stadium2));
            Console.WriteLine(name2);
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ((stadium3.Length - 30) / 2)) + "}\n", stadium3));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ((stadium2.Length - 30) / 2)) + "}\n", stadium4));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ((stadium5.Length - 30) / 2)) + "}\n", stadium5));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ((stadium2.Length - 30) / 2)) + "}\n", stadium6));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + ((stadium7.Length - 30) / 2)) + "}", stadium7));

            
        }
    }
}
