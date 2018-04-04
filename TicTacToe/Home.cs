using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IO;
using Progress;

namespace Scene
{
    class Home
    { 
        public static void Select(string sceneName)
        {
            int option;

            Print.Title(sceneName);
            Print.HomeOption();
            option = GetValue.GetIntAnswer("Your Choice? ", 1, 4);

            Routine.HomeNextStage(option);
        }
    }
}
