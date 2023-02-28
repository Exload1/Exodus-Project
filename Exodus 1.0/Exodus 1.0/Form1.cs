using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;

namespace Exodus_1._0
{
    public partial class Form1 : Form
    {

        ExploitAPI module = new ExploitAPI();

        Point lastPoint;

        public bool isScriptHubOpened = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            scriptbox.Items.Clear();//Clear Items in the LuaScriptList
            Functions.PopulateListBox(scriptbox, "./Scripts", "*.txt");
            Functions.PopulateListBox(scriptbox, "./Scripts", "*.lua");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            module.LaunchExploit();
        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void execute_Click(object sender, EventArgs e)
        {
            module.SendLuaScript(textbox.Text);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textbox.Clear();
        }

        private void openfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Title = "Open";
                textbox.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void savefile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(textbox.Text);
                }
            }
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

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ScriptHub openform = new ScriptHub();
            if(openform.isOpened == false)
            {
                openform.Show();
                openform.isOpened = true;
            }
        }

        private void scriptbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            textbox.Text = File.ReadAllText($"./Scripts/{scriptbox.SelectedItem}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            scriptbox.Items.Clear();//Clear Items in the LuaScriptList
            Functions.PopulateListBox(scriptbox, "./Scripts", "*.txt");
            Functions.PopulateListBox(scriptbox, "./Scripts", "*.lua");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
