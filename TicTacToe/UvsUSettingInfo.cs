﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using IO;

namespace Scene
{
    class UvsUSettingInfo
    {
        public static void Setting(string sceneName)
        {
            Print.Title(sceneName);
            GetValue.USettingInfo();
        }
    }
}
