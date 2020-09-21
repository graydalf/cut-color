using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CutColor
{
    public partial class MainForm : Form
    {
        MouseHook mh;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            mh = new MouseHook();
            mh.SetHook();
            mh.MouseUpEvent += Mh_MouseUpEvent;
            mh.MouseMoveEvent += Mh_MouseMoveEvent;
        }

        private void Mh_MouseUpEvent(object sender, MouseEventArgs e)
        {
            Point point = e.Location;
            tbColorsHistory.AppendText(point.X + "," + point.Y + "\n");
        }

        private void Mh_MouseMoveEvent(object sender, MouseEventArgs e)
        {
            Point point = e.Location;
            Color color = getColor(point);
            tbMouseColor.Text = point.X + "," + point.Y + " " + color.Name.ToUpper().Substring(2);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mh.UnHook();
        }

        public Color getColor(Point p)
        {
            int c = getColorValue(p);//取指定点颜色
            int r = (c & 0xFF);//转换R
            int g = (c & 0xFF00) / 256;//转换G
            int b = (c & 0xFF0000) / 65536;//转换B
            // tbMouseColor.BackColor = Color.FromArgb(r, g, b);
            return Color.FromArgb(r, g, b);
        }

        public int getColorValue(Point p) 
        {
            IntPtr hdc = Win32.GetDC(new IntPtr(0));//取到设备场景(0就是全屏的设备场景)
            return Win32.GetPixel(hdc, p);//取指定点颜色
        }
    }
}
