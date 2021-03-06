using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RR_Game_Project.classes;
using RR_Game_Project.Properties;


//Project Start
namespace RR_Game_Project
{
    //Form Start
    public partial class GameForm : Form
    {
        // Assign variables

        int load, away, totalShot, win, loss , totalGamePlayed = 0;
        int myNum;
        bool isGameOver  = false;
        bool isPassing = false;
        string userName;

        gamePlay myGamePlay = new gamePlay();
        Player mysoundPlayer = new Player();

        public GameForm()

        {
            // assign component & sound

            InitializeComponent();
            mysoundPlayer.soundPlayer(Resources.gameSound);
                
        }

        //Assign Debug or counts
        private void debug()
        {
            totalShot = load + away;
            this.Text = "Load = " + load + " Away = " + away + " Total = " + totalShot;
            totalGamePlayed = loss + win;
            this.Text = "win = " + win + " loss = " + loss + " Total game played = " + totalGamePlayed;
        }

       //*************Loader button************
        private void btnLoader_Click(object sender, EventArgs e)
        {
            mysoundPlayer.soundPlayer(Resources.load);
            myNum = myGamePlay.RndNumber();
            lblUserName.Visible = false;
            txtUserName.Visible = false;
        }

        //*************Shot button************
        private void btnShot_Click(object sender, EventArgs e)
        {
            load++;
            debug();
            btnLoader.Enabled = false;
            mysoundPlayer.soundPlayer(Resources.shot);

            if (myNum != load)
            {// You are under the random number
                isGameOver = false;
                
            }
            else if (myNum == load)
            {
                //you equal the random number
                mysoundPlayer.soundPlayer(Resources.loss);
                isGameOver = true;
                MessageBox.Show("You Dead " +txtUserName.Text +" ! Try again");
                BackgroundImage = Resources.gameOver;
                btnPlayAgain.Visible = true;
                
            }
        }


        //*************Away button************
        private void btnAway_Click(object sender, EventArgs e)
        {
            away++;
            load++;
            debug();
            
            isPassing = true;
            mysoundPlayer.soundPlayer(Resources.Away1);

            if (myNum == load)
            {  mysoundPlayer.soundPlayer(Resources.victory);
               MessageBox.Show("You Live " +txtUserName.Text +"!");
                BackgroundImage = Resources.gameStart;
                btnPlayAgain.Visible = true;
                
            }
           
          else  if (away >= 2)
            { 
                //allow to pass only 2 times
                MessageBox.Show("You lost both 2 Chances to Live!");
                btnAway.Enabled = false;
                isPassing = false;
          
            }
        }

        //*************Play Again button************
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {   //Replay
            btnPlayAgain.Visible = false;
            BackgroundImage = null;
            load = 0;
            away = 0;
            isGameOver = false;
            btnAway.Enabled = true;
            lblUserName.Visible = true;
            txtUserName.Visible = true;
            txtUserName.Text = null;
            mysoundPlayer.soundPlayer(Resources.gameSound);
            btnLoader.Enabled = true;
        }

        //*************Rule button************
        private void btnRuleToPlay_Click(object sender, EventArgs e)
        {
            mysoundPlayer.soundPlayer(Resources.rule);
        }

        
    }

}
