using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SandBoxProjects
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public Pen pen = new Pen(System.Drawing.Color.FromArgb(255,255,255), 10);
        public Int32 regime = 1;
        public Int32 uptime = 0;
        public Int32 swaps = 0;
        public Int32 orderedCube = 1;
        public Int32[] cc = { 0, 0, 0};
        public Int32[] ccd = { 0, 0, 0 };

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        // Exit-Button
        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.ForeColor = System.Drawing.Color.FromArgb(70, 70, 70);
        }
        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.ForeColor = System.Drawing.Color.FromArgb(255,255,255);
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // OnStart
        private void MainForm_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = this.CreateGraphics();
            Thread mainThread = new Thread(() => PaintPatern(canvas));
            mainThread.Start();
        }

        public void PaintPatern(Graphics canvas)
        {
            try
            {
                for (; ; )
                {
                    if (regime == 1)
                    {
                        for (int y = 0; y <= 12; y++)
                        {
                            for (int x = 0; x <= 20; x++)
                            {
                                pen.Color = System.Drawing.Color.FromArgb(cc[0] + (y * 4 + x * 4), cc[1] + (y * 3 + x * 3), cc[2] + (y * 2 + x * 2));
                                canvas.DrawRectangle(pen, 10 + x * 33, 10 + y * 33, 20, 20);
                            }
                        }
                        Thread.Sleep(25);
                        SetPointing();
                        PointingIncrementation();
                    }
                    else if (regime == 2)
                    {
                        int run = 0;
                        for (int y = 0; y <= 12; y++)
                        {
                            for (int x = 0; x <= 20; x++)
                            {
                                if(run == orderedCube)
                                    pen.Color = System.Drawing.Color.FromArgb(255,255,255);
                                else
                                    pen.Color = System.Drawing.Color.FromArgb(0,0,0);

                                canvas.DrawRectangle(pen, 10 + x * 33, 10 + y * 33, 20, 20);
                                run++;
                            }
                        }
                        swaps++;
                        if (orderedCube >= 273)
                            orderedCube = 0;

                        orderedCube++;
                    }
                    else if (regime == 3)
                    {
                        int run = 0;
                        for (int y = 0; y <= 12; y++)
                        {
                            for (int x = 0; x <= 20; x++)
                            {
                                if (run % 2 == 0)
                                    pen.Color = System.Drawing.Color.FromArgb(255, 255, 255);
                                else
                                    pen.Color = System.Drawing.Color.FromArgb(0, 0, 0);

                                canvas.DrawRectangle(pen, 10 + x * 33, 10 + y * 33, 20, 20);
                                run++;
                            }
                        }
                    }
                }
            }
            catch (Exception ex) {}
        }

        public void SetPointing()
        {
            // Red
            if (cc[0] >= 70)
                ccd[0] = 1;
            else if (cc[0] <= 0)
                ccd[0] = 0;

            // Green
            if (cc[1] >= 100)
                ccd[1] = 1;
            else if (cc[1] <= 0)
                ccd[1] = 0;

            // Blue
            if (cc[2] >= 130)
                ccd[2] = 1;
            else if (cc[2] <= 0)
                ccd[2] = 0;
        }

        public void PointingIncrementation()
        {
            // Red
            if (ccd[0] == 0)
                cc[0] += 1;
            else
                cc[0] -= 1;

            // Green
            if (ccd[1] == 0)
                cc[1] += 2;
            else
                cc[1] -= 2;

            // Blue
            if (ccd[2] == 0)
                cc[2] += 3;
            else
                cc[2] -= 3;

            swaps++;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            string uptimeStr = AddZeroIfNecessary(uptime/60/60) + ":" + AddZeroIfNecessary(uptime/60) + ":" + AddZeroIfNecessary(uptime - ((uptime / 60)*60));
            ColorsLabel.Text = "RGB: ["+cc[0]+"," + cc[1] + "," + cc[2] +"] | Uptime: " + uptimeStr + " | Swaps: " + swaps + "x | Regime: " + regime;
            uptime++;
        }

        public string AddZeroIfNecessary(int value)
        {
            if (value < 10)
                return "0" + value.ToString();
            else
                return "" + value.ToString();
        }

        private void ColorDefault_Click(object sender, EventArgs e)
        {
            regime = 1;
            swaps = 0;
            setColorCodeBlack();
        }

        private void ColorRed_Click(object sender, EventArgs e)
        {
            regime = 2;
            orderedCube = 1;
            swaps = 0;
            setColorCodeBlack();
        }

        private void Color_Click(object sender, EventArgs e)
        {
            regime = 3;
            orderedCube = 125;
            swaps = 0;
            setColorCodeBlack();
        }

        public void setColorCodeBlack()
        {
            cc[0] = 0;
            cc[1] = 0;
            cc[2] = 0;
        }
    }
}
