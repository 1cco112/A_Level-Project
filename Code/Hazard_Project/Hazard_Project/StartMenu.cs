using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hazard_Project
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void NewGame_Click(object sender, EventArgs e)
        {
            GameBoard form = new GameBoard();
            form.Show();
            this.Hide();           
        }
        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Help_Click(object sender, EventArgs e)
        {
            try
            {
                string text = File.ReadAllText(@"D:/College/Computer Science/rules.txt");
                HelpBox.Text = text;
                HelpBoxQuit.Visible = true;
                HelpBox.BackColor = SystemColors.Control;
                HelpBox.Visible = true;
            }
            catch
            {
                HelpBox.Text = ("Help file not found. Please follow the webaddress - www.hasbro.com/risk/game-rules");
                HelpBoxQuit.Visible = true;
                HelpBox.BackColor = SystemColors.Control;
                HelpBox.Visible = true;
            }

        }

        private void HelpBoxQuit_Click(object sender, EventArgs e)
        {
            HelpBoxQuit.Visible = false;
            HelpBox.Visible = false;
        }
    }
}
