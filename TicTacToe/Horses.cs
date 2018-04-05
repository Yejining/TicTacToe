using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataManager
{
    struct Horses
    {
        private char[] horses;

        public void InitHorses()
        {
           horses = new char[9] { '①', '②', '③', '④', '⑤', '⑥', '⑦', '⑧', '⑨' };
        }

        public void SetHorse(int place, char stone)
        {
            horses[place - 1] = stone;        
        }

        public char GetHorse(int place)
        {
            return horses[place - 1];
        }
    }
}
