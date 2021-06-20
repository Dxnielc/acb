using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyExploits;

namespace roblox_hacks_by_daniel
{
    public partial class Form1 : Form
    {
        EasyExploits.Module module = new EasyExploits.Module();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          module.ExecuteScript(fastColoredTextBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            module.LaunchExploit();
        }
    }
}
