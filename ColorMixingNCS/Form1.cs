using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorMixingNCS
{
    public partial class Form1 : Form
    {
        /*
            Přelévání do prázdných kyblíků (snižování volume)
            Pro projevení změny barvu promíchat (špinění míchátka)
            mřížka nebo vanička + Nanášení válečkem
            Schnutí barvy (tepelná pistol?)
        */


        string history = "";

        RybColor targetColor = new RybColor();
        RybColor TargetColor
        {
            get { return targetColor; }
            set
            {
                targetColor = value;
                targetColorPct.BackColor = ConvertToRgb(targetColor);
                textBox1.Text = targetColor.ToString();

                currentColorPct.BackColor = Color.White;
            }
        }

        RybColor currentColor = new RybColor();
        RybColor CurrentColor
        {
            get { return currentColor; }
            set
            {
                currentColor = value;
                currentColorPct.BackColor = ConvertToRgb(currentColor);

                //textBox1.Text = currentColor.ToString();
                label2.Text = currentColor.ToString();
                var clr = ConvertToRgb(currentColor);
                rgb_lbl_val.Text = $"({clr.R},{clr.G},{clr.B})";
            }
        }

        int silaPigmentu = 10000;

        int volume = 0;
        int Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                label3.Text = volume + "ml";
            }
        }

        int Val => (int)numericUpDown1.Value;

        public Form1()
        {
            InitializeComponent();

        }

        struct RybColor
        {
            public int Red;
            public int Yellow;
            public int Blue;

            public RybColor(int red, int yellow, int blue)
            {
                Red = Math.Max(Math.Min(red, 255), 0);
                Yellow = Math.Max(Math.Min(yellow, 255), 0); ;
                Blue = Math.Max(Math.Min(blue, 255), 0); ;
            }

            public override string ToString()
            {
                return Red + ", " + Yellow + ", " + Blue;
            }
        }

        private Color ConvertToRgb(RybColor color)
        {
            var R = color.Red / 255.0;
            var Y = color.Yellow / 255.0;
            var B = color.Blue / 255.0;

            var R1 = getR(R, Y, B);
            var G1 = getG(R, Y, B);
            var B1 = getB(R, Y, B);

            return Color.FromArgb(R1, G1, B1);
        }

        private double cubicInt(double t, double A, double B)
        {
            var weight = t * t * (3 - 2 * t);
            return A + weight * (B - A);
        }

        private int getR(double iR, double iY, double iB)
        {
            var x0 = cubicInt(iB, 1.0, 0.163);
            var x1 = cubicInt(iB, 1.0, 0.0);
            var x2 = cubicInt(iB, 1.0, 0.5);
            var x3 = cubicInt(iB, 1.0, 0.2);
            var y0 = cubicInt(iY, x0, x1);
            var y1 = cubicInt(iY, x2, x3);
            return (int)Math.Ceiling(255 * cubicInt(iR, y0, y1));
        }
        private int getG(double iR, double iY, double iB)
        {
            var x0 = cubicInt(iB, 1.0, 0.373);
            var x1 = cubicInt(iB, 1.0, 0.66);
            var x2 = cubicInt(iB, 0.0, 0.0);
            var x3 = cubicInt(iB, 0.5, 0.094);
            var y0 = cubicInt(iY, x0, x1);
            var y1 = cubicInt(iY, x2, x3);
            return (int)Math.Ceiling(255 * cubicInt(iR, y0, y1));
        }
        private int getB(double iR, double iY, double iB)
        {
            var x0 = cubicInt(iB, 1.0, 0.6);
            var x1 = cubicInt(iB, 0.0, 0.2);
            var x2 = cubicInt(iB, 0.0, 0.5);
            var x3 = cubicInt(iB, 0.0, 0.0);
            var y0 = cubicInt(iY, x0, x1);
            var y1 = cubicInt(iY, x2, x3);
            return (int)Math.Ceiling(255 * cubicInt(iR, y0, y1));
        }

        private void Log(string str)
        {
            history += str + "\n";
            richTextBox1.Text = history;
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e) // show RYB
        {
            
        }

        private void button14_Click(object sender, EventArgs e) // generování barvy
        {
            int maxTmavost = 200;

            Random r = new Random();
            SetNewColor(r.Next(0, maxTmavost), r.Next(0, maxTmavost), r.Next(0, maxTmavost));

            Log("Vygenerovala se nová cílová barva");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            var nums = textBox1.Text.Split(',');
            if (nums.Length == 3)
            {
                SetNewColor(int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(nums[2]));
                Log("Nastavila se nová cílová barva");
            }
        }

        private void SetNewColor(int r, int y, int b)
        {
            TargetColor = new RybColor()
            {
                Red = r,
                Yellow = y,
                Blue = b
            };

            Volume = 5000;
        }

        private void AddjustColor(int deltaR, int deltaY, int deltaB)
        {
            int minAmnt = Math.Max(Math.Max(deltaR, deltaY), deltaB);
            Volume += deltaR + deltaY + deltaB;

            if (currentColor.Red == 255 && deltaR > 0)
            {
                if (deltaY == 0)
                    deltaY -= (int)(currentColor.Yellow * 0.01 * minAmnt);
                if (deltaB == 0)
                    deltaB -= (int)(currentColor.Blue * 0.01 * minAmnt);
            }

            if (currentColor.Yellow == 255 && deltaY > 0)
            {
                if (deltaR == 0)
                    deltaR -= (int)(currentColor.Red * 0.01 * minAmnt);
                if (deltaB == 0)
                    deltaB -= (int)(currentColor.Blue * 0.01 * minAmnt);
            }

            if (currentColor.Blue == 255 && deltaB > 0)
            {
                if (deltaR == 0)
                    deltaR -= (int)(currentColor.Red * 0.01 * minAmnt);
                if (deltaY == 0)
                    deltaY -= (int)(currentColor.Yellow * 0.01 * minAmnt);
            }

            int newR = currentColor.Red + (int)((double)deltaR / volume * silaPigmentu);
            int newY = currentColor.Yellow + (int)((double)deltaY / volume * silaPigmentu);
            int newB = currentColor.Blue + (int)((double)deltaB / volume * silaPigmentu);


            CurrentColor = new RybColor(
                    newR,
                    newY,
                    newB
                );

            
        }

        private void button2_Click(object sender, EventArgs e) // B
        {
            AddjustColor(0, 0, Val);
            Log($"Přilil jsi {Val}ml modré");
        }

        private void button1_Click(object sender, EventArgs e) // Y
        {
            AddjustColor(0, Val, 0);
            Log($"Přilil jsi {Val}ml žluté");
        }

        private void button3_Click(object sender, EventArgs e) // R
        {
            AddjustColor(Val, 0, 0);
            Log($"Přilil jsi {Val}ml červené");
        }

        private void button5_Click(object sender, EventArgs e) // G
        {
            AddjustColor(0, Val / 2, Val / 2);
            Log($"Přilil jsi {Val}ml zelené");
        }

        private void button6_Click(object sender, EventArgs e) // O
        {
            AddjustColor(Val / 2, Val / 2, 0);
            Log($"Přilil jsi {Val}ml oranžové");
        }

        private void button4_Click(object sender, EventArgs e) // M
        {
            AddjustColor(Val / 2, 0, Val / 2);
            Log($"Přilil jsi {Val}ml fialové");
        }

        private void button16_Click(object sender, EventArgs e) // W
        {
            int sum = volume + Val;
            double rat = (double)volume / sum;

            CurrentColor = new RybColor(
                (int)(currentColor.Red * rat),
                (int)(currentColor.Yellow * rat),
                (int)(currentColor.Blue * rat)
                );

            Log($"Přilil jsi {Val}ml bílé");
            Volume += Val;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            silaPigmentu = trackBar1.Value;
            label8.Text = silaPigmentu.ToString();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            int sum = volume + Val;
            double rat = (double)volume / sum;

            // doladit!

            /*
             currentColor.Red * (1+rat) dá při currentColor.Red == 0 zase 0, takže bílá nikdy neztmavne!
             */


            CurrentColor = new RybColor(
                (int)(currentColor.Red * (1+rat)),
                (int)(currentColor.Yellow * (1+rat)),
                (int)(currentColor.Blue * (1+rat))
                );

            Log($"Přilil jsi {Val}ml černé");
            Volume += Val;
        }
    }
}
