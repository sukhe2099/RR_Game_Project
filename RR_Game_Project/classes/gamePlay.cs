using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Media;

namespace RR_Game_Project.classes
{
    public class gamePlay
    {

        public int RndNumber()
        {
            //create a random number
            Random num = new Random();
            int rndNum = num.Next(1, 7);
            //send the number back to the program
            return rndNum;

        }

    }
}
