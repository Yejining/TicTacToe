using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    class Home
    {
        Print print = new Print();
        GetValue getValue = new GetValue();
        Progress progress = new Progress();

        public void Select(string sceneName)
        {
            int option;

            print.Title(sceneName);
            print.HomeOption();
            option = getValue.GetIntAnswer(1, 4);

            progress.HomeNextStage(option);
        }
    }
}
