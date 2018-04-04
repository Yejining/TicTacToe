using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Scene;

namespace Progress
{
    class Routine
    {
        public static void HomeNextStage(int option)
        {
            Console.Clear();

            switch (option)
            {
                case 1:
                    UvsUSettingInfo.Setting("User vs User");
                    return;
                case 2:
                    UvsCSettingInfo.Setting("User vs Computer");
                    return;
                case 3:
                    return;
                case 4:
                    return;
            }
        }

        public static void UNextStage(int option)
        {
            Console.Clear();


        }
    }
}
