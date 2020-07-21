using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace SickScope
{
    public partial class Form1 : Form
    {
        MouseHook mouseHook;
        int x;
        int y;

        int captureCounter = 0;
        int capCounterMax = 10;

        public Form1()
        {
            InitializeComponent();

            numWidth.Maximum = Screen.PrimaryScreen.Bounds.Width;
            numHeight.Maximum = Screen.PrimaryScreen.Bounds.Height;
        }

        public void Capture()
        {
            int horThick = (int)numHThick.Value;
            int verThick = (int)numVThick.Value;

            int width = (int)numWidth.Value;
            int height = (int)numHeight.Value;

            Pen hPen = new Pen(new SolidBrush(Color.Lime), (float)horThick);
            Pen vPen = new Pen(new SolidBrush(Color.Lime), (float)verThick);
            Bitmap b = new Bitmap(width, height);
            pictureBox1.Width = width * ((cb_Zoom.Checked)? 2 : 1);
            pictureBox1.Height = height * ((cb_Zoom.Checked) ? 2 : 1);
            using (Graphics g = Graphics.FromImage(b))
            {
                g.CopyFromScreen(x - (int)Math.Floor(width / 2f), y - (int)Math.Floor(height / 2f), 0, 0, new Size((int)numWidth.Value, (int)numHeight.Value), CopyPixelOperation.SourceCopy);
                
                if (cb_Hor.Checked)
                {
                    int num2 = (height / 2) - (int)(Math.Ceiling(horThick / 2d));
                    g.DrawLine(hPen, new Point(0, num2), new Point(width - 1, num2));
                }
                if (cb_Vert.Checked)
                {
                    int num1 = (width / 2) - (int)(Math.Ceiling(verThick / 2d));
                    g.DrawLine(vPen, new Point(num1 , 0), new Point(num1 , height - 1));
                }
            }
            pictureBox1.Image = b;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            mouseHook = new MouseHook();
            mouseHook.MouseMove += MouseHook_MouseMove;
            mouseHook.Install();
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
            SetSize();
        }

        private void MouseHook_MouseMove(MouseHook.MSLLHOOKSTRUCT mouseStruct)
        {
            if(mouseStruct.pt.x != x || mouseStruct.pt.y != y)
            {
                x = mouseStruct.pt.x;
                y = mouseStruct.pt.y;
                captureCounter++;

                if(captureCounter >= capCounterMax)
                {
                    Capture();
                    captureCounter = 0;
                }
            }
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            
            mouseHook.MouseMove -= new MouseHook.MouseHookCallback(MouseHook_MouseMove);
            mouseHook.Uninstall();
        }

        private void cb_Zoom_CheckedChanged(object sender, EventArgs e)
        {
            SetSize();
        }

        private void SetSize()
        {

            this.Width = 210 + (int)(numWidth.Value * ((cb_Zoom.Checked) ? 2 : 1));
            this.Height = 36 + (int)(numHeight.Value * ((cb_Zoom.Checked) ? 2 : 1));
        }

        private void numHeight_ValueChanged(object sender, EventArgs e)
        {
            SetSize();
        }

        private void numWidth_ValueChanged(object sender, EventArgs e)
        {
            SetSize();
        }
    }
}