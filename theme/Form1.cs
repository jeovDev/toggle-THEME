using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace theme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getIni();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void siticoneOSToggleSwith1_CheckedChanged(object sender, EventArgs e)
        {
            settings setting = new settings();
            if (siticoneOSToggleSwith1.Checked == true)
            {
                
                setting.writeIni("SECTION","key","dark");
                this.BackColor = Color.FromArgb(32, 33, 36);
                this.ForeColor = Color.White;
                label1.Text = "DARK";

            }
            else {
                setting.writeIni("SECTION", "key", "light");
                this.BackColor = Color.White;
                this.ForeColor = Color.FromArgb(32, 33, 36);
                label1.Text = "LIGHT";
            }
        }
        private void getIni() {
            settings setting = new settings();
            setting.readIni();
            if (setting.theme == "dark")
            {
                siticoneOSToggleSwith1.Checked = true;
                this.BackColor = Color.FromArgb(32, 33, 36);
                this.ForeColor = Color.White;
            }
            else
            {
                siticoneOSToggleSwith1.Checked = false;
                this.BackColor = Color.White;
                this.ForeColor = Color.FromArgb(32, 33, 36);
            }
            label1.Text = setting.theme.ToUpper();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
