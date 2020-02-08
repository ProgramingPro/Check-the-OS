using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Check_the_OS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            GetOSVersion();
        }
        public void GetOSVersion()
        {
            int _MajorVersion = Environment.OSVersion.Version.Major;

            if (_MajorVersion == 5)
            {
                label1.Text = "XP";
                label2.Text = (_MajorVersion).ToString();
            }
            else
            {
                label1.Text = "NOT XP";
                label2.Text = (_MajorVersion).ToString();
            }
        }
    }
}
