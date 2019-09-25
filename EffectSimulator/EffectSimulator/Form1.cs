using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;


namespace EffectSimulator
{

    public partial class EffectSim : Form
    {
        public EffectSim()
        {
            InitializeComponent();
        }
        int speed;
        int randomMin = 0;
        int tail;
        int[] randomMax = new int[27];
        int[] sensitivity = new int[27];
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        } //generate a random numbers, this is what makes the fire keep moving randomly
        bool export;
        int frame;
        internal byte[] Pixels;

        private void pictureBox3_Paint(object sender, PaintEventArgs p)
        {
            //the fire drawing function
            if (Fire.Checked)
            {
                #region settings              
                randomMax[0] = decimal.ToInt32(SensivityY.Value) + 1;
                randomMax[1] = decimal.ToInt32(SensivityY.Value) + 1;
                randomMax[2] = decimal.ToInt32(SensivityY.Value) + 1;
                randomMax[3] = decimal.ToInt32(SensivityY.Value) + 2;
                randomMax[4] = decimal.ToInt32(SensivityY.Value) + 1;
                randomMax[5] = decimal.ToInt32(SensivityY.Value) + 1;
                randomMax[6] = decimal.ToInt32(SensivityY.Value) + 2;
                randomMax[7] = decimal.ToInt32(SensivityY.Value) + 3;
                randomMax[8] = decimal.ToInt32(SensivityY.Value) + 2;
                randomMax[9] = decimal.ToInt32(SensivityY.Value) + 1;
                randomMax[10] = decimal.ToInt32(SensivityY.Value) + 2;
                randomMax[11] = decimal.ToInt32(SensivityY.Value) + 3;
                randomMax[12] = decimal.ToInt32(SensivityY.Value) + 1;
                randomMax[13] = decimal.ToInt32(SensivityY.Value) + 2;
                randomMax[14] = decimal.ToInt32(SensivityY.Value) + 2;
                randomMax[15] = decimal.ToInt32(SensivityY.Value) + 3;
                randomMax[16] = decimal.ToInt32(SensivityY.Value) + 6;
                randomMax[17] = decimal.ToInt32(SensivityY.Value) + 5;
                randomMax[18] = decimal.ToInt32(SensivityY.Value) + 7;
                randomMax[19] = decimal.ToInt32(SensivityY.Value) + 6;
                randomMax[20] = decimal.ToInt32(SensivityY.Value) + 5;
                randomMax[21] = decimal.ToInt32(SensivityY.Value) + 5;
                randomMax[22] = decimal.ToInt32(SensivityY.Value) + 6;
                randomMax[23] = decimal.ToInt32(SensivityY.Value) + 7;
                randomMax[24] = decimal.ToInt32(SensivityY.Value) + 6;
                randomMax[25] = decimal.ToInt32(SensivityY.Value) + 5;
                randomMax[26] = decimal.ToInt32(SensivityY.Value) + 5;

                sensitivity[0] = decimal.ToInt32(SensivityX.Value) + 1;
                sensitivity[1] = decimal.ToInt32(SensivityX.Value) + 1;
                sensitivity[2] = decimal.ToInt32(SensivityX.Value) + 1;
                sensitivity[3] = decimal.ToInt32(SensivityX.Value) + 2;
                sensitivity[4] = decimal.ToInt32(SensivityX.Value) + 1;
                sensitivity[5] = decimal.ToInt32(SensivityX.Value) + 1;
                sensitivity[6] = decimal.ToInt32(SensivityX.Value) + 2;
                sensitivity[7] = decimal.ToInt32(SensivityX.Value) + 3;
                sensitivity[8] = decimal.ToInt32(SensivityX.Value) + 2;
                sensitivity[9] = decimal.ToInt32(SensivityX.Value) + 1;
                sensitivity[10] = decimal.ToInt32(SensivityX.Value) + 2;
                sensitivity[11] = decimal.ToInt32(SensivityX.Value) + 3;
                sensitivity[12] = decimal.ToInt32(SensivityX.Value) + 1;
                sensitivity[13] = decimal.ToInt32(SensivityX.Value) + 2;
                sensitivity[14] = decimal.ToInt32(SensivityX.Value) + 2;
                sensitivity[15] = decimal.ToInt32(SensivityX.Value) + 3;
                sensitivity[16] = decimal.ToInt32(SensivityX.Value) + 6;
                speed = decimal.ToInt32(Speed.Value);

                #endregion
                #region animation
                Rectangle fireDown1 = new Rectangle(300 + RandomNumber(randomMin, sensitivity[1]), 300 - RandomNumber(randomMin, randomMax[1]), 10, 10);
                Rectangle fireDown2 = new Rectangle(295 + RandomNumber(randomMin, sensitivity[2]), 299 - RandomNumber(randomMin, randomMax[2]), 10, 10);
                Rectangle fireDown3 = new Rectangle(290 + RandomNumber(randomMin, sensitivity[3]), 295 - RandomNumber(randomMin, randomMax[3]), 10, 10);
                Rectangle fireDown4 = new Rectangle(305 + RandomNumber(randomMin, sensitivity[4]), 299 - RandomNumber(randomMin, randomMax[4]), 10, 10);
                Rectangle fireDown5 = new Rectangle(310 + RandomNumber(randomMin, sensitivity[5]), 295 - RandomNumber(randomMin, randomMax[5]), 10, 10);
                Rectangle fireRate1 = new Rectangle(300 + RandomNumber(randomMin, sensitivity[6]), 295 - RandomNumber(randomMin, randomMax[6]), 10, 10);
                Rectangle fireRate2 = new Rectangle(300 + RandomNumber(randomMin, sensitivity[7]), 290 - RandomNumber(randomMin, randomMax[7]), 10, 10);
                Rectangle fireRate3 = new Rectangle(293 + RandomNumber(randomMin, sensitivity[8]), 290 - RandomNumber(randomMin, randomMax[8]), 10, 10);
                Rectangle fireRate4 = new Rectangle(295 + RandomNumber(randomMin, sensitivity[9]), 290 - RandomNumber(randomMin, randomMax[9]), 10, 10);
                Rectangle fireRate5 = new Rectangle(305 + RandomNumber(randomMin, sensitivity[10]), 290 - RandomNumber(randomMin, randomMax[10]), 10, 10);
                Rectangle fireRate6 = new Rectangle(308 + RandomNumber(randomMin, sensitivity[11]), 290 - RandomNumber(randomMin, randomMax[11]), 10, 10);
                Rectangle fireRate7 = new Rectangle(295 + RandomNumber(randomMin, sensitivity[12]), 295 - RandomNumber(randomMin, randomMax[12]), 10, 10);
                Rectangle fireUp1 = new Rectangle(300 + RandomNumber(randomMin, sensitivity[13]), 285 - RandomNumber(randomMin, randomMax[13]), 10, 10);
                Rectangle fireUp2 = new Rectangle(303 + RandomNumber(randomMin, sensitivity[14]), 285 - RandomNumber(randomMin, randomMax[14]), 10, 10);
                Rectangle fireUp3 = new Rectangle(297 + RandomNumber(randomMin, sensitivity[15]), 285 - RandomNumber(randomMin, randomMax[15]), 10, 10);
                Rectangle fireUp4 = new Rectangle(298 + RandomNumber(randomMin, sensitivity[16]), 280 - RandomNumber(randomMin, randomMax[16]), 10, 10);
                #endregion
                p.Graphics.FillEllipse(Brushes.Red, fireDown1);
                p.Graphics.FillEllipse(Brushes.Red, fireDown2);
                p.Graphics.FillEllipse(Brushes.Red, fireDown3);
                p.Graphics.FillEllipse(Brushes.Red, fireDown4);
                p.Graphics.FillEllipse(Brushes.Red, fireDown5);
                p.Graphics.FillEllipse(Brushes.Red, fireRate1);
                p.Graphics.FillEllipse(Brushes.Red, fireRate2);
                p.Graphics.FillEllipse(Brushes.Red, fireRate3);
                p.Graphics.FillEllipse(Brushes.Red, fireRate4);
                p.Graphics.FillEllipse(Brushes.Red, fireRate5);
                p.Graphics.FillEllipse(Brushes.Red, fireRate6);
                p.Graphics.FillEllipse(Brushes.Red, fireRate7);
                p.Graphics.FillEllipse(Brushes.Red, fireUp1);
                p.Graphics.FillEllipse(Brushes.Red, fireUp2);
                p.Graphics.FillEllipse(Brushes.Red, fireUp3);
                p.Graphics.FillEllipse(Brushes.Red, fireUp4);
            }
            if (tailBox.Checked)
            {
                Rectangle fireTail1 = new Rectangle(290 + RandomNumber(randomMin, randomMax[17]), 290 - tail - RandomNumber(randomMin, randomMax[17]), 10, 10);
                Rectangle fireTail2 = new Rectangle(300 + RandomNumber(randomMin, randomMax[18]), 295 - tail - RandomNumber(randomMin, randomMax[18]), 10, 10);
                Rectangle fireTail3 = new Rectangle(305 + RandomNumber(randomMin, randomMax[19]), 290 - tail - RandomNumber(randomMin, randomMax[19]), 10, 10);
                Rectangle fireTail4 = new Rectangle(310 + RandomNumber(randomMin, randomMax[20]), 305 - tail - RandomNumber(randomMin, randomMax[20]), 10, 10);
                Rectangle fireTail5 = new Rectangle(295 + RandomNumber(randomMin, randomMax[21]), 300 - tail - RandomNumber(randomMin, randomMax[21]), 10, 10);
                Rectangle fireTail6 = new Rectangle(315 + RandomNumber(randomMin, randomMax[22]), 310 - tail - RandomNumber(randomMin, randomMax[22]), 10, 10);
                Rectangle fireTail7 = new Rectangle(285 + RandomNumber(randomMin, randomMax[23]), 300 - tail - RandomNumber(randomMin, randomMax[23]), 10, 10);
                Rectangle fireTail8 = new Rectangle(280 + RandomNumber(randomMin, randomMax[24]), 285 - tail - RandomNumber(randomMin, randomMax[24]), 10, 10);
                Rectangle fireTail9 = new Rectangle(320 + RandomNumber(randomMin, randomMax[25]), 295 - tail - RandomNumber(randomMin, randomMax[25]), 10, 10);
                Rectangle fireTail10 = new Rectangle(325 + RandomNumber(randomMin, randomMax[26]), 300 - tail - RandomNumber(randomMin, randomMax[26]), 10, 10);
                #region tailValue
                if (tailValue.Value == 1)
                {
                    p.Graphics.FillEllipse(Brushes.Red, fireTail1);
                }
                if (tailValue.Value == 2)
                {
                    p.Graphics.FillEllipse(Brushes.Red, fireTail1);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail2);
                }
                if (tailValue.Value == 3)
                {
                    p.Graphics.FillEllipse(Brushes.Red, fireTail1);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail2);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail3);
                }
                if (tailValue.Value == 4)
                {
                    p.Graphics.FillEllipse(Brushes.Red, fireTail1);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail2);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail3);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail4);
                }
                if (tailValue.Value == 5)
                {
                    p.Graphics.FillEllipse(Brushes.Red, fireTail1);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail2);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail3);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail4);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail5);
                }
                if (tailValue.Value == 6)
                {
                    p.Graphics.FillEllipse(Brushes.Red, fireTail1);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail2);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail3);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail4);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail5);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail6);
                }
                if (tailValue.Value == 7)
                {
                    p.Graphics.FillEllipse(Brushes.Red, fireTail1);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail2);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail3);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail4);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail5);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail6);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail7);
                }
                if (tailValue.Value == 8)
                {
                    p.Graphics.FillEllipse(Brushes.Red, fireTail1);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail2);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail3);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail4);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail5);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail6);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail7);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail8);
                }
                if (tailValue.Value == 9)
                {
                    p.Graphics.FillEllipse(Brushes.Red, fireTail1);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail2);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail3);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail4);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail5);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail6);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail7);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail8);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail9);
                }
                if (tailValue.Value == 10)
                {
                    p.Graphics.FillEllipse(Brushes.Red, fireTail1);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail2);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail3);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail4);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail5);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail6);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail7);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail8);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail9);
                    p.Graphics.FillEllipse(Brushes.Red, fireTail10);
                }
                #endregion
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //making the fire tail keep going up untill it reach "tailHigh.Value"
            tail += 4;
            if (tail > tailHigh.Value)
            {
                tail = 0;
            }
            //refresh the picturebox we use to preview the fire
            pictureBox3.Refresh();
            #region export
            //export to image sequence
            using (Bitmap bitmap = new Bitmap(pictureBox3.Width, pictureBox3.Height)) //create a bitmap
            {
                
                if (export)
                {                    
                    //paint the fire to the bitmap
                    Graphics g = Graphics.FromImage(bitmap);
                    #region paint
                    if (Fire.Checked)
                    {
                        #region settings              
                        randomMax[0] = decimal.ToInt32(SensivityY.Value) + 1;
                        randomMax[1] = decimal.ToInt32(SensivityY.Value) + 1;
                        randomMax[2] = decimal.ToInt32(SensivityY.Value) + 1;
                        randomMax[3] = decimal.ToInt32(SensivityY.Value) + 2;
                        randomMax[4] = decimal.ToInt32(SensivityY.Value) + 1;
                        randomMax[5] = decimal.ToInt32(SensivityY.Value) + 1;
                        randomMax[6] = decimal.ToInt32(SensivityY.Value) + 2;
                        randomMax[7] = decimal.ToInt32(SensivityY.Value) + 3;
                        randomMax[8] = decimal.ToInt32(SensivityY.Value) + 2;
                        randomMax[9] = decimal.ToInt32(SensivityY.Value) + 1;
                        randomMax[10] = decimal.ToInt32(SensivityY.Value) + 2;
                        randomMax[11] = decimal.ToInt32(SensivityY.Value) + 3;
                        randomMax[12] = decimal.ToInt32(SensivityY.Value) + 1;
                        randomMax[13] = decimal.ToInt32(SensivityY.Value) + 2;
                        randomMax[14] = decimal.ToInt32(SensivityY.Value) + 2;
                        randomMax[15] = decimal.ToInt32(SensivityY.Value) + 3;
                        randomMax[16] = decimal.ToInt32(SensivityY.Value) + 6;
                        randomMax[17] = decimal.ToInt32(SensivityY.Value) + 5;
                        randomMax[18] = decimal.ToInt32(SensivityY.Value) + 7;
                        randomMax[19] = decimal.ToInt32(SensivityY.Value) + 6;
                        randomMax[20] = decimal.ToInt32(SensivityY.Value) + 5;
                        randomMax[21] = decimal.ToInt32(SensivityY.Value) + 5;
                        randomMax[22] = decimal.ToInt32(SensivityY.Value) + 6;
                        randomMax[23] = decimal.ToInt32(SensivityY.Value) + 7;
                        randomMax[24] = decimal.ToInt32(SensivityY.Value) + 6;
                        randomMax[25] = decimal.ToInt32(SensivityY.Value) + 5;
                        randomMax[26] = decimal.ToInt32(SensivityY.Value) + 5;

                        sensitivity[0] = decimal.ToInt32(SensivityX.Value) + 1;
                        sensitivity[1] = decimal.ToInt32(SensivityX.Value) + 1;
                        sensitivity[2] = decimal.ToInt32(SensivityX.Value) + 1;
                        sensitivity[3] = decimal.ToInt32(SensivityX.Value) + 2;
                        sensitivity[4] = decimal.ToInt32(SensivityX.Value) + 1;
                        sensitivity[5] = decimal.ToInt32(SensivityX.Value) + 1;
                        sensitivity[6] = decimal.ToInt32(SensivityX.Value) + 2;
                        sensitivity[7] = decimal.ToInt32(SensivityX.Value) + 3;
                        sensitivity[8] = decimal.ToInt32(SensivityX.Value) + 2;
                        sensitivity[9] = decimal.ToInt32(SensivityX.Value) + 1;
                        sensitivity[10] = decimal.ToInt32(SensivityX.Value) + 2;
                        sensitivity[11] = decimal.ToInt32(SensivityX.Value) + 3;
                        sensitivity[12] = decimal.ToInt32(SensivityX.Value) + 1;
                        sensitivity[13] = decimal.ToInt32(SensivityX.Value) + 2;
                        sensitivity[14] = decimal.ToInt32(SensivityX.Value) + 2;
                        sensitivity[15] = decimal.ToInt32(SensivityX.Value) + 3;
                        sensitivity[16] = decimal.ToInt32(SensivityX.Value) + 6;
                        speed = decimal.ToInt32(Speed.Value);

                        #endregion
                        #region animation
                        Rectangle fireDown1 = new Rectangle(300 + RandomNumber(randomMin, sensitivity[1]), 300 - RandomNumber(randomMin, randomMax[1]), 10, 10);
                        Rectangle fireDown2 = new Rectangle(295 + RandomNumber(randomMin, sensitivity[2]), 299 - RandomNumber(randomMin, randomMax[2]), 10, 10);
                        Rectangle fireDown3 = new Rectangle(290 + RandomNumber(randomMin, sensitivity[3]), 295 - RandomNumber(randomMin, randomMax[3]), 10, 10);
                        Rectangle fireDown4 = new Rectangle(305 + RandomNumber(randomMin, sensitivity[4]), 299 - RandomNumber(randomMin, randomMax[4]), 10, 10);
                        Rectangle fireDown5 = new Rectangle(310 + RandomNumber(randomMin, sensitivity[5]), 295 - RandomNumber(randomMin, randomMax[5]), 10, 10);
                        Rectangle fireRate1 = new Rectangle(300 + RandomNumber(randomMin, sensitivity[6]), 295 - RandomNumber(randomMin, randomMax[6]), 10, 10);
                        Rectangle fireRate2 = new Rectangle(300 + RandomNumber(randomMin, sensitivity[7]), 290 - RandomNumber(randomMin, randomMax[7]), 10, 10);
                        Rectangle fireRate3 = new Rectangle(293 + RandomNumber(randomMin, sensitivity[8]), 290 - RandomNumber(randomMin, randomMax[8]), 10, 10);
                        Rectangle fireRate4 = new Rectangle(295 + RandomNumber(randomMin, sensitivity[9]), 290 - RandomNumber(randomMin, randomMax[9]), 10, 10);
                        Rectangle fireRate5 = new Rectangle(305 + RandomNumber(randomMin, sensitivity[10]), 290 - RandomNumber(randomMin, randomMax[10]), 10, 10);
                        Rectangle fireRate6 = new Rectangle(308 + RandomNumber(randomMin, sensitivity[11]), 290 - RandomNumber(randomMin, randomMax[11]), 10, 10);
                        Rectangle fireRate7 = new Rectangle(295 + RandomNumber(randomMin, sensitivity[12]), 295 - RandomNumber(randomMin, randomMax[12]), 10, 10);
                        Rectangle fireUp1 = new Rectangle(300 + RandomNumber(randomMin, sensitivity[13]), 285 - RandomNumber(randomMin, randomMax[13]), 10, 10);
                        Rectangle fireUp2 = new Rectangle(303 + RandomNumber(randomMin, sensitivity[14]), 285 - RandomNumber(randomMin, randomMax[14]), 10, 10);
                        Rectangle fireUp3 = new Rectangle(297 + RandomNumber(randomMin, sensitivity[15]), 285 - RandomNumber(randomMin, randomMax[15]), 10, 10);
                        Rectangle fireUp4 = new Rectangle(298 + RandomNumber(randomMin, sensitivity[16]), 280 - RandomNumber(randomMin, randomMax[16]), 10, 10);
                        #endregion
                        g.FillEllipse(Brushes.Red, fireDown1);
                        g.FillEllipse(Brushes.Red, fireDown2);
                        g.FillEllipse(Brushes.Red, fireDown3);
                        g.FillEllipse(Brushes.Red, fireDown4);
                        g.FillEllipse(Brushes.Red, fireDown5);
                        g.FillEllipse(Brushes.Red, fireRate1);
                        g.FillEllipse(Brushes.Red, fireRate2);
                        g.FillEllipse(Brushes.Red, fireRate3);
                        g.FillEllipse(Brushes.Red, fireRate4);
                        g.FillEllipse(Brushes.Red, fireRate5);
                        g.FillEllipse(Brushes.Red, fireRate6);
                        g.FillEllipse(Brushes.Red, fireRate7);
                        g.FillEllipse(Brushes.Red, fireUp1);
                        g.FillEllipse(Brushes.Red, fireUp2);
                        g.FillEllipse(Brushes.Red, fireUp3);
                        g.FillEllipse(Brushes.Red, fireUp4);
                    }
                    if (tailBox.Checked)
                    {
                        Rectangle fireTail1 = new Rectangle(290 + RandomNumber(randomMin, randomMax[17]), 290 - tail - RandomNumber(randomMin, randomMax[17]), 10, 10);
                        Rectangle fireTail2 = new Rectangle(300 + RandomNumber(randomMin, randomMax[18]), 295 - tail - RandomNumber(randomMin, randomMax[18]), 10, 10);
                        Rectangle fireTail3 = new Rectangle(305 + RandomNumber(randomMin, randomMax[19]), 290 - tail - RandomNumber(randomMin, randomMax[19]), 10, 10);
                        Rectangle fireTail4 = new Rectangle(310 + RandomNumber(randomMin, randomMax[20]), 305 - tail - RandomNumber(randomMin, randomMax[20]), 10, 10);
                        Rectangle fireTail5 = new Rectangle(295 + RandomNumber(randomMin, randomMax[21]), 300 - tail - RandomNumber(randomMin, randomMax[21]), 10, 10);
                        Rectangle fireTail6 = new Rectangle(315 + RandomNumber(randomMin, randomMax[22]), 310 - tail - RandomNumber(randomMin, randomMax[22]), 10, 10);
                        Rectangle fireTail7 = new Rectangle(285 + RandomNumber(randomMin, randomMax[23]), 300 - tail - RandomNumber(randomMin, randomMax[23]), 10, 10);
                        Rectangle fireTail8 = new Rectangle(280 + RandomNumber(randomMin, randomMax[24]), 285 - tail - RandomNumber(randomMin, randomMax[24]), 10, 10);
                        Rectangle fireTail9 = new Rectangle(320 + RandomNumber(randomMin, randomMax[25]), 295 - tail - RandomNumber(randomMin, randomMax[25]), 10, 10);
                        Rectangle fireTail10 = new Rectangle(325 + RandomNumber(randomMin, randomMax[26]), 300 - tail - RandomNumber(randomMin, randomMax[26]), 10, 10);
                        #region tailValue
                        if (tailValue.Value == 1)
                        {
                            g.FillEllipse(Brushes.Red, fireTail1);
                        }
                        if (tailValue.Value == 2)
                        {
                            g.FillEllipse(Brushes.Red, fireTail1);
                            g.FillEllipse(Brushes.Red, fireTail2);
                        }
                        if (tailValue.Value == 3)
                        {
                            g.FillEllipse(Brushes.Red, fireTail1);
                            g.FillEllipse(Brushes.Red, fireTail2);
                            g.FillEllipse(Brushes.Red, fireTail3);
                        }
                        if (tailValue.Value == 4)
                        {
                            g.FillEllipse(Brushes.Red, fireTail1);
                            g.FillEllipse(Brushes.Red, fireTail2);
                            g.FillEllipse(Brushes.Red, fireTail3);
                            g.FillEllipse(Brushes.Red, fireTail4);
                        }
                        if (tailValue.Value == 5)
                        {
                            g.FillEllipse(Brushes.Red, fireTail1);
                            g.FillEllipse(Brushes.Red, fireTail2);
                            g.FillEllipse(Brushes.Red, fireTail3);
                            g.FillEllipse(Brushes.Red, fireTail4);
                            g.FillEllipse(Brushes.Red, fireTail5);
                        }
                        if (tailValue.Value == 6)
                        {
                            g.FillEllipse(Brushes.Red, fireTail1);
                            g.FillEllipse(Brushes.Red, fireTail2);
                            g.FillEllipse(Brushes.Red, fireTail3);
                            g.FillEllipse(Brushes.Red, fireTail4);
                            g.FillEllipse(Brushes.Red, fireTail5);
                            g.FillEllipse(Brushes.Red, fireTail6);
                        }
                        if (tailValue.Value == 7)
                        {
                            g.FillEllipse(Brushes.Red, fireTail1);
                            g.FillEllipse(Brushes.Red, fireTail2);
                            g.FillEllipse(Brushes.Red, fireTail3);
                            g.FillEllipse(Brushes.Red, fireTail4);
                            g.FillEllipse(Brushes.Red, fireTail5);
                            g.FillEllipse(Brushes.Red, fireTail6);
                            g.FillEllipse(Brushes.Red, fireTail7);
                        }
                        if (tailValue.Value == 8)
                        {
                            g.FillEllipse(Brushes.Red, fireTail1);
                            g.FillEllipse(Brushes.Red, fireTail2);
                            g.FillEllipse(Brushes.Red, fireTail3);
                            g.FillEllipse(Brushes.Red, fireTail4);
                            g.FillEllipse(Brushes.Red, fireTail5);
                            g.FillEllipse(Brushes.Red, fireTail6);
                            g.FillEllipse(Brushes.Red, fireTail7);
                            g.FillEllipse(Brushes.Red, fireTail8);
                        }
                        if (tailValue.Value == 9)
                        {
                            g.FillEllipse(Brushes.Red, fireTail1);
                            g.FillEllipse(Brushes.Red, fireTail2);
                            g.FillEllipse(Brushes.Red, fireTail3);
                            g.FillEllipse(Brushes.Red, fireTail4);
                            g.FillEllipse(Brushes.Red, fireTail5);
                            g.FillEllipse(Brushes.Red, fireTail6);
                            g.FillEllipse(Brushes.Red, fireTail7);
                            g.FillEllipse(Brushes.Red, fireTail8);
                            g.FillEllipse(Brushes.Red, fireTail9);
                        }
                        if (tailValue.Value == 10)
                        {
                            g.FillEllipse(Brushes.Red, fireTail1);
                            g.FillEllipse(Brushes.Red, fireTail2);
                            g.FillEllipse(Brushes.Red, fireTail3);
                            g.FillEllipse(Brushes.Red, fireTail4);
                            g.FillEllipse(Brushes.Red, fireTail5);
                            g.FillEllipse(Brushes.Red, fireTail6);
                            g.FillEllipse(Brushes.Red, fireTail7);
                            g.FillEllipse(Brushes.Red, fireTail8);
                            g.FillEllipse(Brushes.Red, fireTail9);
                            g.FillEllipse(Brushes.Red, fireTail10);
                        }
                        #endregion
                    }
                    #endregion //paint the fire to the bitmap

                    //adding transparency to it
                    var rect = new Rectangle(0, 0, 10, 10);
                    var bmpData = bitmap.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                    var ptr = bmpData.Scan0;
                    var bytes = Math.Abs(bmpData.Stride);
                    Pixels = new byte[bytes];
                    Marshal.Copy(ptr, Pixels, 0, bytes);
                    
                    frame += 1;
                    if (pngSequence.Checked)//if the user wanted to export to png
                    {
                        bitmap.Save(@directoryBox.Text + " " + frame + ".png", ImageFormat.Png);
                        bmpSequence.Checked = false;
                        jpgSequence.Checked = false;
                    }
                    else if (bmpSequence.Checked)//if the user wanted to export to Bitmap
                    {
                        bitmap.Save(@directoryBox.Text + " " + frame + ".bmp", ImageFormat.Bmp);
                        pngSequence.Checked = false;
                        jpgSequence.Checked = false;
                    }
                    else if (jpgSequence.Checked) //if the user wanted to export to jpeg
                    {
                        bitmap.Save(@directoryBox.Text + " " + frame + ".jpg", ImageFormat.Jpeg);
                        pngSequence.Checked = false;
                        bmpSequence.Checked = false;
                    }
                    if (frame >= frameExportLimit.Value)
                    {
                        export = false;
                        frame = 0;
                    }
                }
                //if the user want to change the speed of the fire
                #region speedConfig
                if (speed == 1)
                {
                    timer1.Interval = 50;
                }
                if (speed == 2)
                {
                    timer1.Interval = 100;
                }
                if (speed == 3)
                {
                    timer1.Interval = 150;
                }
                if (speed == 5)
                {
                    timer1.Interval = 200;
                }
                if (speed == 6)
                {
                    timer1.Interval = 250;
                }
                if (speed == 7)
                {
                    timer1.Interval = 300;
                }
                if (speed == 8)
                {
                    timer1.Interval = 350;
                }
                if (speed == 9)
                {
                    timer1.Interval = 400;
                }
                if (speed == 10)
                {
                    timer1.Interval = 450;
                }
                #endregion
            }
            #endregion
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            export = true; //it will calls the export function for "frameExportLimit.Value"
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
