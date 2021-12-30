using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextWorld
{
    public enum Direction
    {
        East,
        North,
        West,
        South
    }
    public class WindRose
    {
        int[] _steps = new int[4];
        public int[] GetSteps()
        {
            return _steps;
        }
        public void Movement(Direction dir)
        {
            CalcSteps(dir);
        }
        void CalcSteps (Direction dir)
        {
            int x = (int)dir;
            _steps[x]++;
            if (x % 2 == 0)
            {
                if (dir == Direction.East) _steps[(int)Direction.West]--;
                else _steps[(int)Direction.East]--;
            }
            else
            {
                if (dir == Direction.North) _steps[(int)Direction.South]--;
                else _steps[(int)Direction.North]--;
            }
        }
    }
}
