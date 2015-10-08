/*
 * Created by: Perry Martin
 * Created on: 08-10-2015
 * Created for: ICS3U
 * Daily Assignment – Unit#3-07
 * This program displays a man walking
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// for pause
using System.Threading;

namespace TheWalkingMan
{
    public partial class frmWalking : Form
    {
        public frmWalking()
        {
            InitializeComponent();
        }

        private void btnStartWalking_Click(object sender, EventArgs e)
        {
            int loopCounter = 0;

            do
            {
                if (loopCounter == 0)
                {
                    this.picManWalking.Image = TheWalkingMan.Properties.Resources.walk2;
                }
                else if (loopCounter == 1)
                {
                    this.picManWalking.Image = TheWalkingMan.Properties.Resources.walk3;
                }
                else if (loopCounter == 2)
                {
                    this.picManWalking.Image = TheWalkingMan.Properties.Resources.walk4;
                }
                else if (loopCounter == 3)
                {
                    this.picManWalking.Image = TheWalkingMan.Properties.Resources.walk5;
                }
                else if (loopCounter == 4)
                {
                    this.picManWalking.Image = TheWalkingMan.Properties.Resources.walk6;
                }
                else if (loopCounter == 5)
                {
                    this.picManWalking.Image = TheWalkingMan.Properties.Resources.walk7;
                }
                else if (loopCounter == 6)
                {
                    this.picManWalking.Image = TheWalkingMan.Properties.Resources.walk8;
                }
                else if (loopCounter == 7)
                {
                    this.picManWalking.Image = TheWalkingMan.Properties.Resources.walk9;
                }
                else if (loopCounter == 8)
                {
                    this.picManWalking.Image = TheWalkingMan.Properties.Resources.walk10;
                }
                else if (loopCounter == 9)
                {
                    this.picManWalking.Image = TheWalkingMan.Properties.Resources.walk1;
                }

                loopCounter = loopCounter + 1;

                // pause
                this.Refresh();
                Thread.Sleep(100);

            } while (loopCounter < 10);
        }
    }
}
