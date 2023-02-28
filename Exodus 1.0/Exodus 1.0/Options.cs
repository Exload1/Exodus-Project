using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;

namespace Exodus_1._0
{
    public partial class Options : Form
    {

        ExploitAPI module = new ExploitAPI();
        Point lastPoint;

        public Options()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process[] roblox = Process.GetProcesses();

            foreach (Process openedroblox in roblox)
            {
                bool flag = openedroblox.ProcessName == "RobloxPlayerBeta";

                if (flag)
                {
                    openedroblox.Kill();
                }
            }
        }
    }
}
