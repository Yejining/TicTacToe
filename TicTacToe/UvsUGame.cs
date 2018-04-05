using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using IO;
using DataManager;
using Judge;

namespace Scene
{
    class UvsUGame
    {
        public static void Game(PlayerInfo player1, PlayerInfo player2)
        {
            StringBuilder sceneNameBldr = new StringBuilder();
            string sceneName;

            Console.Clear();
            sceneNameBldr.AppendFormat("{0} vs {1}", player1.GetName(), player2.GetName());            
            sceneName = sceneNameBldr.ToString();
            Print.Title(sceneName);

            Judge.Game.Start(player1, player2);
        }
    }
}
