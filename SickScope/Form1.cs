using System;
using System.Drawing;
using System.Windows.Forms;

namespace SickScope
{
    public partial class Form1 : Form
    {
        private MouseHook mouseHook;
        private KeyboardHook KeyboardHookLock;
        private int x;
        private int y;
        private bool lockX;
        private bool lockY;

        private bool altPressed;
        private bool shiftPressed;
        private bool xPressed;
        private bool yPressed;

        private int captureCounter = 0;
        private int capCounterMax = 4;

        private Color horizontalLineColor = Color.Lime;
        private Color verticalLineColor = Color.Lime;


        public Form1()
        {
            InitializeComponent();

            numWidth.Maximum = Screen.PrimaryScreen.Bounds.Width;
            numHeight.Maximum = Screen.PrimaryScreen.Bounds.Height;

            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
            SetSize();
            SetupEvents();

            pan_HorizontalColor.BackColor = horizontalLineColor;
            pan_VerticalColor.BackColor = verticalLineColor;
        }

        public void CaptureScreen()
        {
            int horThick = (int)numHThick.Value;
            int verThick = (int)numVThick.Value;

            int width = (int)numWidth.Value;
            int height = (int)numHeight.Value;

            Pen hPen = new Pen(new SolidBrush(horizontalLineColor), (float)horThick);
            Pen vPen = new Pen(new SolidBrush(verticalLineColor), (float)verThick);
            Bitmap b = new Bitmap(width, height);
            pictureBox1.Width = width * ((cb_Zoom.Checked) ? 2 : 1);
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
                    g.DrawLine(vPen, new Point(num1, 0), new Point(num1, height - 1));
                }
            }
            pictureBox1.Image = b;
        }

        private void SetupEvents()
        {
            mouseHook = new MouseHook();
            KeyboardHookLock = new KeyboardHook();
            mouseHook.MouseMove += MouseHook_MouseMove;
            KeyboardHookLock.KeyDown += KeyboardHook_Lock_KeyDown;
            KeyboardHookLock.KeyUp += KeyboardHookLock_KeyUp;
            mouseHook.Install();
            KeyboardHookLock.Install();
        }

        private void MouseHook_MouseMove(MouseHook.MSLLHOOKSTRUCT mouseStruct)
        {
            int mX = mouseStruct.pt.x;
            int mY = mouseStruct.pt.y;

            // Only Update when the mouse was Moved
            if (mX != x || mY != y)
            {
                // Refresh
                captureCounter++;

                // Only Update when axis is not locked
                if (!lockX)
                    x = mX;

                if (!lockY)
                    y = mY;


                if (captureCounter >= capCounterMax)
                {
                    if (cb_IgnoreScope.Checked)
                        if( mX >= this.Location.X && mX <= this.Location.X + this.Width)
                            if(mY >= this.Location.Y && mY <= this.Location.Y + this.Height)
                                return;

                    CaptureScreen();
                    captureCounter = 0;
                }
            }
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            mouseHook.MouseMove -= new MouseHook.MouseHookCallback(MouseHook_MouseMove);
            mouseHook.Uninstall();
        }

        private void SetSize()
        {
            this.Width = 210 + (int)(numWidth.Value * ((cb_Zoom.Checked) ? 2 : 1));
            this.Height = 36 + (int)(numHeight.Value * ((cb_Zoom.Checked) ? 2 : 1));
            if (this.Height < 390)
                this.Height = 390;
        }

        #region KeyboardHook Events, SwitchKey, ChangeLocks
        private void KeyboardHookLock_KeyUp(KeyboardHook.VKeys key)
        {
            SwitchKey(key, false);
            ChangeLocks();
        }

        private void KeyboardHook_Lock_KeyDown(KeyboardHook.VKeys key)
        {
            SwitchKey(key, true);
            ChangeLocks();
        }

        private void SwitchKey(KeyboardHook.VKeys key, bool isDownEvent)
        {
            switch (key)
            {
                case KeyboardHook.VKeys.LSHIFT:
                    shiftPressed = isDownEvent;
                    break;

                case KeyboardHook.VKeys.LMENU:
                    altPressed = isDownEvent;
                    break;

                case KeyboardHook.VKeys.KEY_X:
                    xPressed = isDownEvent;
                    break;

                case KeyboardHook.VKeys.KEY_Y:
                    yPressed = isDownEvent;
                    break;
            }
        }

        private void ChangeLocks()
        {
            if (altPressed & shiftPressed & xPressed)
            {

                lockX = !lockX;
                cb_LockX.Checked = lockX;
            }
            if (altPressed && shiftPressed && yPressed)
            {
                lockY = !lockY;
                cb_LockY.Checked = lockY;
            }
        }

        #endregion KeyboardHook Events

        #region Control Events
        private void cb_LockX_MouseClick(object sender, MouseEventArgs e)
        {
            lockX = cb_LockX.Checked;
        }

        private void cb_LockY_MouseClick(object sender, MouseEventArgs e)
        {
            lockY = cb_LockY.Checked;
        }

        private void cb_Zoom_CheckedChanged(object sender, EventArgs e)
        {
            SetSize();
        }

        private void pan_HorizontalColor_MouseClick(object sender, MouseEventArgs e)
        {
            colorDialog1.ShowDialog();
            horizontalLineColor = colorDialog1.Color;
            pan_HorizontalColor.BackColor = horizontalLineColor;
        }

        private void pan_VerticalColor_MouseClick(object sender, MouseEventArgs e)
        {
            colorDialog1.ShowDialog();
            verticalLineColor = colorDialog1.Color;
            pan_VerticalColor.BackColor = verticalLineColor;
        }

        private void numHeight_ValueChanged(object sender, EventArgs e)
        {
            SetSize();
        }

        private void numWidth_ValueChanged(object sender, EventArgs e)
        {
            SetSize();
        }

        #endregion Numeric Width / Height Events

        
    }
}