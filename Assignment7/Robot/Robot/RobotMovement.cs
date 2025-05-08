// Writteb by Swornashabi
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class RobotMovement
    {
        public bool JudgeCircle(string moves)
        {
            int x = 0, y = 0;

            foreach(char move in moves)
            {
                switch(move)
                {
                    case 'U': y++; break;
                    case 'D': y--; break;
                    case 'R': x++; break;
                    case 'L': x--; break;
                }
            }

            return x == 0 && y == 0;
        }
    }
}
