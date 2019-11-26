using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileEncoderForMPT
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            

        }

        private void OpenFileEncoder_Click(object sender, EventArgs e)
        {
            FileEncoder fileEncoder = new FileEncoder();          
            fileEncoder.Show();
            Hide();

        }

        private void OpenTextEncoder_Click(object sender, EventArgs e)
        {
            TextEncoder textEncoder = new TextEncoder();
            textEncoder.Show();
            Hide();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
