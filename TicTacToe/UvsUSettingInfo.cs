using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    class UvsUSettingInfo
    {
        Print print = new Print();

        public void Setting(string sceneName)
        {
            print.Title(sceneName);
            //print.USettingInfo();
        }
    }
}
