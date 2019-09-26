using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze
{
    public partial class Form1 : Form
    {
        //This SoundPlayer plays a sound whenever the player hits a wall.
        System.Media.SoundPlayer startSoundPlayer2 = new System.Media.SoundPlayer(@"C:\Windows\Media\Windows Ding.wav");

        //This SoundPlayer plays a sound whenever the player hits a wall.
        System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\Windows Default.wav");
        
        // This SoundPlayer plays a sound when the player finishes the game.
        System.Media.SoundPlayer finishSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\Windows Balloon.wav");

        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }


        private void Finish_MouseEnter(object sender, EventArgs e)
        {
            finishSoundPlayer.Play();
            MessageBox.Show("Congratulations!");
            MoveToStart();
        }

        
        private void MoveToStart()
        {
            Point StartingPoint = panel1.Location;
            StartingPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(StartingPoint);
        }

        private void wall_MouseEnter(object sender, EventArgs e)
        {
            startSoundPlayer.Play();
            MoveToStart();
        }

        private void wall_MouseEnter_Green(object sender, EventArgs e)
        {
            startSoundPlayer2.Play();
            MoveToStart();
        }
    }
}
