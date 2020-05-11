using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragTree 
{
    public partial class Form1 : Form
    {
        #region global variables
        int currentRow;
        Stopwatch myWatch = new Stopwatch();
        

        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        #region startButton
        private void startButton_Click(object sender, EventArgs e)
        {
            lightTimer.Enabled = true;
           

        }

        private void lightTimer_Tick(object sender, EventArgs e)
        {
            currentRow++;

            switch (currentRow)
            {
                case 1:
                    row1col1.BackColor = Color.Goldenrod;
                    row1col2.BackColor = Color.Goldenrod;
                    break;
                case 2:
                    row2col1.BackColor = Color.Goldenrod;
                    row2col2.BackColor = Color.Goldenrod;
                    break;
                case 3:
                    row3col1.BackColor = Color.Goldenrod;
                    row3col2.BackColor = Color.Goldenrod;
                    break;
                case 4:
                    row4col1.BackColor = Color.Green;
                    row4col2.BackColor = Color.Green;
                    myWatch.Start();
                    break;
                default:
                    break; 
            }
              

        }

        #endregion

        private void goButton_Click(object sender, EventArgs e)
        {
            myWatch.Stop();

            if (myWatch.ElapsedMilliseconds > 0)
            {
                TimeSpan elasped = myWatch.Elapsed;
                timeLabel.Text = elasped.ToString(@"s\:fff");
            }
            else
            {
                timeLabel.Text = "FOUL START";
            }
           

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            myWatch.Reset();
            row1col1.BackColor = Color.DimGray;
            row1col2.BackColor = Color.DimGray;
            row2col1.BackColor = Color.DimGray;
            row2col2.BackColor = Color.DimGray;
            row3col1.BackColor = Color.DimGray;
            row3col2.BackColor = Color.DimGray;
            row4col1.BackColor = Color.DarkOliveGreen;
            row4col2.BackColor = Color.DarkOliveGreen;
            currentRow = 0;
            timeLabel.Text = "0.000";
            lightTimer.Enabled = false;

        }
    }
}
