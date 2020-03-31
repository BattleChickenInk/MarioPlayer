using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayMarioWorld
{
    public partial class Options : Form
    {
        //Variables
        public bool emulatorFound = false;

        //Refrence Images
        Bitmap mario_1 = new Bitmap(@"C:\\Users\\Tommy\\source\\repos\\PlayMarioWorld\\Resources\\StartingMario.png");
        Bitmap mario_2 = new Bitmap(@"C:\\Users\\Tommy\\source\\repos\\PlayMarioWorld\\Resources\\StartingMario2.png");

        public Options()
        {
            InitializeComponent();
        }

        //Starts Program
        private void StartButton_Click(object sender, EventArgs e)
        {
            Log.Items.Add("Searching For Super Mario Bros. (NES)");
            ScanScreen(mario_1);
        }

        //Search The Screen For A Bitmap
        public void ScanScreen(Bitmap referenceSprite)
        {
            if(emulatorFound == false)
            {
                for (int height = 0; height < Screen.PrimaryScreen.Bounds.Height; height++)
                {
                    for (int length = 0; length < Screen.PrimaryScreen.Bounds.Width; length++)
                    {
                        Bitmap screen = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                        Graphics g = Graphics.FromImage(screen);
                        g.CopyFromScreen(length, height, referenceSprite.Width, referenceSprite.Height, referenceSprite.Size);

                        pictureBox1.Image = screen;

                        if (TestForMatch(referenceSprite, screen))
                        {
                            emulatorFound = true;
                        }
                    }
                }
            }
            else
            {
                //Scan the emulators position instead of the entire screen
            }
        }

        //Checks If Two Bitmaps Are Similar / The Same
        public bool TestForMatch(Bitmap sample, Bitmap referenceSprite)
        {
            int totalSamplePixels = sample.Height * sample.Width;

            if (object.Equals(sample, referenceSprite))
            {
                return true;
            }
            else
            {
                int totalMatches = 0;
                for(int x = 0; x < sample.Width; x++)
                {
                    for(int y = 0; y < sample.Height; y++)
                    {
                        if(sample.GetPixel(x, y) == referenceSprite.GetPixel(x, y))
                        {
                            totalMatches += 1;
                        }
                    }
                }

                if(totalMatches >= totalSamplePixels / 1.75f)
                {
                    Log.Items.Add("FOUND IMAGE: " + totalMatches);
                    return true;
                }
                else
                {
                    Log.Items.Add("FAILED: Image not found");
                    Log.Items.Add("     Total Matches: " + totalMatches);
                    Log.Items.Add("     Percent Match:" + totalMatches * 100 / totalSamplePixels + "%");
                    return false;
                }
            }
        }

        //Command Log
        private void Log_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Stop_Click(object sender, EventArgs e)
        {
            int height = 0;
            int length = 0;
            Bitmap referenceSprite = mario_1;
            Bitmap screen = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics g = Graphics.FromImage(screen);
            g.CopyFromScreen(length, height, referenceSprite.Width, referenceSprite.Height * 50, referenceSprite.Size);

            pictureBox1.Image = screen;
        }
    }
}
