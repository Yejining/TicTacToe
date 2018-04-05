using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using IO;
using Data;

namespace Scene
{
    class UvsUGame
    {
        public static void Game(DataManager player1, DataManager player2)
        {
            StringBuilder sceneNameBldr = new StringBuilder();
            string sceneName;

            Console.Clear();
            sceneNameBldr.AppendFormat("{0} vs {1}", player1.GetName(), player2.GetName());            
            sceneName = sceneNameBldr.ToString();
            Print.Title(sceneName);
            

        }
    }
}
