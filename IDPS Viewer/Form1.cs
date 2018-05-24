using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDPS_Viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog thedialog = new OpenFileDialog();
            thedialog.Title = "Select Your IDPS.bin";
            thedialog.Filter = "PS3 IDPS File|idps.bin";
            thedialog.InitialDirectory = System.Environment.SpecialFolder.MyDocuments.ToString();
            if (thedialog.ShowDialog() == DialogResult.OK)
            {
                byte[] psid = System.IO.File.ReadAllBytes(thedialog.FileName);
                textBox1.Text = BitConverter.ToString(psid);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.xxxthedrakprogramerxxx.net");
        }
    }
}
