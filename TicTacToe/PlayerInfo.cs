using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataManager
{
    struct PlayerInfo
    {
        private string name;
        private char stone;
        private int turn;

        public void Player (string name, char stone, int turn)
        {
            this.name = name;
            this.stone = stone;
            this.turn = turn;
        }

        public string GetName()
        {
            return name;
        }

        public char GetStone()
        {
            return stone;
        }

        public int GetTurn()
        {
            return turn;
        }
    }
}
