// Written by Swornashabi
// 2/3/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watchtower
{
    public class Watchtower
    {
        //class variables
        private int xCoordinate = 0;
        private int yCoordinate = 0;

        //gets and sets
        public int XCoordinate
        {
            get { return this.xCoordinate; }
            set { this.xCoordinate = value; }
        }

        public int YCoordinate
        {
            get { return this.yCoordinate; }
            set { this.yCoordinate = value; }
        }

        //methods
        public string DisplayEnemyDirection()
        {
            if(this.XCoordinate < 0 && this.YCoordinate > 0)
            {
                return "North West";
            }
            else if(this.XCoordinate < 0 && this.YCoordinate == 0)
            {
                return "West";
            }
            else if(this.XCoordinate < 0 && this.YCoordinate < 0)
            {
                return "South West";
            }
            else if(this.XCoordinate == 0 && this.YCoordinate > 0)
            {
                return "North";
            }
            else if(this.XCoordinate == 0 && this.YCoordinate == 0 )
            {
                return "Here";
            }
            else if(this.XCoordinate == 0 && this.YCoordinate < 0)
            {
                return "South";
            }
            else if(this.XCoordinate > 0 && this.YCoordinate > 0)
            {
                return "North East";
            }
            else if(this.XCoordinate > 0 && this.YCoordinate == 0)
            {
                return "East";
            }
            else
            {
                return "South East";
            }
        }

        //overriding ToString()
        public override string ToString()
        {
            string msg = "";
            msg += "The enemy is " + DisplayEnemyDirection() + "!" + "\n";
            return msg;
        }
    }
}
