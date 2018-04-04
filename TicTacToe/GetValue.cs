using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Progress;

namespace IO
{
    class GetValue
    {
        public static int GetIntAnswer(int min, int max)
        {
            string strAnswer;
            int intAnswer;
            string question = "Your Choice? ";
            string errorMessage = "Please enter a number between 1 and 4";

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
            string userStone1, userStone2;
            int firstPlayer;

            Console.WriteLine(String.Format("\n\n{0," + ((Console.WindowWidth / 2) + (contents.Length / 2)) + "}", contents));

            Console.Write(String.Format("\n\n{0," + ((Console.WindowWidth / 2) + ((name1.Length - 10) / 2)) + "}", name1));

        }

        // 예외처리
        //1. 15자를 초과하는 문자 입력
        //2. 공백
        //3. player2의 경우 player1과 중복되는 이름일 경우
        //public string getStrAnswer()
        //{

        //}

        //public string getStrAnswer(string nameOfPlayer1)
        //{

        //}

        //예외처리
        //    1. 공백
        //    2. 두 문자 이상
        //    3. Player2의 경우 중복허용X
        //    4. 게임판과 겹치는 원문자
        //    5. Computer와 대결하는 경우 I, G
        //public char getCharAnswer()
        //{

        //}

        //public char getCharAnswer(char stoneOfPlayer1)
        //{

        //}

        //public char getCharAnswer(char idiot, char genius)
        //{

        //}
    }
}
