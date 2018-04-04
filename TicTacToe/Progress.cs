using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToe
{
    class Progress
    {
        UvsUSettingInfo uSettingInfo = new UvsUSettingInfo();
        UvsCSettingInfo cSettingInfo = new UvsCSettingInfo();

        public void HomeNextStage(int option)
        {
            Console.Clear();

            switch (option)
            {
                case 1:
                    uSettingInfo.Setting("User vs User");
                    return;
                case 2:
                    cSettingInfo.Setting("User vs Computer");
                    return;
                case 3:
                    return;
                case 4:
                    return;
            }
        }

        //public void UNextStage(int option)
        //{
        //    Console.Clear();


        //}
    }
}
